SELECT TOP(5)
	  k.CountryName,
	  k.PeakName,
	  k.HighestPeak,
	  k.MountainRange
FROM(SELECT CountryName,
ISNULL(p.PeakName, '(no highest peak)') AS PeakName,
ISNULL(m.MountainRange, '(no mountain)') AS MountainRange,
ISNULL(MAX(p.Elevation),0) AS HighestPeak,
DENSE_RANK() OVER(PARTITION BY CountryName ORDER BY MAX(p.Elevation)DESC) AS Ranked
FROM Countries c
LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains m ON mc.MountainId = m.Id
LEFT JOIN Peaks p ON m.Id = p.MountainId
LEFT JOIN CountriesRivers cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers r ON cr.RiverId = r.Id
GROUP BY CountryName, p.PeakName, m.MountainRange) As k
WHERE Ranked = 1
ORDER BY CountryName, PeakName