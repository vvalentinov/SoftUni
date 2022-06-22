SELECT DepartmentID, SUM(Salary) AS Salary 
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID