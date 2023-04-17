-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2023-04-17 15:49:12
-- --------------------------------------
-- Server version 8.0.32 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of character_level
-- 

DROP TABLE IF EXISTS `character_level`;
CREATE TABLE IF NOT EXISTS `character_level` (
  `character_lvl_id` int NOT NULL AUTO_INCREMENT,
  `character_lvl` int DEFAULT NULL,
  `unique_id` int DEFAULT NULL,
  PRIMARY KEY (`character_lvl_id`),
  KEY `character_id_idx` (`unique_id`),
  CONSTRAINT `unique_id` FOREIGN KEY (`unique_id`) REFERENCES `characters_info` (`Characters_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table character_level
-- 

/*!40000 ALTER TABLE `character_level` DISABLE KEYS */;
INSERT INTO `character_level`(`character_lvl_id`,`character_lvl`,`unique_id`) VALUES
(1,90,1),
(2,90,2),
(3,90,3),
(4,1,4),
(5,70,5),
(6,90,6),
(7,70,7),
(8,90,8),
(9,90,9),
(10,1,10),
(16,90,1),
(47,90,47);
/*!40000 ALTER TABLE `character_level` ENABLE KEYS */;

-- 
-- Definition of characters_archon
-- 

DROP TABLE IF EXISTS `characters_archon`;
CREATE TABLE IF NOT EXISTS `characters_archon` (
  `Arch_ID` int NOT NULL AUTO_INCREMENT,
  `Archon_Name` varchar(255) DEFAULT NULL,
  `Sex` char(1) DEFAULT NULL,
  `Characters_ID` int DEFAULT NULL,
  `character_name` varchar(255) DEFAULT NULL,
  `Archon_id` int DEFAULT NULL,
  PRIMARY KEY (`Arch_ID`),
  KEY `Characters_ID_idx` (`Characters_ID`),
  KEY `Name_idx` (`Archon_Name`),
  KEY `Archon_ID_idx` (`Archon_id`),
  CONSTRAINT `Characters_ID` FOREIGN KEY (`Characters_ID`) REFERENCES `characters_info` (`Characters_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table characters_archon
-- 

/*!40000 ALTER TABLE `characters_archon` DISABLE KEYS */;
INSERT INTO `characters_archon`(`Arch_ID`,`Archon_Name`,`Sex`,`Characters_ID`,`character_name`,`Archon_id`) VALUES
(1,'Ei','F',1,'Kamisato Ayaka',3),
(2,'Ei','F',2,'Raiden Shogun',3),
(3,'Venti','M',3,'Mona Megistus',1),
(4,'Nahida','F',4,'Alhaitham',4),
(5,'Unknown God','F',5,'Lumine',5),
(6,'Zhongli','M',6,'Yelan',2),
(7,'Zhongli','M',7,'Ningguang',2),
(8,'Venti','M',8,'Eula Lawrence',1),
(9,'Ei','F',9,'Yae Miko',3),
(10,'Ei','M',10,'Sangonomiya Kokomi',3);
/*!40000 ALTER TABLE `characters_archon` ENABLE KEYS */;

-- 
-- Definition of characters_info
-- 

DROP TABLE IF EXISTS `characters_info`;
CREATE TABLE IF NOT EXISTS `characters_info` (
  `Characters_ID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Sex` char(1) DEFAULT NULL,
  `Region` varchar(45) DEFAULT NULL,
  `Id_of_Archon` int DEFAULT NULL,
  PRIMARY KEY (`Characters_ID`),
  KEY `Archon_ID_idx` (`Id_of_Archon`),
  CONSTRAINT `Id_of_Archon` FOREIGN KEY (`Id_of_Archon`) REFERENCES `characters_archon` (`Archon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=71 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table characters_info
-- 

/*!40000 ALTER TABLE `characters_info` DISABLE KEYS */;
INSERT INTO `characters_info`(`Characters_ID`,`Name`,`Sex`,`Region`,`Id_of_Archon`) VALUES
(1,'Kamisato Ayato','M','Inazuma',3),
(2,'Raiden Shogun','F','Inazuma',3),
(3,'Mona Megistus','F','Mondstadt',1),
(4,'Alhaitham','M','Sumeru',4),
(5,'Lumine','F','Celestia',5),
(6,'Yelan','F','Liyue',2),
(7,'Ningguang','F','Liyue',2),
(8,'Eula Lawrence','F','Mondstadt',1),
(9,'Yae Miko','F','Inazuma',3),
(10,'Sangonomiya Kokomi','F','Inazuma',3),
(11,'ian','M','Albay',3),
(13,'Yoimiya','F','Inazuma',3),
(15,'Dehya','F','Sumeru',4),
(17,'YaoYao','F','Liyue',2),
(20,'Childe','M','Sneznaya',2),
(47,'Mirko','M','Liyue',2);
/*!40000 ALTER TABLE `characters_info` ENABLE KEYS */;

-- 
-- Definition of characters_vision
-- 

DROP TABLE IF EXISTS `characters_vision`;
CREATE TABLE IF NOT EXISTS `characters_vision` (
  `vision_id` int NOT NULL AUTO_INCREMENT,
  `vision_name` varchar(255) DEFAULT NULL,
  `Characters_ID` int DEFAULT NULL,
  PRIMARY KEY (`vision_id`),
  KEY `character_id_idx` (`Characters_ID`),
  CONSTRAINT `character_id` FOREIGN KEY (`Characters_ID`) REFERENCES `characters_info` (`Characters_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table characters_vision
-- 

/*!40000 ALTER TABLE `characters_vision` DISABLE KEYS */;
INSERT INTO `characters_vision`(`vision_id`,`vision_name`,`Characters_ID`) VALUES
(1,'Anemo',1),
(2,'Electro',2),
(3,'Hydro',3),
(4,'Dendro',4),
(5,'No vision',5),
(6,'Hydro',6),
(7,'Geo',7),
(8,'Cryo',8),
(9,'Electro',9),
(10,'Hydro',10);
/*!40000 ALTER TABLE `characters_vision` ENABLE KEYS */;

-- 
-- Definition of price_weapon
-- 

DROP TABLE IF EXISTS `price_weapon`;
CREATE TABLE IF NOT EXISTS `price_weapon` (
  `characters_ID` int NOT NULL DEFAULT '0',
  `TotalPrice` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table price_weapon
-- 

/*!40000 ALTER TABLE `price_weapon` DISABLE KEYS */;
INSERT INTO `price_weapon`(`characters_ID`,`TotalPrice`) VALUES
(3,4000),
(8,8000),
(6,6000),
(7,5000),
(1,10000),
(2,6000),
(9,4000),
(4,7000),
(5,1000);
/*!40000 ALTER TABLE `price_weapon` ENABLE KEYS */;

-- 
-- Definition of signature_weapons
-- 

DROP TABLE IF EXISTS `signature_weapons`;
CREATE TABLE IF NOT EXISTS `signature_weapons` (
  `weapon_id` int NOT NULL AUTO_INCREMENT,
  `weapon_name` varchar(255) DEFAULT NULL,
  `Characters_ID` int DEFAULT NULL,
  `type_of_weapon` varchar(255) DEFAULT NULL,
  `weapon_price` double DEFAULT NULL,
  PRIMARY KEY (`weapon_id`),
  KEY `unique_id_idx` (`Characters_ID`),
  CONSTRAINT `chara_weap_id` FOREIGN KEY (`Characters_ID`) REFERENCES `characters_info` (`Characters_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table signature_weapons
-- 

/*!40000 ALTER TABLE `signature_weapons` DISABLE KEYS */;
INSERT INTO `signature_weapons`(`weapon_id`,`weapon_name`,`Characters_ID`,`type_of_weapon`,`weapon_price`) VALUES
(1,'The Mistsplitter Reforged',1,'sword',5000),
(2,'Engulfing Lightning',2,'polearm',6000),
(3,'Favonious Codex',3,'catalyst',4000),
(4,'Light of Foliar Incision',4,'sword',7000),
(5,'Dull Blade',5,'sword',1000),
(6,'Aqua Simulacra',6,'bow',6000),
(7,'Memory of Dust',7,'catalyst',5000),
(8,'Song of Broken Pines',8,'claymore',8000),
(9,'Kagura''s Verity',9,'catalyst',4000),
(10,'Everlasting Moonglow',10,'catalyst',67800),
(11,'Blackcliff Sword',1,'sword',5000),
(12,'Everlasting Moonglow',10,'sword',10000);
/*!40000 ALTER TABLE `signature_weapons` ENABLE KEYS */;

-- 
-- Definition of users
-- 

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table users
-- 

/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users`(`user_id`,`username`,`password`) VALUES
(1,'ian','1234'),
(2,'ayaka','ayaka'),
(3,'Umi Sonoda','1234'),
(4,'Mona','mona');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- 
-- Dumping functions
-- 

DROP FUNCTION IF EXISTS `weaponprices`;
DELIMITER |
CREATE FUNCTION `weaponprices`(oldval double, amount double) RETURNS double
    DETERMINISTIC
BEGIN
	declare newval double;
    set newval = oldval * ( 1 + amount);
RETURN newval;
END |
DELIMITER ;

-- 
-- Dumping procedures
-- 

DROP PROCEDURE IF EXISTS `updateWeaponPrices`;
DELIMITER |
CREATE PROCEDURE `updateWeaponPrices`(IN param1 int)
begin
update price_weapon
set TotalPrice = (select sum(weapon_price) from signature_weapons where Characters_ID = param1)
where characters_ID = param1; 
end |
DELIMITER ;

-- 
-- Dumping views
-- 

DROP TABLE IF EXISTS `characters_and_archons`;
DROP VIEW IF EXISTS `characters_and_archons`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `characters_and_archons` AS select 1 AS `ID`,1 AS `Name`,1 AS `Region`,1 AS `Archon_Name`;

DROP TABLE IF EXISTS `characters_and_their_visions`;
DROP VIEW IF EXISTS `characters_and_their_visions`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `characters_and_their_visions` AS select 1 AS `characters_info`,1 AS `Name`,1 AS `Region`,1 AS `vision_name`;

DROP TABLE IF EXISTS `characters_and_weapons`;
DROP VIEW IF EXISTS `characters_and_weapons`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `characters_and_weapons` AS select 1 AS `Characters_ID`,1 AS `Name`,1 AS `Region`,1 AS `weapon_name`;


-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `signature_weapons_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `signature_weapons_AFTER_INSERT` AFTER INSERT ON `signature_weapons` FOR EACH ROW BEGIN
	if new.weapon_id is not null then
    update price_weapon
    set TotalPrice = TotalPrice + new.weapon_price
    where characters_ID = new.weapon_id;
    end if;
END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2023-04-17 15:49:13
-- Total time: 0:0:0:0:199 (d:h:m:s:ms)
