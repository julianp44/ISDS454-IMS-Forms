-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2024 at 03:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventorydatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employee_id` char(8) NOT NULL,
  `warehouse_id` char(3) NOT NULL,
  `employee_firstname` varchar(45) DEFAULT NULL,
  `employee_lastname` varchar(45) DEFAULT NULL,
  `login_password` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employee_id`, `warehouse_id`, `employee_firstname`, `employee_lastname`, `login_password`) VALUES
('11111111', '001', 'admin', NULL, 'password'),
('22222222', '001', 'Adrian', 'Cruz', 'password'),
('33333333', '001', 'Linda', 'Huynh', 'password'),
('44444444', '001', 'Donna ', 'Nguyen', 'password'),
('55555555', '002', 'Anthony', 'Nava', 'password'),
('66666666', '002', 'Chris', 'Nguyen', 'password'),
('77777777', '002', 'Julian', 'Posadas', 'password');

-- --------------------------------------------------------

--
-- Table structure for table `ims_logs`
--

CREATE TABLE `ims_logs` (
  `log_entry_id` varchar(10) NOT NULL,
  `employee_id` char(8) NOT NULL,
  `warehouse_id` char(3) NOT NULL,
  `inventory_sku` char(15) NOT NULL,
  `log_entry_date` datetime DEFAULT NULL,
  `log_entry_type` varchar(500) DEFAULT NULL,
  `last_update` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `inventory_sku` char(15) NOT NULL,
  `warehouse_id` char(3) NOT NULL,
  `item_name` varchar(50) DEFAULT NULL,
  `item_quantity` int(11) DEFAULT NULL,
  `item_location` varchar(50) DEFAULT NULL,
  `item_description` varchar(200) DEFAULT NULL,
  `item_expirationdate` date DEFAULT NULL,
  `inventory_type` varchar(30) DEFAULT NULL,
  `supplier_info` varchar(200) DEFAULT NULL,
  `cost_per_unit` double DEFAULT NULL,
  `sellingprice_per_unit` double DEFAULT NULL,
  `users_review` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`inventory_sku`, `warehouse_id`, `item_name`, `item_quantity`, `item_location`, `item_description`, `item_expirationdate`, `inventory_type`, `supplier_info`, `cost_per_unit`, `sellingprice_per_unit`, `users_review`) VALUES
('112874387338475', '002', 'Copper', 30, 'Rack 8, Bin 1', 'Copper, 5 lbs/unit', '2024-11-29', 'Raw Material', 'Copper Supply Co.', 5, 20, 9),
('123456789101101', '001', 'Silver', 60, 'Rack 5, Bin 2', 'Silver, 5 lbs/unit', '2024-11-28', 'Raw Material', 'Silver Palace Inc.', 20, 50, 8),
('123456869793432', '001', 'Wood Pallet', 200, 'Rack 20, Bin 5', '1 Wooden Pallet/Unit', '0000-00-00', 'Raw Material', 'Lumber Supply Co', 5, 10, NULL);

-- --------------------------------------------------------

--
-- Stand-in structure for view `inventory_view`
-- (See below for the actual view)
--
CREATE TABLE `inventory_view` (
`SKU` char(15)
,`Warehouse ID` char(3)
,`Name` varchar(50)
,`Quantity` int(11)
,`Location` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `warehouse`
--

CREATE TABLE `warehouse` (
  `warehouse_id` char(3) NOT NULL,
  `warehouse_address` varchar(300) DEFAULT NULL,
  `warehouse_phone` char(13) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `warehouse`
--

INSERT INTO `warehouse` (`warehouse_id`, `warehouse_address`, `warehouse_phone`) VALUES
('001', '800 N State College Blvd, Fullerton, CA 92831', '951-123-1234'),
('002', '1600 Holloway Ave, San Francisco, CA 94132', '951-134-2329');

-- --------------------------------------------------------

--
-- Structure for view `inventory_view`
--
DROP TABLE IF EXISTS `inventory_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `inventory_view`  AS SELECT `inventory`.`inventory_sku` AS `SKU`, `inventory`.`warehouse_id` AS `Warehouse ID`, `inventory`.`item_name` AS `Name`, `inventory`.`item_quantity` AS `Quantity`, `inventory`.`item_location` AS `Location` FROM `inventory` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `ims_logs`
--
ALTER TABLE `ims_logs`
  ADD PRIMARY KEY (`log_entry_id`,`employee_id`,`warehouse_id`,`inventory_sku`),
  ADD KEY `fk_ims logs_employee1_idx` (`employee_id`),
  ADD KEY `fk_ims_logs_inventory_sku_idx` (`inventory_sku`),
  ADD KEY `fk_ims_logs_warehouse1_idx` (`warehouse_id`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`inventory_sku`),
  ADD KEY `fk_inventory_warehouse_id` (`warehouse_id`);

--
-- Indexes for table `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`warehouse_id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `ims_logs`
--
ALTER TABLE `ims_logs`
  ADD CONSTRAINT `fk_ims_logs_employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ims_logs_inventory_sku` FOREIGN KEY (`inventory_sku`) REFERENCES `inventory` (`inventory_sku`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ims_logs_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`) ON UPDATE CASCADE;

--
-- Constraints for table `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `fk_inventory_warehouse_id` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
