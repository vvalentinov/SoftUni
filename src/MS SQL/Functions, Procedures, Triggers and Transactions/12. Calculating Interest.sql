CREATE PROC usp_CalculateFutureValueForAccount (@accountID INT, @interestRate FLOAT)
AS
SELECT 
	a.Id,
	ah.FirstName,
	ah.LastName,
	a.Balance,
	dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5)
FROM AccountHolders ah
JOIN Accounts a ON a.AccountHolderId = ah.Id
WHERE a.Id = @accountID