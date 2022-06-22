SELECT p.PeakName,
	   m.MountainRange,
	   c.CountryName,
	   ct.ContinentName
FROM Peaks p
JOIN Mountains m ON p.MountainId = m.Id
JOIN MountainsCountries mc ON m.Id = mc.MountainId
JOIN Countries c ON mc.CountryCode = c.CountryCode
JOIN Continents ct ON c.ContinentCode = ct.ContinentCode
ORDER BY p.PeakName, c.CountryName