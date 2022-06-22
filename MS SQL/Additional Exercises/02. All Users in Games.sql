SELECT g.Name AS [Game],
	   gt.Name AS [Game Type],
	   u.Username AS [Username],
	   ug.Level AS [Level],
	   ug.Cash AS [Cash],
	   c.Name AS [Character]
FROM Games g
JOIN GameTypes gt ON g.GameTypeId = gt.Id
JOIN UsersGames ug ON g.Id = ug.GameId
JOIN Users u ON ug.UserId = u.Id
JOIN Characters c ON ug.CharacterId = c.Id
ORDER BY [Level] DESC, [Username], [Game]