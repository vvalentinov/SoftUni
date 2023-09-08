SELECT TOP(50)
	  e.EmployeeID,
	  e.FirstName + ' ' + e.LastName AS EmployeeName,
	  mng.FirstName + ' ' + mng.LastName AS ManagerName,
	  d.Name AS DepartmentName
FROM Employees e
JOIN Employees mng ON mng.EmployeeID = e.ManagerID
JOIN Departments d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID