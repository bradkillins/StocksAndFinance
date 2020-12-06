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
        //public Budget(int budgetId, string name, string description, char timePeriod, double budgetAmount, double UsedAmount)
        //{
        //    this.BudgetId = budgetId;
        //    this.Name = name;
        //    if(description != null)
        //    {
        //        this.Description = description;
        //    }
        //    else
        //    {
        //        this.Description = "";
        //    }
        //    this.TimePeriod = timePeriod;
        //    this.BudgetAmount = budgetAmount;
        //    this.UsedAmount = UsedAmount;
        //}
        //public Budget(int id)
        //{
        //    List<Budget> budgetData = DbHandler.SelectBudgets(id);
        //    Budget currentBudget = new Budget(id);
        //    foreach (Budget item in budgetData)
        //    {
        //        currentBudget.BudgetId = item.BudgetId;
        //        currentBudget.Name = item.Name;
        //        currentBudget.Description = item.Description;
        //        currentBudget.TimePeriod = item.TimePeriod;
        //        currentBudget.BudgetAmount = item.BudgetAmount;
        //        currentBudget.UsedAmount = item.UsedAmount;
        //    }
        //}
        //public Budget(List<Budget> budgetData)
        //{
        //    foreach (Budget item in budgetData)
        //    {
        //        this.BudgetId = item.BudgetId;
        //        this.Name = item.Name;
        //        if(item.Description != null)
        //        {
        //            this.Description = item.Description;
        //        }
        //        else
        //        {
        //            this.Description = "";
        //        }
        //        this.TimePeriod = item.TimePeriod;
        //        this.BudgetAmount = item.BudgetAmount;
        //        this.UsedAmount = item.UsedAmount;
        //    }
        //}
    }
}
