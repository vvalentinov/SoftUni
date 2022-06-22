SELECT DISTINCT r.DepartmentID, r.Salary FROM(
SELECT
DepartmentID,
Salary,
DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS [Ranked]
FROM Employees) AS r
WHERE r.Ranked = 3