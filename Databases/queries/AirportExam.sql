-----01DDL----
CREATE DATABASE Airport
USE Airport

CREATE TABLE Planes (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL,
	[Seats] INT NOT NULL,
	[Range] INT NOT NULL
)

CREATE TABLE Flights(
	[Id] INT PRIMARY KEY IDENTITY,
	[DepartureTime] DATETIME2,
	[ArrivalTime] DATETIME2,
	[Origin] VARCHAR(50) NOT NULL,
	[Destination] VARCHAR(50) NOT NULL,
	[PlaneId] INT FOREIGN KEY REFERENCES Planes(Id) NOT NULL
)

CREATE TABLE Passengers(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(30) NOT NULL,
	[LastName] VARCHAR(30) NOT NULL,
	[Age] INT NOT NULL,
	[Address] VARCHAR(30) NOT NULL,
	[PassportId] CHAR(11) NOT NULL
)

CREATE TABLE LuggageTypes(
	[Id] INT PRIMARY KEY IDENTITY,
	[Type] VARCHAR(30) NOT NULL	
)

CREATE TABLE Luggages(
	[Id] INT PRIMARY KEY IDENTITY,
	[LuggageTypeId] INT FOREIGN KEY REFERENCES LuggageTypes(Id) NOT NULL,
	[PassengerId] INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL 
)

CREATE TABLE Tickets(
	[Id] INT PRIMARY KEY IDENTITY,
	[PassengerId] INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
	[FlightId] INT FOREIGN KEY REFERENCES Flights(Id) NOT NULL,
	[LuggageId] INT FOREIGN KEY REFERENCES Luggages(Id) NOT NULL,
	[Price] DECIMAL(18,2) NOT NULL
)

---02INSERT---

INSERT INTO Planes([Name], [Seats], [Range]) VALUES
('Airbus 336', 112, 5132),
('Airbus 330', 432,	5325),
('Boeing 369', 231, 2355),
('Stelt 297', 254, 2143),
('Boeing 338', 165, 5111),
('Airbus 558', 387, 1342),
('Boeing 128', 345, 5541)

INSERT INTO LuggageTypes([Type]) VALUES
('Crossbody Bag'),
('School Backpack'),
('Shoulder Bag')

---03UPDATE---
UPDATE Tickets
SET Price *= 1.13
WHERE FlightId  IN ( SELECT [Id] FROM Flights
					 WHERE [Destination] = 'Carlsbad')

---04DELETE---
DELETE FROM Tickets
WHERE FlightId IN (
					SELECT Id FROM Flights
					WHERE [Destination] = 'Ayn Halagim')
DELETE FROM Flights
WHERE [Destination] = 'Ayn Halagim'


---05TR_PLANES---
SELECT * FROM Planes
WHERE [Name] LIKE '%tr%'
ORDER BY Id, [Name], [Seats], [Range]

---06FLIGHT_PROFITS---
SELECT f.Id AS [FlightId], SUM(t.Price) AS [Price]
FROM Flights as f
JOIN Tickets as t ON t.FlightId = f.Id
GROUP BY f.Id
ORDER BY [Price] DESC, [FlightId]

---07PASSENGER_TRIPS---
SELECT CONCAT(p.FirstName, ' ', p.LastName) AS [Full Name],
	   f.Origin,
	   f.Destination
FROM Passengers AS p
JOIN Tickets AS t
ON t.PassengerId = p.Id
JOIN Flights as f
ON t.FlightId = f.Id
ORDER BY [Full Name], [Origin], [Destination]

---08NON_ADV_PEOPLE---
SELECT FirstName AS [First Name], LastName AS [Last Name], Age
FROM Passengers AS p
WHERE p.Id NOT IN (SELECT PassengerId FROM Tickets)
ORDER BY Age DESC, [First Name], [Last Name]

---09FULL_INFO---
SELECT CONCAT(p.FirstName, ' ',p.LastName) AS [Full Name], pl.Name AS [Plane Name], CONCAT(f.Origin, ' - ', f.Destination) AS [Trip], lt.Type AS [Luggage Type]
FROM Passengers AS p
JOIN Tickets AS t
ON t.PassengerId = p.Id
JOIN Flights AS f
ON t.FlightId = f.Id
JOIN Planes AS pl
ON f.PlaneId = pl.Id
JOIN Luggages as l
ON t.LuggageId = l.Id
JOIN LuggageTypes AS lt
ON l.LuggageTypeId = lt.Id
ORDER BY [Full Name], [Plane Name], f.Origin, f.Destination, [Luggage Type]

---10PSP---
SELECT p.Name, p.Seats AS [Seats], COUNT(t.FlightId) AS [Passenger Count]
FROM Planes AS p
LEFT JOIN Flights as f
ON p.Id = f.PlaneId
LEFT JOIN Tickets as t
ON f.Id = t.FlightId
GROUP BY p. Name, p.Seats
ORDER BY [Passenger Count] DESC, [Name] ASC, [Seats]

---11VACATION----
CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR(50), @destination VARCHAR(50), @peopleCount INT)
RETURNS VARCHAR(100)
AS
BEGIN
	IF(@peopleCount <= 0)
	BEGIN
		RETURN 'Invalid people count!'
	END

	DECLARE @flightId INT = (SELECT TOP(1) Id FROM Flights
								WHERE Origin = @origin AND Destination = @destination);
	
	IF(@flightId IS NULL)
	BEGIN
		RETURN 'Invalid flight!';
	END

	DECLARE @pricePerPerson DECIMAL(18, 2) = (SELECT TOP(1) Price FROM Tickets AS t
												WHERE t.Id = @flightId);
	DECLARE @totalPrice DECIMAL(24, 2) = @pricePerPerson * @peopleCount;

	RETURN CONCAT('Total price ', @totalPrice);
END
---12WRONG_DATA---
GO