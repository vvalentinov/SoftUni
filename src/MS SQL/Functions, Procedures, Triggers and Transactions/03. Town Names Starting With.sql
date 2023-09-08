CREATE PROC usp_GetTownsStartingWith @TownFirstLetters NVARCHAR(50)
AS
	SELECT [Name] FROM Towns
	WHERE [Name] LIKE @TownFirstLetters + '%'

--EXEC usp_GetTownsStartingWith @TownFirstLetters = 'b'