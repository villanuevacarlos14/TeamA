/*
 Navicat MySQL Data Transfer

 Source Server         : MySQL80
 Source Server Type    : MySQL
 Source Server Version : 80018
 Source Host           : localhost:3306
 Source Schema         : appkeep

 Target Server Type    : MySQL
 Target Server Version : 80018
 File Encoding         : 65001

 Date: 05/01/2021 21:23:14
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for workplan
-- ----------------------------
DROP TABLE IF EXISTS `workplan`;
CREATE TABLE `workplan`  (
  `WorkPlanItemId` int(6) UNSIGNED NOT NULL AUTO_INCREMENT,
  `ScheduleDate` datetime(0) NOT NULL,
  `StartWorkDateTime` datetime(0) NULL DEFAULT NULL,
  `CompleteWorkDateTime` datetime(0) NULL DEFAULT NULL,
  `NeedActionDateTime` datetime(0) NULL DEFAULT NULL,
  `WorkedByUserId` int(10) UNSIGNED NULL DEFAULT NULL,
  `Status` int(6) NULL DEFAULT NULL,
  PRIMARY KEY (`WorkPlanItemId`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
