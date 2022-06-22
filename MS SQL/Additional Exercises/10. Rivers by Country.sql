SELECT c.CountryName,
	   ct.ContinentName,
	   CASE
			WHEN COUNT(r.Id) = 0 THEN 0
			ELSE COUNT(r.Id)
	   END AS [RiversCount],
	   CASE
			WHEN COUNT(r.Id) = 0 THEN 0
			ELSE SUM(r.Length)
	   END AS [TotalLength]
FROM Countries c
LEFT JOIN CountriesRivers cr ON c.CountryCode = cr.CountryCode
LEFT JOIN Rivers r ON cr.RiverId = r.Id
JOIN Continents ct ON c.ContinentCode = ct.ContinentCode
GROUP BY c.CountryName, ct.ContinentName
ORDER BY [RiversCount] DESC, [TotalLength] DESC, c.CountryName 