CREATE DATABASE [Service]

CREATE TABLE Users(
	[Id] INT PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Name] VARCHAR(50),
	[Birthdate] DATETIME2,
	[Age] INT CHECK (Age > 13 AND Age <111),
	[Email] VARCHAR(50) NOT NULL
)

CREATE TABLE [Departments](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Employees](
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(25),
	[LastName] VARCHAR(25),
	[Birthdate] DATETIME2,
	[Age] INT CHECK (Age > 17 AND Age <111),
	[DepartmentId] INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL
)

CREATE TABLE [Categories](
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[DepartmentId] INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL
)

CREATE TABLE [Status](	
	[Id] INT PRIMARY KEY IDENTITY,
	[Label] VARCHAR(30) NOT NULL
)

CREATE TABLE [Reports](
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryId] INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
	[StatusId] INT FOREIGN KEY REFERENCES [Status](Id) NOT NULL,
	[OpenDate] DATETIME2 NOT NULL,
	[CloseDate] DATETIME2,
	[Description] VARCHAR(200) NOT NULL,
	[UserId] INT FOREIGN KEY REFERENCES Users(Id) NOT NULL,
	[EmployeeId] INT FOREIGN KEY REFERENCES Employees(Id)
)

---02---
INSERT INTO Employees(FirstName, LastName, Birthdate, DepartmentId) VALUES
('Marlo', 'O''Malley', '1958-9-21', 1),
('Niki', 'Stanaghan', '1969-11-26', 4),
('Ayrton', 'Senna', '1960-03-21', 9),
('Ronnie', 'Peterson', '1944-02-14', 9),
('Giovanna', 'Amati', '1959-07-20', 5)

INSERT INTO Reports(CategoryId, StatusId, OpenDate, CloseDate, [Description], UserId, EmployeeId) VALUES
(1, 1, '2017-04-13', NULL, 'Stuck Road on Str.133', 6, 2),
(6, 3, '2015-09-05', '2015-12-06', 'Charity trail running', 3, 5),
(14, 2, '2015-09-07', NULL, 'Falling bricks on Str.58', 5, 2),
(4, 3, '2017-07-03', '2017-07-06', 'Cut off streetlight on Str.11', 1, 1)

---03UPDATE---
UPDATE Reports
SET CloseDate = GETDATE()
WHERE CloseDate  IS NULL

---04---
DELETE FROM Reports
WHERE StatusId = 4

---05---
SELECT [Description], FORMAT(OpenDate, 'dd-MM-yyyy')
FROM Reports
WHERE EmployeeId IS NULL
ORDER BY OpenDate, [Description]

---06---
SELECT r.Description as [Description], c.Name as [CategoryName]
FROM Reports as r
JOIN Categories as c
ON c.Id = r.CategoryId
ORDER BY Description, CategoryName

---07---
SELECT TOP 5 c.Name as CategoryName, COUNT(r.CategoryId) as ReportsNumber
FROM Reports as r
JOIN Categories as c
ON c.Id = r.CategoryId
GROUP BY CategoryId, c.Name
ORDER BY ReportsNumber DESC, CategoryName

---08---
SELECT u.Username as [Username], c.Name as [CategoryName]
FROM Reports as r
JOIN Users as u
ON u.Id = r.UserId
JOIN Categories as c
ON c.Id = r.CategoryId
WHERE FORMAT(r.OpenDate, 'dd-MM') = FORMAT(u.Birthdate, 'dd-MM')
ORDER BY Username, CategoryName

---09---
SELECT CONCAT(e.FirstName, ' ', e.LastName) as FullName, COUNT(DISTINCT r.UserId) as UsersCount
FROM Employees as e
LEFT JOIN Reports as r
ON e.Id = r.EmployeeId
GROUP BY e.Id, e.FirstName, e.LastName
ORDER BY UsersCount DESC, FullName

---10---
SELECT ISNULL(NULLIF(CONCAT(e.FirstName, ' ', e.LastName), ' '), 'None') as [Employee],
	   ISNULL(d.Name, 'None') as [Department],
	   ISNULL(c.Name, 'None') as [Category],
	   ISNULL(r.Description, 'None') as [Description],
	   ISNULL(FORMAT(r.OpenDate, 'dd.MM.yyyy'), 'None') as [OpenDate],
	   ISNULL(s.Label, 'None') as [Status],
	   ISNULL(u.Name, 'None') as [User]
FROM Reports as r
LEFT JOIN Employees as e
ON e.Id = r.EmployeeId
LEFT JOIN Departments as d
ON e.DepartmentId = d.Id
LEFT JOIN Categories as c
ON r.CategoryId = c.Id
LEFT JOIN [Status] as s
ON r.StatusId = s.Id
LEFT JOIN Users as u
ON r.UserId = u.Id
ORDER BY e.FirstName DESC, e.LastName DESC, Department, Category, Description,
		 OpenDate, Status, User

---11---
SELECT dbo.udf_HoursToComplete(OpenDate, CloseDate) AS TotalHours
   FROM Reports


CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME2, @EndDate DATETIME2) 
RETURNS INT
AS
BEGIN
	IF(@StartDate IS NULL)
	BEGIN
		RETURN 0;
	END

	IF(@EndDate IS NULL)
	BEGIN
		RETURN 0;
	END
	
	DECLARE @HoursPassed INT = DATEDIFF(hour, @StartDate, @EndDate);
	RETURN @HoursPassed
END

---12---
GO
CREATE PROC usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
BEGIN

	DECLARE @EmployeeDepId INT = (SELECT DepartmentId FROM Employees as e
										WHERE e.Id = @EmployeeId);
	DECLARE @ReportDepId INT = (
		SELECT c.DepartmentId
		FROM Reports as r
		JOIN Categories as c
		ON c.Id = r.CategoryId
		WHERE r.Id = @ReportId
	);

	IF(@EmployeeDepId != @ReportDepId)
	BEGIN
		THROW 50001, 'Employee doesn''t belong to the appropriate department!', 1;
	END

	UPDATE Reports
	Set Reports.EmployeeId = @EmployeeId
	WHERE Reports.Id = @ReportId
END