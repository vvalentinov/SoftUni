CREATE TABLE Monasteries
(
	Id INT PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(50) NOT NULL, 
	CountryCode CHAR(2) REFERENCES Countries(CountryCode) NOT NULL
)

INSERT INTO Monasteries(Name, CountryCode) VALUES
('Rila Monastery “St. Ivan of Rila”', 'BG'), 
('Bachkovo Monastery “Virgin Mary”', 'BG'),
('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
('Kopan Monastery', 'NP'),
('Thrangu Tashi Yangtse Monastery', 'NP'),
('Shechen Tennyi Dargyeling Monastery', 'NP'),
('Benchen Monastery', 'NP'),
('Southern Shaolin Monastery', 'CN'),
('Dabei Monastery', 'CN'),
('Wa Sau Toi', 'CN'),
('Lhunshigyia Monastery', 'CN'),
('Rakya Monastery', 'CN'),
('Monasteries of Meteora', 'GR'),
('The Holy Monastery of Stavronikita', 'GR'),
('Taung Kalat Monastery', 'MM'),
('Pa-Auk Forest Monastery', 'MM'),
('Taktsang Palphug Monastery', 'BT'),
('Sümela Monastery', 'TR')

--ALTER TABLE Countries
--ADD IsDeleted BIT
--CONSTRAINT D_Countries_IsDeleted DEFAULT(0) WITH VALUES


UPDATE Countries
SET IsDeleted = 1
WHERE CountryName IN (SELECT c.CountryName
FROM Countries c
LEFT JOIN CountriesRivers cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers r ON cr.RiverId = r.Id
GROUP BY c.CountryName,c.CountryCode
HAVING COUNT(r.Id) > 3)

SELECT [Name] AS [Monastery],
	   c.CountryName
FROM Monasteries m
LEFT JOIN Countries c ON m.CountryCode = c.CountryCode
WHERE c.IsDeleted = 0
ORDER BY m.[Name]