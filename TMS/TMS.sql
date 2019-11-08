--
-- Create schema tms
--

DROP DATABASE IF EXISTS tms;

CREATE DATABASE IF NOT EXISTS tms;

USE tms;

DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `AccountID` varchar(20) Not NULL,
  `AccountPW` varchar(20) Not NULL,
  `AccountLevel` int,
  `AccessDate` datetime,
  
  PRIMARY KEY (AccountID)
);

DROP TABLE IF EXISTS `datastorage`;
CREATE TABLE `datastorage` (
	`StorageID` int Not NULL auto_increment,
    `StorageName` varchar(20),
    
    PRIMARY KEY (StorageID)
);

DROP TABLE IF EXISTS `localdb`;
CREATE TABLE `localdb` (
	`DbID` int,
    `DbDirectory` varchar(100),
    
    FOREIGN KEY (DbID) REFERENCES datastorage(StorageID)
);

DROP TABLE IF EXISTS `remotedb`;
CREATE TABLE `remotedb` (
	`DbID` int,
    `IpAddress` varchar(20),
    `PortNumber` int,
    
    FOREIGN KEY (DbID) REFERENCES datastorage(StorageID)
);

DROP TABLE IF EXISTS `logdetail`;
CREATE TABLE `logdetail` (
  `LogID` int Not NULL auto_increment,
  `UserID` varchar(20) Not NULL,
  `ChangeDate` datetime,
  `Description` varchar(255),
  
  PRIMARY KEY (LogID),
  FOREIGN KEY (UserID) REFERENCES account(AccountID)
);