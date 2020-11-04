-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 03, 2020 at 03:36 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `iantestinventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `datainventory`
--

CREATE TABLE `datainventory` (
  `prodNo` bigint(15) NOT NULL,
  `prodItem` varchar(999) NOT NULL,
  `prodBrand` varchar(999) NOT NULL,
  `prodPrice` int(255) NOT NULL,
  `prodQuantity` int(250) NOT NULL,
  `prodDOA` date NOT NULL,
  `prodEXPD` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datainventory`
--

INSERT INTO `datainventory` (`prodNo`, `prodItem`, `prodBrand`, `prodPrice`, `prodQuantity`, `prodDOA`, `prodEXPD`) VALUES
(750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', 8, 1, '2020-03-23', '2021-03-23'),
(4800016022180, 'Great Taste White Crema', 'Universal Robina', 10, 1, '2020-06-14', '2021-06-14'),
(4800016043093, 'Nips White Chocolate', 'Jack n Jill', 1, 1, '2020-09-18', '2021-09-18'),
(4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', 1, 1, '2020-08-28', '2021-02-28'),
(4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', 13, 1, '2020-09-05', '2021-02-05'),
(4800016644801, 'Piattos Cheese', 'Jack n Jill', 13, 1, '2020-09-12', '2021-03-12'),
(4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', 13, 1, '2020-02-07', '2020-09-07'),
(4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', 6, 1, '2020-07-12', '2021-07-12'),
(4800103341835, 'Chubby Choco Chewy Candy', 'SPI Corporation', 1, 1, '2020-03-17', '2021-03-17'),
(4800103343563, 'Vita Cubes Singles', 'SPI Corporation', 1, 1, '2020-02-01', '2021-02-01'),
(4800194116466, 'Pillows Choco-Filled Crackers', 'Oishi', 8, 1, '2020-02-23', '2021-02-03'),
(4800361413480, 'Milo 24g', 'Nestle Philippines INC.', 9, 1, '2020-04-30', '2021-04-30'),
(4800361415347, 'Nescafe Original Twin Pack', 'Nestle Philippines INC.', 11, 1, '2020-07-31', '2021-07-31'),
(4800818808760, 'Yakee! Super Asim Gumball', 'Columbia Intl Food Product INC.', 1, 1, '2020-07-27', '2021-07-25'),
(4800818808906, 'Potchi Strawberyy Cream', 'Columbia Intl Food Productions INC.', 1, 1, '2020-08-19', '2021-08-19'),
(4804888589505, 'Hany Milk Chocolate', 'Annie Candy Manufacturing', 2, 1, '2020-08-14', '2021-03-14'),
(4804888589987, 'Ube Purple Yam Candy', 'Annie Candy Manufacturing', 1, 1, '2020-09-12', '2021-03-12'),
(4806507621863, 'Burst Assorted Fruit Flavor Chewy Candy', 'Guangdong Xiaomimi Foodstuff Corporation', 1, 1, '2020-06-19', '2022-06-19'),
(4806511111121, 'Topsee Milk Chocolate', 'Delicatesse Food Corporation', 1, 1, '2020-08-26', '2021-08-26'),
(4809010686011, 'Lemon Square Cheese Cake', 'Big E Food Corporation', 7, 1, '2020-10-30', '2021-10-30'),
(4902430426464, 'Downy Expert AntiBac', 'Procter & Gamble Philippines INC.', 14, 1, '2020-07-12', '2021-07-12'),
(4902430583169, 'Ariel Sunrise Fresh', 'Procter & Gamble Philippines INC.', 12, 1, '2020-07-12', '2020-07-12'),
(8851717904967, 'Delight 100ml', 'Dutch Mill Corporation', 12, 1, '2020-11-16', '2021-11-16'),
(8935001720126, 'Mentos Tropical Mix', 'Perfetti Van Melle', 1, 1, '2020-07-08', '2022-07-08'),
(8993175537124, 'Richeese Cheese Wafer', 'Enerlife Philippines INC.', 6, 1, '2020-07-23', '2021-07-23'),
(8993175559890, 'Richoco Chocolate Wafer', 'Enerlife Philippines INC.', 6, 1, '2020-07-26', '2021-07-26');

-- --------------------------------------------------------

--
-- Table structure for table `datasalesinventory`
--

CREATE TABLE `datasalesinventory` (
  `refNo` bigint(15) NOT NULL,
  `salesNo` bigint(249) NOT NULL,
  `salesItem` varchar(249) NOT NULL,
  `salesBrand` varchar(249) NOT NULL,
  `salesDate` timestamp NOT NULL DEFAULT current_timestamp(),
  `salesPrice` int(249) NOT NULL,
  `salesQty` int(249) NOT NULL,
  `salesTotal` int(249) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `datasalesinventory`
--

INSERT INTO `datasalesinventory` (`refNo`, `salesNo`, `salesItem`, `salesBrand`, `salesDate`, `salesPrice`, `salesQty`, `salesTotal`) VALUES
(2, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-24 23:43:07', 10, 1, 10),
(4, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-24 23:54:56', 10, 1, 10),
(5, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-24 23:55:50', 1, 1, 1),
(6, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-24 23:56:21', 1, 1, 1),
(7, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-24 23:56:27', 1, 1, 1),
(8, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', '2020-10-24 23:59:02', 1, 1, 1),
(13, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', '2020-10-25 00:00:00', 13, 1, 13),
(14, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', '2020-10-25 00:00:04', 13, 1, 13),
(15, 4800016644801, 'Piattos Cheese', 'Jack n Jill', '2020-10-25 00:00:35', 13, 1, 13),
(16, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-25 00:01:07', 13, 1, 13),
(17, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-25 00:01:47', 13, 1, 13),
(19, 4800016306013, 'Maxx Honey Lemon', 'Jack n Jill', '2020-10-25 00:02:15', 1, 1, 1),
(20, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-25 00:03:13', 10, 1, 10),
(21, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-25 00:03:48', 10, 1, 10),
(22, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-25 00:04:07', 10, 1, 10),
(23, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-25 00:07:31', 13, 1, 13),
(24, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:08:28', 1, 1, 1),
(25, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:08:58', 1, 1, 1),
(26, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:09:30', 1, 1, 1),
(27, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 00:46:02', 8, 1, 8),
(28, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 00:46:58', 8, 1, 8),
(29, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 00:56:46', 1, 1, 1),
(30, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 00:57:55', 8, 1, 8),
(31, 4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', '2020-10-25 01:10:05', 6, 1, 6),
(32, 4800092113338, 'Rebisco Crackers', 'Republic Biscuit Corporation', '2020-10-25 01:11:11', 6, 1, 6),
(33, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 01:12:21', 8, 1, 8),
(34, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 01:14:16', 8, 1, 8),
(35, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 01:15:03', 1, 1, 1),
(36, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 01:24:30', 8, 1, 8),
(37, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 01:26:33', 1, 1, 1),
(38, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-25 01:28:48', 1, 1, 1),
(39, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 01:31:24', 8, 1, 8),
(40, 750515018402, 'Skyflakes Crackers 25g', 'Monde MY San Corporation', '2020-10-25 01:31:59', 8, 1, 8),
(41, 4800016022180, '', '', '2020-10-25 01:33:55', 0, 0, 0),
(42, 4800016022180, '', '', '2020-10-25 01:34:03', 0, 0, 0),
(43, 4800016022180, '', '', '2020-10-25 01:34:41', 0, 0, 0),
(44, 4800016671807, 'Piattos Sour Cream & Onion', 'Jack n Jill', '2020-10-26 11:55:30', 13, 1, 13),
(45, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', '2020-10-26 11:59:31', 13, 1, 13),
(46, 4800016622533, 'V Cut Spicy Barbeque Flavor', 'Jack n Jill', '2020-10-26 12:00:43', 13, 1, 13),
(47, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:29', 1, 1, 1),
(48, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:29', 1, 1, 1),
(49, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:30', 1, 1, 1),
(50, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:30', 1, 1, 1),
(51, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(52, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(53, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(54, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(55, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(56, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(57, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(58, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(59, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(60, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(61, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(62, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(63, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(64, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(65, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(66, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(67, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(68, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(69, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(70, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:31', 1, 1, 1),
(71, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(72, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(73, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(74, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(75, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(76, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(77, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(78, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(79, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(80, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(81, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(82, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(83, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(84, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(85, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(86, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(87, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(88, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(89, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(90, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(91, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(92, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(93, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(94, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(95, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(96, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(97, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(98, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(99, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(100, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(101, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(102, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:32', 1, 1, 1),
(103, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(104, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(105, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(106, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(107, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(108, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(109, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(110, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(111, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(112, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(113, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(114, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(115, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(116, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(117, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(118, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(119, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(120, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(121, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(122, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(123, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(124, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(125, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(126, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(127, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(128, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(129, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(130, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(131, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(132, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(133, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:33', 1, 1, 1),
(134, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(135, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(136, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(137, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(138, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(139, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(140, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(141, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(142, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(143, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(144, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(145, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:05:34', 1, 1, 1),
(146, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-26 12:06:59', 10, 1, 10),
(147, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-26 12:07:32', 10, 1, 10),
(148, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:09:06', 1, 1, 1),
(149, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:11:06', 1, 1, 1),
(150, 4800016022180, 'Great Taste White Crema', 'Universal Robina', '2020-10-26 12:11:16', 10, 1, 1),
(151, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:12:24', 1, 1, 1),
(152, 4800016043093, 'Nips White Chocolate', 'Jack n Jill', '2020-10-26 12:13:00', 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `userinventory`
--

CREATE TABLE `userinventory` (
  `userNo.` int(11) NOT NULL,
  `userName` varchar(12) NOT NULL,
  `userPass` varchar(12) NOT NULL,
  `userPrivilages` int(11) NOT NULL,
  `userTimein` datetime NOT NULL,
  `userTimeout` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userinventory`
--

INSERT INTO `userinventory` (`userNo.`, `userName`, `userPass`, `userPrivilages`, `userTimein`, `userTimeout`) VALUES
(1, 'Nefarry1', 'aislife22', 1, '2020-10-29 00:00:00', '2020-10-29 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `datainventory`
--
ALTER TABLE `datainventory`
  ADD PRIMARY KEY (`prodNo`);

--
-- Indexes for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  ADD UNIQUE KEY `refNo` (`refNo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `datasalesinventory`
--
ALTER TABLE `datasalesinventory`
  MODIFY `refNo` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=153;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
