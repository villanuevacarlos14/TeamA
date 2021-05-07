ALTER TABLE `appkeep`.`upkeepprofiletemplate` 
ADD COLUMN `UserMachineId` int(10) UNSIGNED NOT NULL AFTER `UpkeepProfileTemplateId`,
MODIFY COLUMN `Description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL AFTER `CreatedDate`,
MODIFY COLUMN `Lifespan` tinyint(2) UNSIGNED NULL AFTER `Description`,
ADD COLUMN `SourceProfileTemplateId` int(10) UNSIGNED NULL AFTER `Lifespan`;

ALTER TABLE `appkeep`.`upkeeptemplatedetail` 
MODIFY COLUMN `PartId` int(10) UNSIGNED NULL AFTER `UpkeepProfileTemplateId`;

ALTER TABLE `appkeep`.`upkeeptemplatedetail` 
ADD COLUMN `Part` varchar(255) NULL AFTER `Status`;