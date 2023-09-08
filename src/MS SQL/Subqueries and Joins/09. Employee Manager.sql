SELECT
	  e.EmployeeID,
	  e.FirstName,
	  e.ManagerID,
	  mng.FirstName AS ManagerName
FROM Employees e
JOIN Employees mng ON mng.EmployeeID = e.ManagerID
WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID