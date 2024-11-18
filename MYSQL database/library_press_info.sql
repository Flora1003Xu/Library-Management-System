-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: library
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `press_info`
--

DROP TABLE IF EXISTS `press_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `press_info` (
  `PID` int NOT NULL AUTO_INCREMENT,
  `PName` varchar(20) DEFAULT NULL,
  `PContact` varchar(40) DEFAULT NULL,
  `PPhone` char(11) DEFAULT NULL,
  `PCounRe` varchar(60) DEFAULT NULL,
  `PProvince` varchar(30) DEFAULT NULL,
  `PCity` varchar(30) DEFAULT NULL,
  `PDistinct` varchar(30) DEFAULT NULL,
  `PStreet` varchar(30) DEFAULT NULL,
  `PDNo` int DEFAULT NULL,
  PRIMARY KEY (`PID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `press_info`
--

LOCK TABLES `press_info` WRITE;
/*!40000 ALTER TABLE `press_info` DISABLE KEYS */;
INSERT INTO `press_info` VALUES (1,'蓝天出版社','bbbb','1234567','中国','','北京','海淀','复兴',14),(3,'人民文学出版社','臧永清','','中国','','北京','东城','朝阳门内大街',166),(4,'商务印书馆','陈小文','','中国','','上海','虹口','纪念路',300),(5,'三联出版社','','','中国','','北京','东城','美术馆东街',24),(6,'机械工业出版社','李奇','','中国','','北京','西城','百万庄大街',22);
/*!40000 ALTER TABLE `press_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-15 21:18:07
