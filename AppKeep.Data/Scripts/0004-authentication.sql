ALTER TABLE `appkeepuser`
ADD COLUMN `Password` varchar(50) NOT NULL DEFAULT '' AFTER `Email`;