using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAndFinance
{
    public class PortfolioHistory
    {
        public int PortHistoryId { get; set; }
        public DateTime Date { get; set; }
        public string StocksOwned { get; set; }
        public double PercentDiff { get; set; }
        public int UserId { get; set; }
    }
}
