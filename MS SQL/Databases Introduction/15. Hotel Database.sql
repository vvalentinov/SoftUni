--CREATE DATABASE Hotel

--USE Hotel

CREATE TABLE Employees
(
  Id INT PRIMARY KEY,
  FirstName VARCHAR(90) NOT NULL,
  LastName VARCHAR(90) NOT NULL,
  Title VARCHAR(50) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO Employees (Id, FirstName, LastName, Title, Notes) VALUES
(1, 'Pesho','Peshov','CEO',NULL),
(2, 'Gosho','Petrov', 'CFO', 'best CFO'),
(3, 'Ivan','Ivanov','CTO',NULL)

CREATE TABLE Customers
(
  AccountNumber INT PRIMARY KEY,
  FirstName VARCHAR(90) NOT NULL,
  LastName VARCHAR(90) NOT NULL,
  PhoneNumber CHAR(10) NOT NULL,
  EmergencyName VARCHAR(90) NOT NULL,
  EmergencyNumber CHAR(10) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO CUSTOMERS (AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName,EmergencyNumber,Notes) VALUES
(10, 'G','T','1234567890','Y','1234567890','SOME NOTE'),
(11, 'M','X','1234567890','Y','1234567890','GREAT SUTOMER'),
(12, 'Z','Q','1234567890','Y','1234567890','SOME NOTE')

CREATE TABLE RoomStatus
(
  RoomStatus VARCHAR(20) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO RoomStatus VALUES
('CLEANING', NULL),
('FREE', NULL),
('NOT FREE', NULL)

CREATE TABLE RoomTypes
(
  RoomType VARCHAR(20) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO RoomTypes VALUES
('Apartment', NULL),
('One bedroom', NULL),
('Two bedroom', NULL)

CREATE TABLE BedTypes
(
  BedType VARCHAR(20) NOT NULL,
  Notes VARCHAR(MAX)
)
INSERT INTO BedTypes VALUES
('Single', NULL),
('Double', NULL),
('King Size', NULL)
-- FOREIGN KEY: HOW TO CREATE CONNECTION BETWEEN TABLES
CREATE TABLE Rooms
(
  RoomNumber INT PRIMARY KEY,
  RoomType VARCHAR(20) NOT NULL,
  BedType VARCHAR(20) NOT NULL,
  Rate INT,
  RoomStatus VARCHAR(20) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO Rooms VALUES
(120, 'Apartment', 'SINGLE',6,'FREE',NULL),
(121, 'ONE BEDROOM', 'KING',10,'CLEANING',NULL),
(122, 'TWO BEDROOM', 'DOUBLE',8,'NOT FREE',NULL)

CREATE TABLE Payments
(
  Id INT PRIMARY KEY,
  EmployeeId INT NOT NULL,
  PaymentDate DATETIME NOT NULL,
  AccountNumber INT NOT NULL,
  FirstDateOccupied DATETIME NOT NULL,
  LastDateOccupied DATETIME NOT NULL,
  TotalDays INT NOT NULL,
  AmountCharged DECIMAL(15, 2),
  TaxRate INT,
  TaxAmount INT,
  PaymentTotal DECIMAL(15, 2),
  Notes VARCHAR(MAX)
)

INSERT INTO Payments VALUES
(1, 1, GETDATE(), 120, '5/5/2012', '5/8/2012', 3, 450.23, NULL, NULL, 450.23, NULL),
(2, 1, GETDATE(), 120, '3/6/2012', '3/10/2012', 4, 500.23, NULL, NULL, 500.23, NULL),
(3, 1, GETDATE(), 120, '8/1/2012', '8/9/2012', 8, 778.30, NULL, NULL, 778.30, NULL)

CREATE TABLE Occupancies
(
  Id INT PRIMARY KEY,
  EmployeeId INT NOT NULL,
  DateOccupied DATETIME NOT NULL,
  AccountNumber INT NOT NULL,
  RoomNumber INT NOT NULL,
  RateApplied INT,
  PhoneCharged DECIMAL(15,2),
  Notes VARCHAR(MAX)
)

INSERT INTO Occupancies VALUES
(1, 120, GETDATE(), 120, 120, 0, 0, NULL),
(2, 120, GETDATE(), 121, 2, 0, 0, NULL),
(3, 120, GETDATE(), 122, 32, 0, 0, NULL)