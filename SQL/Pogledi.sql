-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.10-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for apoteka
CREATE DATABASE IF NOT EXISTS `apoteka` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `apoteka`;


-- Dumping structure for view apoteka.farmaceutski_tehnicar_info_pogled
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `farmaceutski_tehnicar_info_pogled` (
	`JMB` VARCHAR(13) NOT NULL COLLATE 'utf8_general_ci',
	`Ime` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Prezime` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`DatumRodjenja` DATE NOT NULL,
	`Adresa` VARCHAR(50) NULL COLLATE 'utf8_general_ci',
	`BrojPoste` INT(11) NOT NULL,
	`Naziv` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Plata` DECIMAL(19,4) NOT NULL
) ENGINE=MyISAM;


-- Dumping structure for view apoteka.lijek_info_pogled
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `lijek_info_pogled` (
	`SifraProizvoda` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Naziv` VARCHAR(50) NOT NULL COLLATE 'utf8_general_ci',
	`NazivProizvodjaca` VARCHAR(50) NOT NULL COLLATE 'utf8_general_ci',
	`Cijena` DECIMAL(19,4) NOT NULL,
	`RokUpotrebe` DATE NOT NULL,
	`Kolicina` INT(11) NOT NULL,
	`ATCSifra` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`OblikLijeka` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Lista` VARCHAR(20) NULL COLLATE 'utf8_general_ci'
) ENGINE=MyISAM;


-- Dumping structure for view apoteka.recept_info_pogled
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `recept_info_pogled` (
	`IdRecepta` INT(11) NOT NULL,
	`DatumIzdavanja` DATE NOT NULL,
	`PreporucenaTerapija` VARCHAR(100) NOT NULL COLLATE 'utf8_general_ci',
	`IdLjekara` VARCHAR(50) NOT NULL COLLATE 'utf8_general_ci',
	`ZdravstvenaUstanova` VARCHAR(100) NOT NULL COLLATE 'utf8_general_ci',
	`Ime` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`Prezime` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`DatumRodjenja` DATE NOT NULL,
	`Adresa` VARCHAR(50) NULL COLLATE 'utf8_general_ci',
	`Naziv` VARCHAR(20) NOT NULL COLLATE 'utf8_general_ci',
	`BrojPoste` INT(11) NOT NULL
) ENGINE=MyISAM;


-- Dumping structure for view apoteka.farmaceutski_tehnicar_info_pogled
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `farmaceutski_tehnicar_info_pogled`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `farmaceutski_tehnicar_info_pogled` AS select `f_t`.`JMB` AS `JMB`,`o`.`Ime` AS `Ime`,`o`.`Prezime` AS `Prezime`,`o`.`DatumRodjenja` AS `DatumRodjenja`,`o`.`Adresa` AS `Adresa`,`o`.`BrojPoste` AS `BrojPoste`,`m`.`Naziv` AS `Naziv`,`z`.`Plata` AS `Plata` from (((`farmaceutski_tehnicar` `f_t` join `zaposleni` `z` on((`f_t`.`JMB` = `z`.`JMB`))) join `osoba` `o` on((`z`.`JMB` = `o`.`JMB`))) join `mjesto` `m` on((`o`.`BrojPoste` = `m`.`BrojPoste`)));


-- Dumping structure for view apoteka.lijek_info_pogled
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `lijek_info_pogled`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `lijek_info_pogled` AS select `p`.`SifraProizvoda` AS `SifraProizvoda`,`p`.`Naziv` AS `Naziv`,`p`.`NazivProizvodjaca` AS `NazivProizvodjaca`,`p`.`Cijena` AS `Cijena`,`p`.`RokUpotrebe` AS `RokUpotrebe`,`p`.`Kolicina` AS `Kolicina`,`l`.`ATCSifra` AS `ATCSifra`,`l`.`OblikLijeka` AS `OblikLijeka`,`l`.`Lista` AS `Lista` from (`proizvod` `p` join `lijek` `l` on((`p`.`SifraProizvoda` = `l`.`SifraProizvoda`)));


-- Dumping structure for view apoteka.recept_info_pogled
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `recept_info_pogled`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `recept_info_pogled` AS select `r`.`IdRecepta` AS `IdRecepta`,`r`.`DatumIzdavanja` AS `DatumIzdavanja`,`r`.`PreporucenaTerapija` AS `PreporucenaTerapija`,`r`.`IdLjekara` AS `IdLjekara`,`r`.`ZdravstvenaUstanova` AS `ZdravstvenaUstanova`,`o`.`Ime` AS `Ime`,`o`.`Prezime` AS `Prezime`,`o`.`DatumRodjenja` AS `DatumRodjenja`,`o`.`Adresa` AS `Adresa`,`m`.`Naziv` AS `Naziv`,`m`.`BrojPoste` AS `BrojPoste` from (((`recept` `r` join `kupac` `k` on((`r`.`JMB` = `k`.`JMB`))) join `osoba` `o` on((`k`.`JMB` = `o`.`JMB`))) join `mjesto` `m` on((`o`.`BrojPoste` = `m`.`BrojPoste`)));
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
