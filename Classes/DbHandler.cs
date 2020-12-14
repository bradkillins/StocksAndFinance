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

        //public static void InsertBudget(string budgetTitle, char timePeriod, double budgetAmount, int userId)
        //{
        //    using (IDbConnection dbConnection = new SqlConnection(ConnecString))
        //    {
        //        new Budget(budgetTitle, timePeriod, budgetAmount);
        //        dbConnection.Execute($"dbo.InsertNewBudget @budgetTitle, @timePeriod, @budgetAmount, @{userId}");
        //    }
        //}
    }
}
