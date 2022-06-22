SELECT TOP(5)
     e.EmployeeID,
	 e.JobTitle,
	 e.AddressID,
	 a.AddressText
FROM Employees e
JOIN Addresses AS a ON e.AddressID = a.AddressID
ORDER BY AddressID