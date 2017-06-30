-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 04, 2016 at 02:06 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `cars_bit_1a`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_cars`
--

CREATE TABLE IF NOT EXISTS `tbl_cars` (
  `id_car` int(10) NOT NULL AUTO_INCREMENT,
  `id_make` int(10) NOT NULL,
  `price` int(10) unsigned NOT NULL,
  `moreinfo` text NOT NULL,
  `picture` varchar(15) NOT NULL,
  PRIMARY KEY (`id_car`),
  KEY `id_make` (`id_make`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbl_cars`
--

INSERT INTO `tbl_cars` (`id_car`, `id_make`, `price`, `moreinfo`, `picture`) VALUES
(1, 3, 28000, '', ''),
(2, 2, 28000, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_makes`
--

CREATE TABLE IF NOT EXISTS `tbl_makes` (
  `id_make` int(10) NOT NULL AUTO_INCREMENT,
  `make` varchar(15) NOT NULL,
  PRIMARY KEY (`id_make`),
  UNIQUE KEY `make` (`make`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tbl_makes`
--

INSERT INTO `tbl_makes` (`id_make`, `make`) VALUES
(1, 'Волга'),
(2, 'Москвич'),
(3, 'Трабант');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE IF NOT EXISTS `tbl_users` (
  `id_user` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(15) NOT NULL,
  `passwd` varchar(15) NOT NULL,
  `usertype` tinyint(4) NOT NULL,
  `personname` varchar(20) NOT NULL,
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`id_user`, `username`, `passwd`, `usertype`, `personname`) VALUES
(1, 'admin', 'admin', 1, 'Администратор');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_cars`
--
ALTER TABLE `tbl_cars`
  ADD CONSTRAINT `tbl_cars_ibfk_1` FOREIGN KEY (`id_make`) REFERENCES `tbl_makes` (`id_make`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
