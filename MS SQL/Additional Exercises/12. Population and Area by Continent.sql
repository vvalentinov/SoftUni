SELECT ContinentName,
	   SUM(c.AreaInSqKm) AS [CountriesArea],
	   SUM(CAST(c.[Population] AS decimal)) AS [CountriesPopulation]
FROM Continents ct
LEFT JOIN Countries c ON ct.ContinentCode = c.ContinentCode
GROUP BY ContinentName
ORDER BY SUM(CAST(c.[Population] AS decimal)) DESC