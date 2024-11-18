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
-- Table structure for table `borrow_info`
--

DROP TABLE IF EXISTS `borrow_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `borrow_info` (
  `BorID` int NOT NULL AUTO_INCREMENT,
  `RID` int DEFAULT NULL,
  `MID` int DEFAULT NULL,
  `LID` int DEFAULT NULL,
  `BorTime` datetime DEFAULT NULL,
  `BorLen` int DEFAULT NULL,
  `BorCount` int DEFAULT NULL,
  PRIMARY KEY (`BorID`),
  KEY `FK_Reference_8` (`MID`),
  KEY `FK_Reference_9_idx` (`LID`),
  KEY `RID` (`RID`),
  CONSTRAINT `borrow_info_ibfk_1` FOREIGN KEY (`RID`) REFERENCES `reader_info` (`RID`),
  CONSTRAINT `FK_Reference_8` FOREIGN KEY (`MID`) REFERENCES `manager_info` (`MID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_9` FOREIGN KEY (`LID`) REFERENCES `inlib_book_info` (`LID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `borrow_info`
--

LOCK TABLES `borrow_info` WRITE;
/*!40000 ALTER TABLE `borrow_info` DISABLE KEYS */;
INSERT INTO `borrow_info` VALUES (1,1,1,1,'2023-12-21 00:00:00',3,NULL),(2,1,1,1,'2023-12-22 00:00:00',20,0),(4,1,1,2,'2023-12-22 00:00:00',3,0),(5,1,1,3,'2023-12-29 00:00:00',5,0),(6,1,1,1,'2023-12-29 00:00:00',1,0),(7,1,1,6,'2023-12-29 00:00:00',4,0);
/*!40000 ALTER TABLE `borrow_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-15 21:18:06
