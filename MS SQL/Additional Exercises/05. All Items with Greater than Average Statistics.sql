SELECT i.Name AS [Name],
	   i.Price AS [Price],
	   i.MinLevel AS [MinLevel],
	   s.Strength AS [Strength],
	   s.Defence AS [Defence],
	   s.Speed AS [Speed],
	   s.Luck AS [Luck],
	   s.Mind AS [Mind]
FROM Items i
JOIN [Statistics] s ON i.StatisticId = s.Id
WHERE [Luck] > (SELECT AVG(Luck) FROM [Statistics]) AND
	  [Mind] > (SELECT AVG(Mind) FROM [Statistics]) AND
	  [Speed] > (SELECT AVG(Speed) FROM [Statistics])
ORDER BY [Name]