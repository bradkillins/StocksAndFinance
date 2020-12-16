using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StocksAndFinance
{
    public static class DbHandler
    {
        static string ConnecString = ConfigurationManager.ConnectionStrings["financeDB"].ConnectionString;

        public static List<User> SelectAllUsers()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                return dbConnection.Query<User>("SELECT * FROM Users").ToList();
            }
        }

        public static List<Goal> SelectGoals(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                return dbConnection.Query<Goal>($"SELECT * FROM Goals WHERE UserId = {userId}").ToList();
            }
        }

        public static List<Budget> SelectBudgets(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                return dbConnection.Query<Budget>($"SELECT * FROM Budgets WHERE UserId = {userId}").ToList();
            }
        }

        public static List<Stock> SelectStocks(int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                return dbConnection.Query<Stock>($"SELECT * FROM Stocks WHERE UserId = {userId}").ToList();
            }
        }

        public static void InsertBudget(string budgetTitle, char timePeriod, double usedAmount, double budgetAmount, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                //stored procedure
                //dbConnection.Execute($"dbo.InsertNewBudget @budgetTitle, @timePeriod, @usedAmount @budgetAmount, @userId", new { budgetTitle, timePeriod, usedAmount budgetAmount, userId} );
                //sql query
                dbConnection.Execute($"INSERT INTO Budgets(Name, TimePeriod, UsedAmount, BudgetAmount,  UserId) VALUES(@budgetTitle, @timePeriod, @usedAmount, @budgetAmount, @userId)", new { budgetTitle, timePeriod, usedAmount, budgetAmount, userId});
            }
        }
        public static void UpdateUsedAmount(double usedAmount, int budgetId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                dbConnection.Execute($"UPDATE Budgets SET UsedAmount=@usedAmount WHERE UserId = @userId AND BudgetId = @budgetId", new { usedAmount, budgetId, userId });
            }
        }
        public static void UpdateBudget(string budgetTitle, char timePeriod, double usedAmount, double budgetAmount, int userId, int budgetId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                dbConnection.Execute($"UPDATE Budgets SET Name = @budgetTitle, TimePeriod = @timePeriod, UsedAmount = @usedAmount, BudgetAmount = budgetAmount, UserId = @userId WHERE UserId = @userId AND BudgetId = @budgetId", new { budgetTitle, timePeriod, usedAmount, budgetAmount, userId, budgetId });
            }
        }
        public static void DeleteBudget(int budgetId, int userId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnecString))
            {
                dbConnection.Execute($"DELETE FROM Budgets WHERE UserId = @userId AND BudgetId = @budgetId", new { budgetId, userId });
            }
        }
    }
}
