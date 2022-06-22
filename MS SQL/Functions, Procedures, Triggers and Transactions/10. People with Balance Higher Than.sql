CREATE PROC usp_GetHoldersWithBalanceHigherThan(@money DECIMAL(15,2))
AS
	SELECT FirstName, LastName 
	FROM AccountHolders ah
	JOIN Accounts a ON a.AccountHolderId = ah.Id
  GROUP BY FirstName, LastName
	HAVING SUM(Balance) > @money
  ORDER BY FirstName, LastName