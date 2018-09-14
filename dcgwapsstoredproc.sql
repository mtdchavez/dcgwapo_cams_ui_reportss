USE dcgwaps;
DELIMITER #

CREATE PROCEDURE `addBranch`(IN `brname` VARCHAR(255), IN `brlocation` VARCHAR(255), IN `brcity` VARCHAR(255))
BEGIN 
INSERT INTO `branch`
(`name`, `location`, `city`, `status`)
VALUES
(`brname`, `brlocation`, `brcity`, 0);
END#

CREATE PROCEDURE `updBranch`(IN `brname` VARCHAR(255), IN `brlocation` VARCHAR(255), IN `brcity` VARCHAR(255))
BEGIN
UPDATE `branch` SET `name` = `brname`, `location` = `brlocation`, `city` = `brcity` WHERE `status` = 0;
END#

CREATE PROCEDURE `addEmp`(IN hbID INT, IN bID int, IN fn VARCHAR(255), IN mn VARCHAR(255), IN ln VARCHAR(255), 
IN ad VARCHAR(255), IN cn VARCHAR(255), IN sex VARCHAR(6), IN bday DATE, 
IN role VARCHAR(20))
BEGIN
IF (role = 'Cashier' || role = 'Admin') THEN

INSERT INTO employee
VALUES
(NULL, hbID, bID, fn, mn, ln, ad, cn, sex, bday, role, 'Active');

SET @empID = (SELECT id FROM employee WHERE fname = fn AND mname = mn AND lname = ln);
INSERT INTO users
VALUES
(NULL, @empID, CONCAT(fn,ln), CONCAT(fn,ln,'123'), 'Active');
END IF;
END#

CREATE PROCEDURE `selEmp` ()
BEGIN
SELECT b.id, b.name, e.home_branch_id, e.fname, e.mname, e.lname, e.birthday, e.contact_number, e.position, e.status from branch b INNER JOIN employee e ON e.branch_id = b.id;
END#


CREATE PROCEDURE `selTimeIn`(IN brID INT)
BEGIN
SELECT e.fname, e.lname, e.position, a.time_in from employee e INNER JOIN attendance_log a ON a.emp_id = e.id
WHERE e.branch_id = brID AND DATE(time_in) = CURDATE()
group by a.time_in;
END#

CREATE PROCEDURE `selTimeOut`(IN brID INT)
BEGIN
SELECT e.fname, e.lname, e.position, a.time_out from employee e INNER JOIN attendance_log a ON a.emp_id = e.id
WHERE e.branch_id = brID AND DATE(time_out) = CURDATE()
group by a.time_out;
END#

CREATE PROCEDURE `selCashier` ()
BEGIN
SELECT b.id, b.name , e.fname, e.mname, e.lname, e.birthday, e.contact_number, e.position, e.status from branch b INNER JOIN employee e ON e.branch_id = b.id WHERE e.position = 'Cashier';
END#

CREATE PROCEDURE `selBarber` ()
BEGIN
SELECT b.id, b.name , e.fname, e.mname, e.lname, e.birthday, e.contact_number, e.position, e.status from branch b INNER JOIN employee e ON e.branch_id = b.id WHERE e.position = 'Barber';
END#

CREATE PROCEDURE `addLogs`(IN `empID` INT)
BEGIN
IF EXISTS(SELECT * FROM attendance_log
WHERE emp_id = empID 
AND DATE(time_in) = CURDATE()) THEN
	
    UPDATE attendance_log SET io = 'Time Out', time_out = NOW()
    WHERE emp_id = empID;
    
    SET @sweldo = (SELECT sum(s.price) * 0.6
	FROM service_details sd 
	INNER JOIN service s ON sd.service_id = s.id
	INNER JOIN barber_employee b ON sd.barber_id = b.emp_id 
	INNER JOIN client_transaction t ON sd.client_transaction_id = t.id
	WHERE sd.barber_id = empID
	AND t.status = 'Paid'
    AND DATE(sd.added_on) = CURDATE());
    
    if(@sweldo = NULL) THEN
		UPDATE barber_employee SET tot_salary = 0, sal_date = NOW() WHERE emp_id = empID;
	else	
		UPDATE barber_employee SET tot_salary = @sweldo, sal_date = NOW() WHERE emp_id = empID;
    end if;
    
ELSE
    INSERT INTO attendance_log 
	VALUES
	(NULL, empID, 'Time In', NOW(), NULL);
END IF;
END#

CREATE PROCEDURE `updCashierEmp` (IN `empID` INT, IN `allow` INT)
BEGIN
UPDATE cashier_employee SET mon_salary = 1500.00, allowance = allow WHERE emp_id = empID; 
END #


CREATE PROCEDURE `selClient`()
BEGIN 
SELECT * FROM `client` WHERE name <> 'DEFAULT';
END #

CREATE PROCEDURE `addTrans`(IN c_id INT, IN brID INT)
BEGIN
INSERT INTO client_transaction
VALUES
(NULL, c_id, brID, 'Reserved', 0, NOW());
END#

CREATE PROCEDURE `addOrder` (IN t_id INT, IN b_id INT, IN s_id INT)
BEGIN
INSERT INTO service_details
VALUES
(NULL, t_id, b_id, s_id, now());
UPDATE client_transaction 
SET total_amt = (SELECT SUM(s.price) AS sum_amt FROM service_details sd INNER JOIN service s
ON sd.service_id = s.id WHERE sd.client_transaction_id = t_id)
WHERE id = t_id;
END#

CREATE PROCEDURE `addPayment`(IN t_id INT, IN t_amt DOUBLE, IN p_amt DOUBLE)
BEGIN
INSERT INTO payment
VALUES
(NULL, t_id, t_amt, p_amt, NOW());
UPDATE client_transaction SET status = 'Paid' WHERE id = t_id;
END#

CREATE PROCEDURE `addBranchSale`(IN bID INT)
BEGIN
SET @sale = (SELECT sum(s.price) * 0.4
	FROM service_details sd 
	INNER JOIN service s ON sd.service_id = s.id 
	INNER JOIN client_transaction t ON sd.client_transaction_id = t.id
	WHERE t.branch_id = bID
	AND t.status = 'Paid'
	AND DATE(sd.added_on) = CURDATE());
IF EXISTS(SELECT * FROM branch_sale
WHERE branch_id = bID 
AND DATE(sale_date) = CURDATE()) THEN
	UPDATE branch_sale SET sale = @sale WHERE branch_id = bID;
ELSE 
	INSERT INTO branch_sale
    VALUES
    (NULL, bID, @sale, NOW());
END IF;
END#

CREATE TRIGGER `updBarberSalary`
AFTER
UPDATE ON `barber_employee` FOR EACH ROW
BEGIN
INSERT INTO `barber_salary_archive`
VALUES
(NULL, NEW.emp_id, NEW.tot_salary, NEW.sal_date);
END#

CREATE TRIGGER `updCashierSalary`
AFTER
UPDATE ON `cashier_employee` FOR EACH ROW
BEGIN
INSERT INTO `cashier_emp_archive`
VALUES
(NULL, NEW.emp_id, NEW.mon_salary, NEW.allowance, NEW.sal_date);
END#
DELIMITER ; 	