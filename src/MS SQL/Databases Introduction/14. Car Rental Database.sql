--CREATE DATABASE CarRental

CREATE TABLE Categories
(
  Id INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(50) NOT NULL,
  DailyRate INT NOT NULL,
  WeeklyRate INT NOT NULL,
  MonthlyRate INT NOT NULL,
  WeekendRate INT NOT NULL
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('SEDAN', 3, 10, 20, 5),
('HATCHBACK', 2, 5, 15, 3 ),
('SPORTS CAR', 20, 40, 60, 30)

CREATE TABLE Cars
(
  Id INT PRIMARY KEY IDENTITY,
  PlateNumber INT NOT NULL,
  Manufacturer NVARCHAR(50) NOT NULL,
  Model NVARCHAR(50) NOT NULL,
  CarYear DATETIME NOT NULL,
  CategoryId INT NOT NULL,
  Doors INT,
  Picture VARBINARY,
  Condition NVARCHAR(50),
  Available BIT NOT NULL
)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Available) VALUES
(7569,'General Motors', 'Tata Tigor', 01-07-2019, 1, 1),
(5678,'TOYOTA', 'Toyota Prius', 16-17-2020, 2, 1),
(5678,'PORSCHE', 'Porsche 911', 06-12-2007, 3, 1)

CREATE TABLE Employees
(
  Id INT PRIMARY KEY IDENTITY,
  FirstName NVARCHAR(50) NOT NULL,
  LastName NVARCHAR(50) NOT NULL,
  Title NVARCHAR(50) NOT NULL,
  Notes NVARCHAR(MAX)
)

INSERT INTO Employees (FirstName, LastName, Title) VALUES
('Mike', 'Brown', 'Sales Manager'),
('John', 'Smith', 'Staff'),
('Neil', 'Harmor', 'Finance Director')


CREATE TABLE Customers
(
  Id INT PRIMARY KEY IDENTITY,
  DriverLicenceNumber INT NOT NULL,
  FullName NVARCHAR(50) NOT NULL,
  [Address] NVARCHAR(50) NOT NULL,
  City NVARCHAR(50) NOT NULL,
  ZIPCode NVARCHAR(50),
  Notes NVARCHAR(MAX)
)

INSERT INTO Customers (DriverLicenceNumber, FullName, [Address], City) VALUES
(3567, 'Peter White', '221 Cornelious Str.', 'New York'),
(5678, 'Angel Hill', '51 Adam Smith Str.', 'Washington'),
(1456, 'Sandra Foster', '22 Malcolm X Str.', 'LA')


CREATE TABLE RentalOrders
(
  Id INT PRIMARY KEY IDENTITY,
  EmployeeId INT NOT NULL,
  CustomerId INT NOT NULL,
  CarId INT NOT NULL,
  TankLevel NVARCHAR(50) NOT NULL,
  KilometrageStart INT NOT NULL,
  KilometrageEnd INT NOT NULL,
  TotalKilometrage INT NOT NULL,
  StartDate DATETIME NOT NULL,
  EndDate DATETIME NOT NULL,
  TotalDays INT,
  RateApplied INT,
  TaxRate INT,
  OrderStatus BIT NOT NULL,
  Notes NVARCHAR(MAX)
)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd,TotalKilometrage, StartDate,EndDate,OrderStatus) VALUES
(2, 1, 3, 'Full', 12000,12500,500,01-02-2005,01-13-2005,1),
(1, 2, 1, 'Low', 130000,130789,789,13-03-2009,13-10-2009,0),
(3, 3, 2, 'Medium', 150000,150976,976,01-02-2005,01-13-2005,1)