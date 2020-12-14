using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAndFinance
{
    public class Budget
    {
        public int BudgetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public char TimePeriod { get; set; }
        public double BudgetAmount { get; set; }
        public double UsedAmount { get; set; }

        //Constructors
        //public Budget(int budgetId, string name, char timePeriod, double budgetAmount, double UsedAmount)
        //{
        //    this.BudgetId = budgetId;
        //    this.Name = name;
        //    this.TimePeriod = timePeriod;
        //    this.BudgetAmount = budgetAmount;
        //    this.UsedAmount = UsedAmount;
        //}
        //public Budget(string name, char timePeriod, double budgetAmount)
        //{
        //    this.Name = name;
        //    this.TimePeriod = timePeriod;
        //    this.BudgetAmount = budgetAmount;
        //}
    }
}
