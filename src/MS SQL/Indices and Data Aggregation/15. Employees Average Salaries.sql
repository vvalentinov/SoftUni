SELECT * INTO Result FROM Employees
WHERE Salary > 30000

DELETE FROM Result WHERE ManagerID = 42

UPDATE Result
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) AS AverageSalary
FROM Result
GROUP BY DepartmentID