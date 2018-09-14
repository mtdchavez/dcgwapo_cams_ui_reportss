INSERT INTO `branch` (`name`, `location`, `city`, `status`) VALUES
('Main Toril', 'Toril', 'Davao City', 'Open'),
('Toril Palengke', 'Toril Public Market', 'Davao City', 'Open');


INSERT INTO `employee` (`home_branch_id`, `branch_id`, `fname`, `mname`, `lname`, `address`, `contact_number`,`gender`, `birthday`, `position`, `status`) VALUES
(1,1, 'Lebron', 'Raymone', 'James', 'Cleveland, Ohio', '90191900', 'Male', '1984-12-30', 'Barber', 'Active'),
(1,1, 'John', 'Doe', 'Doe', 'Toril, Davao City', '0101111', 'Male','1999-01-01', 'Barber', 'Active'),
(1,1, 'Dionisia', 'Pacy', 'Pacman', 'Toril,Davao', '910101','Female', '1999-01-01', 'Cashier', 'Active'),
(2,2, 'Raul', 'Smith', 'Marquez', 'Bayabas, Davao City', '90191900', 'Male', '1984-12-30', 'Barber', 'Active'),
(2,2, 'Joseph', 'Doe', 'Ganda', 'Eden, Davao City', '0101111', 'Male','1999-01-01', 'Barber', 'Active'),
(2,2, 'Wandy', 'Pacy', 'Bongga', 'Astorga, Sta Cruz', '910101','Female', '1999-01-01', 'Cashier', 'Active'),
(1,1, 'Admin', 'Admin', 'Admin', 'Toril, Davao City', '910101', 'Male', '1999-01-01', 'Admin', 'Active');


INSERT INTO `service` (`branch_id`, `name`, `description`, `price`, `status`) VALUES
(1, 'Haircut', 'regular haircut', 25.00, 'Active'),
(1, 'Opaw', 'no hair', 80.00, 'Active'),
(1, 'Massage', 'soft massage', 100.50, 'Active');

INSERT INTO barber_employee
VALUES
(1, 0, NOW()),
(2, 0, NOW()),
(4, 0, NOW()),
(5, 0, NOW());



INSERT INTO `users`
VALUES
(null, 3, 'mamid', 'mamid', 'Active'),
(null, 6, 'bonggaka', 'bonggaka', 'Active'),
(null, 7, 'admin', 'admin', 'Active');

