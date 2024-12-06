-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2024 at 11:51 PM
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
('EMP00001', '001', 'admin', NULL, 'password'),
('EMP00002', '001', 'Adrian', 'Cruz', 'password'),
('EMP00003', '001', 'Linda', 'Huynh', 'password'),
('EMP00004', '001', 'Donna', 'Nguyen', 'password'),
('EMP00005', '001', 'Anthony', 'Nava', 'password'),
('EMP00006', '001', 'Chris', 'Nguyen', 'password'),
('EMP00007', '001', 'Julian', 'Posadas', 'password'),
('EMP00008', '002', 'Maria', 'Wilson', 'P8bZ1qRf'),
('EMP00009', '002', 'James', 'Moore', 'M7dF3lVq'),
('EMP00010', '002', 'Isabella', 'Taylor', 'S6zJ2yXv'),
('EMP00011', '002', 'Ethan', 'Lee', 'N5oW8kRr'),
('EMP00012', '002', 'Charlotte', 'Kim', 'Q9pD2yZx'),
('EMP00013', '003', 'Oliver', 'Brown', 'C0zK3tN8'),
('EMP00014', '003', 'Amelia', 'Martinez', 'H7uP1wJ9'),
('EMP00015', '003', 'Lucas', 'Rodriguez', 'T2sX4vP7'),
('EMP00016', '003', 'Mason', 'Perez', 'B6aM3jY8'),
('EMP00017', '003', 'Sophie', 'Taylor', 'D1eV9uZ4'),
('EMP00018', '001', 'John', 'Smith', NULL);

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

--
-- Dumping data for table `ims_logs`
--

INSERT INTO `ims_logs` (`log_entry_id`, `employee_id`, `warehouse_id`, `inventory_sku`, `log_entry_date`, `log_entry_type`, `last_update`) VALUES
('E001', 'EMP00003', '002', '109876543210987', '2024-12-05 14:33:33', 'Added item.', '0000-00-00 00:00:00'),
('E002', 'EMP00004', '002', '109876543210987', '2024-12-05 14:33:33', 'Price adjustment.', '2024-12-06 14:38:16'),
('E003', 'EMP00002', '001', '432109876543210', '2024-12-06 14:46:21', 'Updated Item Description.', '0000-00-00 00:00:00');

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
('109876543210987', '002', 'Mouse', 600, 'Rack 11, Bin 4', 'Wireless Mouse, 1600 DPI', '2026-01-15', 'Accessory', 'Razer Inc.', 30, 60, 9),
('210987654321098', '002', 'Keyboard', 500, 'Rack 10, Bin 2', 'Mechanical Keyboard, RGB backlit', '2026-01-01', 'Accessory', 'Logitech Inc.', 50, 90, 8),
('321098365432109', '003', 'Heat Sink', 500, 'Rack 19, Bin 5', 'Copper heat sink for CPU cooling', '2025-07-30', 'Raw Material', 'Cooling Tech Inc.', 20, 50, NULL),
('321098765432109', '001', 'Cooling Fan', 250, 'Rack 8, Bin 5', 'Cooler Master Hyper 212', '2025-11-01', 'Computer Part', 'Cooler Master', 40, 60, 7),
('432109876543210', '001', 'Power Supply', 120, 'Rack 7, Bin 3', 'EVGA SuperNOVA 850W 80+ Gold', '2025-07-01', 'Computer Part', 'EVGA Corporation', 100, 180, 8),
('432179876543210', '003', 'Screws and Nuts', 3000, 'Rack 18, Bin 4', 'Metal screws and nuts for assembly', '2025-10-31', 'Raw Material', 'Fasteners Co.', 1, 3, NULL),
('543210987654321', '001', 'Graphics Card', 50, 'Rack 6, Bin 1', 'NVIDIA RTX 3080 10GB', '2025-08-20', 'Computer Part', 'NVIDIA Corporation', 700, 1000, 9),
('543210997654321', '003', 'Wires and Cables', 5000, 'Rack 17, Bin 2', 'Electrical wires, 10m each', '2025-12-31', 'Raw Material', 'Cable Supplies Ltd.', 2, 5, NULL),
('654321098765432', '001', 'SSD', 180, 'Rack 4, Bin 4', 'Samsung 970 EVO 1TB NVMe SSD', '2025-12-15', 'Computer Part', 'Samsung Electronics', 100, 150, 9),
('654321099765432', '003', 'Plastic Shell', 1500, 'Rack 16, Bin 3', 'Plastic outer shell for computer cases', '2025-09-30', 'Raw Material', 'PlasticWorks Inc.', 5, 15, NULL),
('765430109876543', '003', 'Aluminum Frame', 1000, 'Rack 15, Bin 1', 'Aluminum frame for computer chassis', '2025-04-30', 'Raw Material', 'Metal Supply Co.', 10, 30, NULL),
('765432109876543', '001', 'RAM', 200, 'Rack 3, Bin 2', 'Corsair Vengeance 16GB DDR4', '2025-05-01', 'Computer Part', 'Corsair', 80, 130, 8),
('876543210887654', '002', 'Chassis', 150, 'Rack 13, Bin 3', 'Mid Tower Case with Tempered Glass', '2025-05-20', 'Accessory', 'NZXT Inc.', 70, 120, 8),
('876543210987654', '001', 'CPU', 150, 'Rack 2, Bin 3', 'Intel i7-12700K 8-core processor', '2025-06-30', 'Computer Part', 'Intel Corporation', 300, 450, 9),
('987654321098765', '002', 'Monitor', 100, 'Rack 12, Bin 1', '27-inch 4K Display', '2025-12-01', 'Accessory', 'Dell Technologies', 300, 450, 9),
('987654321234567', '001', 'Motherboard', 100, 'Rack 1, Bin 1', 'ASUS Z590 motherboard, ATX size', '2025-12-31', 'Computer Part', 'ASUS Technologies', 150, 250, 10);

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
('002', '1600 Holloway Ave, San Francisco, CA 94132', '951-134-2329'),
('003', '1234 Main St, Los Angeles, CA 90001', '951-145-4567');

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
  ADD PRIMARY KEY (`employee_id`),
  ADD KEY `inventory_warehouse_id_fk` (`warehouse_id`);

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
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`) ON UPDATE CASCADE;

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
