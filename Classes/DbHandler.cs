﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
namespace StocksAndFinance
{
    public static class DbHandler
    {
        static string ConnectString = ConfigurationManager.ConnectionStrings["financeDB"].ConnectionString;

        public static List<User> SelectAllUsers()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                return dbConnection.Query<User>("SELECT * FROM Users").ToList();
            }
        }

        public static User SelectUser(string email)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            { 
                return dbConnection.Query<User>($"SELECT * FROM Users WHERE Email = '{email}'").ToList()[0];
            }
        }

        public static bool InsertNewUser(string email, string fName, string lName, string password, char type)
        {
            int rowsEffected;
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                string query = @"INSERT INTO Users VALUES(@Email, @FirstName, @LastName, @Password, @Type);";
                rowsEffected = dbConnection.Execute(query, new { 
                    Email = email,
                    FirstName = fName,
                    LastName = lName,
                    Password = password,
                    Type = type
                });
            }
            return rowsEffected == 1;
        }

        public static List<Goal> SelectGoals(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                return dbConnection.Query<Goal>($"SELECT * FROM Goals WHERE UserId = {userId}").ToList();
            }
        }

        public static List<Budget> SelectBudgets(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                return dbConnection.Query<Budget>($"SELECT * FROM Budgets WHERE UserId = {userId}").ToList();
            }
        }

        public static List<Stock> SelectStocks(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                return dbConnection.Query<Stock>($"SELECT * FROM Stocks WHERE UserId = {userId}").ToList();
            }
        }

        public static List<PortfolioHistory> SelectPortfolioHistory(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                return dbConnection.Query<PortfolioHistory>($"SELECT * FROM PortfolioHistory WHERE UserId = '{userId}'").ToList();
            }
        }

        public static void InsertBudget(string budgetTitle, char timePeriod, double usedAmount, double budgetAmount, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                //stored procedure
                //dbConnection.Execute($"dbo.InsertNewBudget @budgetTitle, @timePeriod, @usedAmount @budgetAmount, @userId", new { budgetTitle, timePeriod, usedAmount budgetAmount, userId} );
                //sql query
                dbConnection.Execute($"INSERT INTO Budgets(Name, TimePeriod, UsedAmount, BudgetAmount,  UserId) VALUES(@budgetTitle, @timePeriod, @usedAmount, @budgetAmount, @userId)", new { budgetTitle, timePeriod, usedAmount, budgetAmount, userId});
            }
        }
        public static void UpdateUsedAmount(double usedAmount, int budgetId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE Budgets SET UsedAmount=@usedAmount WHERE UserId = @userId AND BudgetId = @budgetId", new { usedAmount, budgetId, userId });
            }
        }
        public static void UpdateBudget(string budgetTitle, char timePeriod, double usedAmount, double budgetAmount, int userId, int budgetId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE Budgets SET Name = @budgetTitle, TimePeriod = @timePeriod, UsedAmount = @usedAmount, BudgetAmount = @budgetAmount, UserId = @userId WHERE UserId = @userId AND BudgetId = @budgetId", new { budgetTitle, timePeriod, usedAmount, budgetAmount, userId, budgetId });
            }
        }
        public static void UpdateUsedAmountGoals(double usedAmount, int goalId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE Goals SET GoalProgress=@usedAmount WHERE UserId = @userId AND GoalId = @goalId", new { usedAmount, goalId, userId });
            }
        }
        public static void UpadateGoalsDate(int goalId, DateTime dueDate )
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE Goals SET DueDate=@dueDate WHERE GoalId = @goalId", new { dueDate, goalId });
            }
        }
        public static void DeleteBudget(int budgetId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"DELETE FROM Budgets WHERE UserId = @userId AND BudgetId = @budgetId", new { budgetId, userId });
            }
        }
        
        public static void ChangeEmail(int userId, string email)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE dbo.Users SET Email = '{email}' Where UserId = {userId}");
            }
        }
        public static void ChangePass(int userId, string newPass)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE dbo.Users SET Password = '{newPass}' WHERE UserId = {userId}");
            }
        }
        public static void ChangeStockCount(int userID, string symbol, int shares)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE dbo.Stocks Set Shares = {shares} WHERE Symbol = '{symbol}' AND UserId = {userID}");
            }
        }
        public static void AddStock(int userID, string symbol,int shares)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"INSERT INTO dbo.Stocks (Symbol,Shares,UserId) Values( '{symbol}', {shares},{userID} )");
            }
        }

        public static void InsertGoal(string goalTitle, DateTime dueDate, double savedAmount, double goalAmount, string description, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"INSERT INTO Goals(Name, DueDate, GoalProgress, GoalAmount, Description, UserId) VALUES(@goalTitle, @dueDate, @savedAmount, @goalAmount, @description, @userId)", new { goalTitle, dueDate, savedAmount, goalAmount, description, userId });
            }
        }
        public static void UpdateSavedAmount(double savedAmount, int budgetId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE Goals SET UsedAmount=@usedAmount WHERE UserId = @userId AND GoalId = @goalId", new { savedAmount, budgetId, userId });
            }
        }
        public static void UpdateGoal(string goalTitle, DateTime dueDate, double savedAmount, double goalAmount, string description, int userId, int goalId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"UPDATE Goals SET Name = @goalTitle,Description = @description, DueDate = @dueDate, GoalProgress = @savedAmount, GoalAmount = @goalAmount,  UserId = @userId WHERE UserId = @userId AND GoalId = @goalId", new { goalTitle, description, dueDate, savedAmount, goalAmount, userId, goalId });
            }
        }
        public static void DeleteGoal(int goalId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectString))
            {
                dbConnection.Execute($"DELETE FROM Goals WHERE UserId = @userId AND GoalId = @goalId", new { goalId, userId });
            }
        }
    }
}
