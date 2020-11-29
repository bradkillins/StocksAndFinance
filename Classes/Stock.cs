using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAndFinance
{
    public class Stock
    {
        public string Symbol { get; set; }
        public int Shares { get; set; }
        public List<StockHistory> History { get; }

        public Stock(int StockId, string Symbol, int Shares, int UserId)
        {
            this.Symbol = Symbol;
            this.Shares = Shares;
            History = ApiHandler.GetStockData(Symbol).GetAwaiter().GetResult();
        }
    }
}
