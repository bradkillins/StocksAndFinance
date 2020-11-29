using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAndFinance
{
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
        }
    }
}
