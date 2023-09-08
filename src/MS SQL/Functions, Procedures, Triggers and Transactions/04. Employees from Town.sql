CREATE PROC usp_GetEmployeesFromTown (@TownName NVARCHAR(50))
AS
	SELECT FirstName, LastName FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
	WHERE t.[Name] = @TownName


--EXEC usp_GetEmployeesFromTown @TownName = 'Sofia'