using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAndFinance
{
    /// <summary>
    /// User object
    /// 
    /// Modeled to hold all the values from the database User object.
    /// contains a list of stocks from the Stock table that contains the user's ID
    /// contains a list of Goals from the Goal table that contains the user's ID
    /// contains a list of budget form the buget table that contains the user's ID
    /// 
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { 
            get {
                return $"{FirstName} {LastName}";
            }
        }
        public string Password { get; set; }
        public char Type { get; set; }

        public List<Stock> Stocks { get; set; }
        public List<Goal> Goals { get; set; }
        public List<Budget> Budgets { get; set; }
        public List<PortfolioHistory> PortfolioHistory { get; set; }

        public User(int UserId, string Email, string FirstName, string LastName, string Password, char Type)
        {
            this.UserId = UserId;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Password = Password;
            this.Type = Type;

            Goals = DbHandler.SelectGoals(UserId);
            Budgets = DbHandler.SelectBudgets(UserId);
            Stocks = DbHandler.SelectStocks(UserId);
            PortfolioHistory = DbHandler.SelectPortfolioHistory(UserId);
            PortfolioHistory = PortfolioHistory.OrderByDescending(x => x.Date).ToList();
        }

        //force stock list to be set again.
        public void setStock()
        {
            Stocks = null;
            Stocks = DbHandler.SelectStocks(UserId);
        }
        public void SetBudget()
        {
            Budgets = null;
            Budgets = DbHandler.SelectBudgets(UserId);
        }
        public void SetPortfolio()
        {
            PortfolioHistory = null;
            PortfolioHistory = DbHandler.SelectPortfolioHistory(UserId);
        }
        public double CalculatePortfolioPercentDiff(int numOfWeeks)
        {
            if (numOfWeeks > PortfolioHistory.Count)
                numOfWeeks = PortfolioHistory.Count;
            double totalDiff = 0;
            for (int i = 0; i < numOfWeeks; i++)
            {
                totalDiff += PortfolioHistory[i].PercentDiff;
            }
            return totalDiff;
        }

    }
}
