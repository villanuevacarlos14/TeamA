ALTER TABLE `appkeep`.`upkeeptemplatedetail` 
ADD COLUMN `WorkedByUserId` int(10) NULL AFTER `Part`,
ADD COLUMN `StartWorkDateTime` datetime(0) NULL AFTER `WorkedByUserId`,
ADD COLUMN `CompleteWorkDateTime` datetime(0) NULL AFTER `StartWorkDateTime`,
ADD COLUMN `NeedActionDateTime` datetime(0) NULL AFTER `CompleteWorkDateTime`;