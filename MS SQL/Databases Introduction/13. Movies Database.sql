--CREATE DATABASE Movies

--USE Movies


CREATE TABLE Directors
(
  Id INT PRIMARY KEY,
  DirectorName VARCHAR(30) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO Directors (Id, DirectorName, Notes) VALUES
(1, 'Christopher Nolan', NULL),
(2, 'Steven Spielberg', NULL),
(3, 'Quentin Tarantino', NULL),
(4, 'Martin Scorsese', NULL),
(5, 'Ridley Scott', NULL)

CREATE TABLE Genres
(
  Id INT PRIMARY KEY,
  GenreName VARCHAR(30) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO Genres (Id, GenreName, Notes) VALUES
(1, 'Action', NULL),
(2, 'Comedy', NULL),
(3, 'Drama', NULL),
(4, 'Horror', NULL),
(5, 'Romance', NULL)


CREATE TABLE Categories
(
  Id INT PRIMARY KEY,
  CategoryName VARCHAR(30) NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO Categories (Id, CategoryName, Notes) VALUES
(1, 'PG-13', NULL),
(2, 'G', NULL),
(3, 'PG', NULL),
(4, 'R', NULL),
(5, 'NC-17', NULL)

CREATE TABLE Movies
(
  Id INT PRIMARY KEY,
  Title VARCHAR(30) NOT NULL,
  DirectorId INT FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
  CopyrightYear INT,
  [Length] TIME  NOT NULL,
  GenreId INT FOREIGN KEY REFERENCES Genres(Id) NOT NULL,
  CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
  Rating INT NOT NULL,
  Notes VARCHAR(MAX)
)

INSERT INTO Movies (Id, Title, DirectorId, CopyrightYear, Length, GenreId, CategoryId, Rating, Notes) VALUES
(1, 'Avatar', 2,NULL,'02:42:33', 1, 1, 9,NULL),
(2 , 'Taxi Driver', 4, NULL, '01:45:21', 1, 4, 8, NULL),
(3, 'Batman Begins', 1, NULL, '02:20:43', 1, 1, 9, NULL),
(4, 'Kill Bill', 3, NULL, '01:51:44', 1, 4, 8, NULL),
(5, 'Gladiator', 5, NULL, '02:35:40', 1, 4, 9, NULL)