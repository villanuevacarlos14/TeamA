ALTER TABLE `appkeep`.`appkeepuser` 
ADD COLUMN `UserType` tinyint(6) UNSIGNED NOT NULL DEFAULT 1 AFTER `Phone`,
ADD COLUMN `UserMachineCategories` varchar(255) NULL AFTER `UserType`;

ALTER TABLE `appkeep`.`upkeeptemplatedetail` 
ADD COLUMN `Status` tinyint(6) NOT NULL DEFAULT 1 AFTER `StartDate`;

ALTER TABLE `appkeep`.`upkeepprofile` 
ADD COLUMN `Likes` int(6) UNSIGNED NULL AFTER `ProfileJSON`;

ALTER TABLE `appkeep`.`appkeepusermachine` 
ADD COLUMN `ImgFile` varchar(255) NULL AFTER `Like`;

ALTER TABLE `appkeep`.`machine` 
ADD COLUMN `ImgFile` varchar(255) NULL AFTER `Description`;

INSERT INTO `appkeep`.`appkeepuser`(`UserId`, `FirstName`, `LastName`, `Email`, `Phone`, `UserType`, `UserMachineCategories`) VALUES (1, 'Admin', 'System', '', '', 1, '1');


ALTER TABLE `appkeep`.`appkeepusermachine` 
MODIFY COLUMN `OnWarranty` tinyint(1) NOT NULL DEFAULT b'0' AFTER `MachineId`,
MODIFY COLUMN `WarrantyInfo` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL AFTER `OnWarranty`,
MODIFY COLUMN `ManufacturingDate` date NULL AFTER `WarrantyInfo`,
MODIFY COLUMN `PurchaseDate` date NULL AFTER `ManufacturingDate`,
MODIFY COLUMN `Like` smallint(6) UNSIGNED NULL AFTER `PurchaseDate`;



INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (3, 'Vehicles', '1971 Beetle Type 1', 'Volkswagen', 'Test', 'vw.jpg');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (4, 'Appliances', 'Airconditioner', 'Samsung', 'Test', 'aircon.jpg');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (5, 'Vehicles', '27.5 Mountain Bike', 'Agogo', 'Test', 'mtb.png');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (6, 'Appliances', 'Coffee Maker', 'LG', 'Test', 'coffee.jpeg');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (7, 'Home', 'French Windows', '', 'Test', 'windows.jpg');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (8, 'Home', 'Bermuda Grass', '', 'Test', 'grass.png');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (9, 'Appliances', 'Fish Tank', 'Bentley', 'Test', 'aquarium.jpg');
INSERT INTO `appkeep`.`machine`(`MachineId`, `Category`, `Name`, `Make`, `Description`, `ImgFile`) VALUES (10, 'Appliances', 'Legion Y750', 'Lenovo', 'Test', 'laptop.jpg');


INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (1, 1, 1, 0, 'Test', '2020-12-08', '2020-12-31', 11, 'rav4.jpg');
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (2, 1, 2, 0, 'Test', '2020-12-21', '2020-12-24', 11, 'f150.jpg');
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (3, 1, 3, 0, 'Test', '2020-12-07', '2021-01-02', 11, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (4, 1, 4, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (5, 1, 5, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (6, 1, 6, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (7, 1, 7, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (8, 1, 8, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (9, 1, 9, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
INSERT INTO `appkeep`.`appkeepusermachine`(`UserMachineId`, `UserId`, `MachineId`, `OnWarranty`, `WarrantyInfo`, `ManufacturingDate`, `PurchaseDate`, `Like`, `ImgFile`) VALUES (10, 1, 10, 0, 'Test', '2020-12-29', '2020-12-30', 1, NULL);
