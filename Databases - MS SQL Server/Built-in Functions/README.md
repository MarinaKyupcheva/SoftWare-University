SE SoftUni

---Problem 1.	Find Names of All Employees by First Name

SELECT [FirstName], [LastName] FROM [Employees]
 WHERE LEFT ([FirstName], 2) = 'Sa'

---Problem 2.	  Find Names of All employees by Last Name 

SELECT [FirstName], [LastName] FROM [Employees]
WHERE CHARINDEX ('ei', [LastName]) <> 0

---Problem 3.	Find First Names of All Employees

SELECT [FirstName] FROM [Employees]
 WHERE [DepartmentID] IN (3, 10)
   AND DATEPART (YEAR, [HireDate]) BETWEEN 1995 AND 2005

---Problem 4.	Find All Employees Except Engineers

SELECT [FirstName], [LastName] FROM [Employees]
WHERE [JobTitle] NOT LIKE '%engineer%'

---Problem 5.	Find Towns with Name Length

  SELECT [Name] FROM [Towns]
   WHERE LEN([Name]) IN (5, 6)
ORDER BY [Name]

---Problem 6.	 Find Towns Starting With

SELECT * FROM [Towns]
WHERE LEFT ([Name], 1) IN ('M','K', 'B', 'E')
ORDER BY [Name]

---Problem 7.	 Find Towns Not Starting With

SELECT * FROM [Towns]
WHERE [Name] NOT LIKE '[bdr]%'
ORDER BY [Name]

---Problem 8.	Create View Employees Hired After 2000 Year

GO 

CREATE VIEW [V_EmployeesHiredAfter2000] AS
     SELECT [FirstName], [LastName]
       FROM [Employees]
	   
	
	  
GO

---Problem 9.	Length of Last Name

SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEN([LastName]) IN (5)

---Problem 10.	Rank Employees by Salary

  SELECT [EmployeeID], [FirstName], [LastName], [Salary],
DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
    FROM [Employees]
   WHERE [Salary] BETWEEN 10000 AND 50000
ORDER BY [Salary] DESC

---Problem 11.	Find All Employees with Rank 2 *

SELECT * FROM (
		SELECT [EmployeeID], [FirstName], [LastName], [Salary],
		DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
          FROM [Employees]
         WHERE [Salary] BETWEEN 10000 AND 50000
			 )
      AS [RankingTable]
   WHERE [Rank] = 2
ORDER BY [Salary] DESC

---Problem 12.	Countries Holding ‘A’ 3 or More Times

USE [Geography]

SELECT [CountryName] AS [Country Name],
[IsoCode] AS [Iso Code]
FROM [Countries]
WHERE [CountryName] LIKE '%a%a%a%'
ORDER BY [IsoCode]

---Problem 13.	 Mix of Peak and River Names

SELECT p.[PeakName],
	   r.[RiverName],
	   LOWER(CONCAT(LEFT(p.[PeakName], LEN(p.[PeakName]) - 1), r.[RiverName]))
			 AS[Mix]
FROM [Peaks] AS p,
	[Rivers] AS r
WHERE LOWER(RIGHT(p.[PeakName], 1)) = LOWER (LEFT(r.[RiverName], 1))
ORDER BY [Mix]

---Problem 14.	Games from 2011 and 2012 year

USE [Diablo]

SELECT TOP(50) [Name], [Start] FROM [Games]
WHERE DATEPART(YEAR, [Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name]

