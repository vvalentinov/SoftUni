SELECT u.Username AS [Username],
       g.Name AS [Game],
	   COUNT(i.Name) AS [Items Count],
	   SUM(i.Price) AS [Items Price]
FROM Users u
JOIN UsersGames ug ON ug.UserId = u.Id
JOIN Games g ON ug.GameId = g.Id
JOIN UserGameItems ugi ON ug.Id = ugi.UserGameId
JOIN Items i ON ugi.ItemId = i.Id
GROUP BY u.Username, g.Name
HAVING COUNT(i.Name) >= 10
ORDER BY [Items Count] DESC, [Items Price] DESC, [Username]