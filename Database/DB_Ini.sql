-- Table role
CREATE TABLE `Role` (
  `RoleId` INT NOT NULL,
  `RoleName` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`RoleId`));

-- Insert roles to table
INSERT INTO `Role` (`RoleId`, `RoleName`) VALUES ('1001', 'Admin');
INSERT INTO `Role` (`RoleId`, `RoleName`) VALUES ('1002', 'Manager');
INSERT INTO `Role` (`RoleId`, `RoleName`) VALUES ('1003', 'Attendee');

-- Table user
CREATE TABLE `User` (
  `UserName` VARCHAR(30) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `RoleId` INT NOT NULL,
  `DateOfBirth` DATE NULL,
  `Email` VARCHAR(45) NULL,
  `Phone` VARCHAR(12) NULL,
  `Valid` CHAR(1) NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`UserName`),
  INDEX `FK_USER_ROLE_ROLEID_idx` (`RoleId` ASC) VISIBLE,
  CONSTRAINT `FK_USER_ROLE_ROLEID`
    FOREIGN KEY (`RoleId`)
    REFERENCES `Role` (`RoleId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- Insert admin account
INSERT INTO `User` VALUES ('admin', 'admin', 1001, '1900-01-01', NULL, NULL, 'Y');

-- Table events
CREATE TABLE `Events` (
  `EventId` INT NOT NULL,
  `EventName` VARCHAR(45) NOT NULL,
  `Date` DATE NOT NULL,
  `Capacity` INT NOT NULL,
  `Location` VARCHAR(45) NOT NULL,
  `Organizer` VARCHAR(45) NOT NULL,
  `ManagerName` VARCHAR(30) NOT NULL,
  `Description` VARCHAR(200) NULL,
  `Valid` CHAR(1) NOT NULL DEFAULT 'Y',
  PRIMARY KEY (`EventId`),
  INDEX `FK_EVENT_USER_MANAGER_idx` (`ManagerName` ASC) VISIBLE,
  CONSTRAINT `FK_EVENT_USER_MANAGER`
    FOREIGN KEY (`ManagerName`)
    REFERENCES `User` (`UserName`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- Table register
CREATE TABLE `Register` (
  `UserName` VARCHAR(30) NOT NULL,
  `EventId` INT NOT NULL,
  PRIMARY KEY (`UserName`, `EventId`),
  INDEX `FK_REG_EVENT_ID_idx` (`EventId` ASC) VISIBLE,
  CONSTRAINT `FK_REG_USER_NAME`
    FOREIGN KEY (`UserName`)
    REFERENCES `User` (`UserName`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_REG_EVENT_ID`
    FOREIGN KEY (`EventId`)
    REFERENCES `Events` (`EventId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
