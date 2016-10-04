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


-- Dumping structure for procedure apoteka.dodajFarmaceutskogTehnicara
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajFarmaceutskogTehnicara`(in jmb varchar(13), in ime varchar(20), in prezime varchar(20), in adresa varchar(50), in datum date, in brojPoste int, in plata decimal(19,4))
BEGIN
	INSERT INTO osoba values(jmb, ime, prezime, adresa, datum, brojPoste);
    insert into zaposleni values(jmb, plata);
    insert into farmaceutski_tehnicar value(jmb);
END//
DELIMITER ;


-- Dumping structure for procedure apoteka.dodajLijekUBazu
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `dodajLijekUBazu`(in SifraProizvoda varchar(20), in Naziv varchar(50), in NazivProizvodjaca varchar(50), in Cijena decimal(19,4), in RokUpotrebe date, in kolicina int, in ATCSifra varchar(20), in Oblik varchar(20), in Lista varchar(20))
BEGIN
insert into proizvod values(SifraProizvoda, Naziv, NazivProizvodjaca, Cijena, RokUpotrebe, kolicina);
insert into lijek values(SifraProizvoda, ATCSifra, Oblik, Lista);
END//
DELIMITER ;


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


-- Dumping structure for procedure apoteka.obrisiProizvod
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `obrisiProizvod`(in sifra varchar(20))
BEGIN
delete FROM apoteka.proizvod WHERE SifraProizvoda = `sifra`;
END//
DELIMITER ;


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


-- Dumping structure for procedure apoteka.sumaStavkiRacuna
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `sumaStavkiRacuna`(in `sifDok` integer, out `racun` decimal)
BEGIN
declare suma  decimal;
select sum(p.cijena * p.kolicina) into suma 
from proizvod p join racun_stavka rs on (p.sifraProizvoda = rs.sifraProizvoda)
where idRacuna = `sifDok`;
update racun
set iznosRacuna = suma
where idRacuna = `sifDok`;
END//
DELIMITER ;


-- Dumping structure for trigger apoteka.azurirajDatum
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `azurirajDatum` AFTER INSERT ON `racun` FOR EACH ROW update racun r set r.datumIzdavanja = now()//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


-- Dumping structure for trigger apoteka.lijek_AFTER_DELETE
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `lijek_AFTER_DELETE` AFTER DELETE ON `lijek` FOR EACH ROW BEGIN
      DELETE FROM proizvod
      WHERE 
      proizvod.SifraProizvoda=OLD.SifraProizvoda;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


-- Dumping structure for trigger apoteka.proizvod_BEFORE_INSERT
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `proizvod_BEFORE_INSERT` BEFORE INSERT ON `proizvod` FOR EACH ROW BEGIN
if (new.RokUpotrebe <= now()) then
 SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT =  'Upozorenje: Rok trajanja je istekao';
 end if;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


-- Dumping structure for trigger apoteka.suma
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `suma` BEFORE INSERT ON `racun_stavka` FOR EACH ROW update racun_stavka rs set rs.iDracuna = new//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


-- Dumping structure for trigger apoteka.suma2
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `suma2` AFTER INSERT ON `racun_stavka` FOR EACH ROW BEGIN
call sumaStaviRacuna(idRacuna);
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;


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
