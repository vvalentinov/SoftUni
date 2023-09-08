SELECT i.[Name],
	   Price,
	   MinLevel,
	   gt.Name
FROM Items i 
LEFT JOIN GameTypeForbiddenItems gtfi ON i.Id = gtfi.ItemId
LEFT JOIN GameTypes gt ON gtfi.GameTypeId = gt.Id
ORDER BY gt.Name DESC, i.Name