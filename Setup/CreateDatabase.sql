USE master;
GO
DROP DATABASE IF EXISTS StocksAndFinance;
GO
CREATE DATABASE StocksAndFinance;
GO
USE StocksAndFinance;
GO

CREATE TABLE Users (
	UserId			INT				PRIMARY KEY		IDENTITY,
	Email			VARCHAR(60)		NOT NULL		UNIQUE,
	FirstName		VARCHAR(40)		NOT NULL,
	LastName		VARCHAR(40)		NOT NULL,
	Password		VARCHAR(30)		NOT NULL,		
	Type			CHAR(1)			NOT NULL   --ex) P - paid, F - free
);

CREATE TABLE Stocks (
	StockId			INT				PRIMARY KEY		IDENTITY,
	Symbol			VARCHAR(20)		NOT NULL,
	Shares			INT				NOT NULL,
	UserId			INT				NOT NULL		REFERENCES Users(UserId)
);

CREATE TABLE Goals (
	GoalId			INT				PRIMARY KEY		IDENTITY,
	Name			VARCHAR(100)	NOT NULL,
	Description		VARCHAR(350)	NOT NULL,
	DueDate			DATE			NULL,
	GoalAmount		MONEY			NULL,
	GoalProgress	MONEY			NULL,
	UserId			INT				NOT NULL		REFERENCES Users(UserId)
);

CREATE TABLE Budgets (
	BudgetId		INT				PRIMARY KEY		IDENTITY,
	Name			VARCHAR(100)	NOT NULL,
	TimePeriod		CHAR(1)			NOT NULL,	--ex) W - week, B - biWeekly, M - monthly, Q - quarterly, Y - yearly
	BudgetAmount	MONEY			NOT NULL,
	UsedAmount		MONEY			NOT NULL,
	UserId			INT				NOT NULL		REFERENCES Users(UserId)
);

GO

CREATE FUNCTION fn_GetUserId(@userEmail VARCHAR(60))
	RETURNS INT
BEGIN
	RETURN (SELECT UserId FROM Users WHERE email = @userEmail)
END


--Planning on adding Stored Procs here

GO

INSERT INTO Users
VALUES 
	('brad@app.com', 'Brad', 'Killins', '123456789', 'P'),
	('kevin@app.com', 'Kevin', 'Tran', '123456789', 'P'),
	('adrian@app.com', 'Adrian', 'Todd', '123456789', 'P'),
	('cheap@app.com', 'John', 'Smith', '123456789', 'F');

INSERT INTO Stocks
VALUES 
	('IBM', 57, 1),
	('AAPL', 39, 3),
	('TD', 209, 2),
	('AAL', 48, 1);

INSERT INTO Goals
VALUES
	('Vacation', 'Trip to Mexico', '2022-01-15', 3500, 250, 1),
	('Gaming Rig', 'Buying an insane computer', '2021-06-01', 4000, 2500, 2),
	('Mountain Bike', 'A nice mountain bike', '2021-05-01', 1200, 650, 3);

INSERT INTO Budgets
VALUES
	('Groceries', 'M', 250, 55, 1),
	('Bills', 'M', 300, 230, 1),
	('Entertainment', 'B', 45, 16, 1),
	('Bills', 'M', 300, 230, 2),
	('Entertainment', 'B', 45, 16, 3);