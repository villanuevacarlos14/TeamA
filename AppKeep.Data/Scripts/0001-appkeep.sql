/*
 Navicat MySQL Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80016
 Source Host           : localhost:3306
 Source Schema         : appkeep

 Target Server Type    : MySQL
 Target Server Version : 80016
 File Encoding         : 65001

 Date: 28/12/2020 23:19:44
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for appkeepuser
-- ----------------------------
DROP TABLE IF EXISTS `appkeepuser`;
CREATE TABLE `appkeepuser`  (
  `UserId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `LastName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `Email` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `Phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  PRIMARY KEY (`UserId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for appkeepusermachine
-- ----------------------------
DROP TABLE IF EXISTS `appkeepusermachine`;
CREATE TABLE `appkeepusermachine`  (
  `UserMachineId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `UserId` int(10) UNSIGNED NOT NULL,
  `MachineId` int(10) UNSIGNED NOT NULL,
  `OnWarranty` bit(1) NOT NULL DEFAULT b'0',
  `WarrantyInfo` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `ManufacturingDate` date NOT NULL,
  `PurchaseDate` date NOT NULL,
  `Like` smallint(6) UNSIGNED NOT NULL,
  PRIMARY KEY (`UserMachineId`) USING BTREE,
  INDEX `UserId`(`UserId`) USING BTREE,
  INDEX `MachineId`(`MachineId`) USING BTREE,
  CONSTRAINT `appkeepusermachine_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `appkeepuser` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `appkeepusermachine_ibfk_2` FOREIGN KEY (`MachineId`) REFERENCES `machine` (`MachineId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for machine
-- ----------------------------
DROP TABLE IF EXISTS `machine`;
CREATE TABLE `machine`  (
  `MachineId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `Category` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `Make` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL,
  PRIMARY KEY (`MachineId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of machine
-- ----------------------------
INSERT INTO `machine` VALUES (1, 'Vehicles', 'RAV-4', 'Toyota', 'Test Test Test');
INSERT INTO `machine` VALUES (2, 'Vehicles', 'F150', 'Ford', 'Test');

-- ----------------------------
-- Table structure for part
-- ----------------------------
DROP TABLE IF EXISTS `part`;
CREATE TABLE `part`  (
  `PartId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `MachineId` int(10) UNSIGNED NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL,
  PRIMARY KEY (`PartId`) USING BTREE,
  INDEX `MachineId`(`MachineId`) USING BTREE,
  CONSTRAINT `part_ibfk_1` FOREIGN KEY (`MachineId`) REFERENCES `machine` (`MachineId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for updateprofiletemplate
-- ----------------------------
DROP TABLE IF EXISTS `upkeepprofiletemplate`;
CREATE TABLE `upkeepprofiletemplate`  (
  `UpkeepProfileTemplateId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `MachineId` int(10) UNSIGNED NOT NULL,
  `AuthorId` int(10) NOT NULL,
  `ProfileName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `CreatedDate` datetime(0) NOT NULL,
  `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `Lifespan` tinyint(2) UNSIGNED NOT NULL,
  PRIMARY KEY (`UpkeepProfileTemplateId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for upkeepprofile
-- ----------------------------
DROP TABLE IF EXISTS `upkeepprofile`;
CREATE TABLE `upkeepprofile`  (
  `UpkeepProfileId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `UpkeepProfileTemplateId` int(10) UNSIGNED NOT NULL,
  `UserMachineId` int(10) UNSIGNED NOT NULL,
  `UserId` int(10) UNSIGNED NOT NULL,
  `ProfileJSON` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`UpkeepProfileId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for upkeeptemplatedetail
-- ----------------------------
DROP TABLE IF EXISTS `upkeeptemplatedetail`;
CREATE TABLE `upkeeptemplatedetail`  (
  `UpkeepTemplateDetailId` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `UpkeepProfileTemplateId` int(10) UNSIGNED NOT NULL,
  `PartId` int(10) UNSIGNED NOT NULL,
  `IsRecurring` bit(1) NOT NULL DEFAULT b'0',
  `Description` text CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Interval` smallint(6) UNSIGNED NOT NULL,
  `Period` tinyint(2) NOT NULL DEFAULT 0,
  `StartDate` datetime(0) NOT NULL,
  PRIMARY KEY (`UpkeepTemplateDetailId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
