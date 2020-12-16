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

CREATE TABLE PortfolioHistory (
	PortHistoryId	INT				PRIMARY KEY		IDENTITY,
	Date			DATE			NOT NULL,
	StocksOwned		VARCHAR(MAX)	NOT NULL,
	PercentDiff		DECIMAL(10, 2)	NOT NULL,
	UserId			INT				NOT NULL		REFERENCES Users(UserId)
);

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
	('AAL', 48, 1),
	('ROK', 15, 4),
	('NFLX', 0, 1),
	('INTC', 0, 3);

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

INSERT INTO PortfolioHistory
VALUES
	--Brad
	('2020-12-13', 'AAL,IMB', 0.03, 1),
	('2020-12-06', 'AAL,IMB', 1.05, 1),
	('2020-11-29', 'AAL,IMB', -0.5, 1),
	('2020-11-22', 'AAL,IMB', 0.1, 1),
	('2020-11-15', 'AAL,IMB', 1.5, 1),
	('2020-11-08', 'AAL,IMB', 3.1, 1),
	('2020-11-01', 'AAL,IMB,NFLX', -2.9, 1),
	('2020-10-25', 'AAL,IMB,NFLX', 0.1, 1),
	('2020-10-18', 'AAL,IMB,NFLX', -2.5, 1),
	('2020-10-11', 'AAL,IMB', 1.1, 1),
	('2020-10-04', 'AAL,IMB', 2.3, 1),
	('2020-09-27', 'AAL,IMB', 0, 1),
	--Kevin
	('2020-12-13', 'TD', -0.09, 2),
	('2020-12-06', 'TD', 0.3, 2),
	('2020-11-29', 'TD', 1.26, 2),
	('2020-11-22', 'TD', 2.08, 2),
	('2020-11-15', 'TD', 5.7, 2),
	('2020-11-08', 'TD', 3.5, 2),
	('2020-11-01', 'TD', 0.2, 2),
	('2020-10-25', 'TD', -0.5, 2),
	('2020-10-18', 'TD', -1.2, 2),
	('2020-10-11', 'TD', -2.9, 2),
	('2020-10-04', 'TD', 0.4, 2),
	('2020-09-27', 'TD', 0, 2),
	--Adrian
	('2020-12-13', 'AAPL', 0.1, 3),
	('2020-12-06', 'AAPL,TD', 1.05, 3),
	('2020-11-29', 'AAPL,TD', 6.8, 3),
	('2020-11-22', 'AAPL,TD', 8.8, 3),
	('2020-11-15', 'AAPL,TD', 5.8, 3),
	('2020-11-08', 'AAPL', 1.3, 3),
	('2020-11-01', 'AAPL', 0.8, 3),
	('2020-10-25', 'AAPL,INTC', -6.1, 3),
	('2020-10-18', 'AAPL,INTC', -5.1, 3),
	('2020-10-11', 'AAPL', -0.5, 3),
	('2020-10-04', 'AAPL', 1.2, 3),
	('2020-09-27', 'AAPL', 0, 3),
	--John Smith 
	('2020-12-13', 'ROK', -0.05, 4),
	('2020-12-06', 'ROK', 2.1, 4),
	('2020-11-29', 'ROK', -2.6, 4),
	('2020-11-22', 'ROK', 0.2, 4),
	('2020-11-15', 'ROK', -3.6, 4),
	('2020-11-08', 'ROK', -1.6, 4),
	('2020-11-01', 'ROK', 0, 4);