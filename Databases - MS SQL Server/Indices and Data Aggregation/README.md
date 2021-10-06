--- 1. Records’ Count

SELECT COUNT ([Id]) FROM [WizzardDeposits]

---2. Longest Magic Wand

SELECT MAX ([MagicWandSize]) AS [LongestMagicWand]
FROM [WizzardDeposits]

---3. Longest Magic Wand Per Deposit Groups

SELECT [DepositGroup], MAX([MagicWandSize]) AS [LongestMagicWand]
FROM [WizzardDeposits]
GROUP BY [DepositGroup]

---4. * Smallest Deposit Group Per Magic Wand Size

SELECT TOP (2) [DepositGroup]
FROM [WizzardDeposits]
GROUP BY [DepositGroup]
ORDER BY AVG([MagicWandSize])

---5. Deposits Sum

  SELECT [DepositGroup], SUM([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits]
GROUP BY [DepositGroup]

---6. Deposits Sum for Ollivander Family

  SELECT [DepositGroup],
    SUM ([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits]
   WHERE [MagicWandCreator] = 'Ollivander Family'
GROUP BY [DepositGroup]

---7. Deposits Filter

 SELECT [DepositGroup],
    SUM ([DepositAmount]) AS [TotalSum]
    FROM [WizzardDeposits]
   WHERE [MagicWandCreator] = 'Ollivander Family'
GROUP BY [DepositGroup]
HAVING SUM([DepositAmount]) < 150000
ORDER BY [TotalSum] DESC

---8. Deposit Charge

  SELECT [DepositGroup],
	     [MagicWandCreator] AS [MagicWandCreator],
    MIN ([DepositCharge]) AS [MinDepositCharge]
    FROM [WizzardDeposits]
GROUP BY [DepositGroup], [MagicWandCreator]
ORDER BY [MagicWandCreator], [DepositGroup]

---9. Age Groups

SELECT [AgeGroup],
 COUNT([Id]) AS [WizartCount]
 FROM (
SELECT *,
	CASE
		WHEN [Age] BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN [Age] BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN [Age] BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN [Age] BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN [Age] BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN [Age] BETWEEN 51 AND 60 THEN '[51-60]'
		ELSE '[61+]'
		END AS [AgeGroup]
FROM [WizzardDeposits]
) AS [AgeGroupingQuery]
GROUP BY [AgeGroup]

---10. First Letter

SELECT  SUBSTRING ([FirstName], 1, 1) AS [FisrtLetter]
 FROM [WizzardDeposits]
WHERE [DepositGroup] = 'Troll Chest'
GROUP BY LEFT ([FirstName], 1) 

---11. Average Interest

SELECT [DepositGroup], [IsDepositExpired], AVG ([DepositInterest]) AS [AverageInterest]
FROM [WizzardDeposits]
WHERE [DepositStartDate] > '1985-01-01'
GROUP BY [DepositGroup], [IsDepositExpired]
ORDER BY [DepositGroup] DESC, [IsDepositExpired]

---12. * Rich Wizard, Poor Wizard

SELECT SUM([Differance]) 
FROM (
SELECT [FirstName] AS [Host Wizard],
       [DepositAmount] AS [Host Wizard Deposit],
LEAD ([FirstName]) OVER(ORDER BY [Id]) AS [Guest Wizard],
LEAD ([DepositAmount]) OVER(ORDER BY [Id]) AS [Guest Wizard Deposit],
[DepositAmount] - LEAD ([DepositAmount]) OVER(ORDER BY [Id]) AS [Differance]
FROM [WizzardDeposits]
) AS [SumDifference]

---13. Departments Total Salaries

USE [SoftUni]

  SELECT [DepartmentID],
    SUM ([Salary]) AS [TotalSalary]
    FROM [Employees]
GROUP BY [DepartmentID]
ORDER BY [DepartmentID]

---14. Employees Minimum Salaries

  SELECT [DepartmentID], 
    MIN ([Salary]) AS [MinimumSalary]
	FROM [Employees]
   WHERE [DepartmentID] IN (2, 5, 7) AND [HireDate] > '2000-01-01'
GROUP BY [DepartmentID]

---15. Employees Average Salaries

SELECT * 
INTO [EmployeesEarnMoreThan30000]
FROM [Employees]
WHERE [Salary] > 30000

DELETE 
FROM [EmployeesEarnMoreThan30000]
WHERE [ManagerID] = 42

UPDATE [EmployeesEarnMoreThan30000]
SET [Salary] += 5000
WHERE [DepartmentID] = 1

SELECT [DepartmentID], AVG([Salary]) AS [AvarageSalary]
FROM [EmployeesEarnMoreThan30000]
GROUP BY [DepartmentID]

---16. Employees Maximum Salaries

  SELECT [DepartmentID], MAX ([Salary]) AS [MaxSalary]
    FROM [Employees]
GROUP BY [DepartmentID]
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

---17. Employees Count Salaries

SELECT COUNT([Salary]) AS [Count]
FROM [Employees]
WHERE [ManagerID] IS NULL

---18. *3rd Highest Salary

SELECT DISTINCT [DepartmentID],
			    [Salary] AS [ThirdHighestSalary]
FROM (
	SELECT e.[DepartmentID],
		   e.[Salary],
DENSE_RANK() OVER (PARTITION BY e.[DepartmentID] ORDER BY e.[Salary] DESC) AS [SalaryRank]
			FROM [Employees] AS e
     ) AS [SalaryRankingQuery]
    WHERE [SalaryRank] = 3

---19. **Salary Challenge

SELECT TOP (10) e.[FirstName],
		e.[LastName],
		e.[DepartmentID]
     FROM [Employees] AS e
    WHERE [Salary] > (
SELECT AVG([Salary]) AS [DepartmentAvarageSalary]
     FROM [Employees]
    WHERE [DepartmentID] = e.[DepartmentID]
 GROUP BY [DepartmentID]
)
ORDER BY e.[DepartmentID]
