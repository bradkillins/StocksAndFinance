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
    }
}
