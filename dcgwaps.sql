DROP DATABASE if exists dcgwaps;
CREATE DATABASE dcgwaps;
USE dcgwaps;

CREATE TABLE `branch` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`name` VARCHAR(255) NOT NULL,
`location` VARCHAR(255) NOT NULL,
`city` VARCHAR(255) NOT NULL,
`status` VARCHAR(20) NOT NULL);

CREATE TABLE `employee` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`home_branch_id` INT,
`branch_id` INT,
`fname` VARCHAR(255) NOT NULL,
`mname` VARCHAR(255) NOT NULL,
`lname` VARCHAR(255) NOT NULL,
`address` VARCHAR(255) NOT NULL,
`contact_number` VARCHAR(255) NOT NULL,
`gender` VARCHAR(6) NOT NULL,
`birthday` DATE NOT NULL,
`position` VARCHAR(20) NOT NULL,
`status` VARCHAR(20) NOT NULL,
FOREIGN KEY(`branch_id`) REFERENCES `branch`(`id`),
FOREIGN KEY(`home_branch_id`) REFERENCES `branch`(`id`));

CREATE TABLE `users` (
`userID` INT AUTO_INCREMENT PRIMARY KEY,
`emp_id` INT NULL,
`username` VARCHAR(20) NOT NULL,
`password` VARCHAR(20) NOT NULL,
`status` VARCHAR(10) NOT NULL, 	
FOREIGN KEY(`emp_id`) REFERENCES `employee`(`id`));

CREATE TABLE `service` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`branch_id` INT NOT NULL,
`name` VARCHAR(255) NOT NULL,
`description` VARCHAR(255),
`price` DOUBLE(10,2) NOT NULL,
`status` VARCHAR(20) NOT NULL,
FOREIGN KEY(`branch_id`) REFERENCES `branch`(`id`));

CREATE TABLE `barber_employee` (
`emp_id` INT PRIMARY KEY,
`tot_salary` double(10,2) NOT NULL,
`sal_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`emp_id`) REFERENCES `employee`(`id`));

CREATE TABLE `cashier_employee` (
`emp_id` INT PRIMARY KEY,
`mon_salary` double(10,2) NOT NULL,
`allowance` double(10,2) NOT NULL,
`sal_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`emp_id`) REFERENCES `employee`(`id`));


CREATE TABLE `client_transaction` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`branch_id` INT NOT NULL,
`status` VARCHAR(20) NOT NULL,
`total_amt` DOUBLE (10,2),
`trans_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`branch_id`) REFERENCES `branch`(id));

CREATE TABLE `service_details` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`client_transaction_id` INT NOT NULL,
`barber_id` INT NOT NULL,
`service_id` INT NOT NULL,
`added_on` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`client_transaction_id`) REFERENCES `client_transaction`(`id`),
FOREIGN KEY(`barber_id`) REFERENCES `barber_employee`(`emp_id`),
FOREIGN KEY(`service_id`) REFERENCES `service`(`id`));

CREATE TABLE `payment` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`client_transaction_id` INT NOT NULL,
`total_amount` double(10,2) NOT NULL,
`pay_amount` double(10,2) NOT NULL,
`payment_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`client_transaction_id`) REFERENCES `client_transaction`(`id`));

CREATE TABLE `attendance_log` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`emp_id` INT NOT NULL,
`io` VARCHAR(12),
`time_in` datetime,
`time_out` datetime null,
FOREIGN KEY(`emp_id`) REFERENCES `employee`(`id`));

CREATE TABLE `branch_sale` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`branch_id` INT NOT NULL,
`sale` DOUBLE(10,2) NOT NULL,
`sale_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`branch_id`) REFERENCES `branch`(`id`));

CREATE TABLE `cashier_cash_advance` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`cashier_id` INT NOT NULL,
`amount` double(10,2) NOT NULL,
`adv_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
FOREIGN KEY(`cashier_id`) REFERENCES `cashier_employee`(`emp_id`));

CREATE TABLE `employee_transfer` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`emp_id` INT NOT NULL, 
`branch_id` INT NOT NULL, 
`date_from` DATE NOT NULL,
`date_to` DATE NOT NULL,
FOREIGN KEY(`emp_id`) REFERENCES `employee`(`id`),
FOREIGN KEY(`branch_id`) REFERENCES `branch`(`id`));

CREATE TABLE `barber_salary_archive` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`emp_id` INT NOT NULL,
`tot_salary` double(10,2) NOT NULL,
`sal_date` datetime NOT NULL,
FOREIGN KEY(`emp_id`) REFERENCES `barber_employee`(`emp_id`));

CREATE TABLE `cashier_emp_archive` (
`id` INT AUTO_INCREMENT PRIMARY KEY,
`emp_id` INT NOT NULL,
`mon_salary` double(10,2) NOT NULL,
`allowance` double(10,2) NOT NULL,
`sal_date` datetime NOT NULL,
FOREIGN KEY(`emp_id`) REFERENCES `cashier_employee`(`emp_id`));