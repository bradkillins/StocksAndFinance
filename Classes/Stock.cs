using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksAndFinance
{
    /// <summary>
    /// 
    /// Stock Object that contains stock data.
    /// meant to receive data from the stock table (from stock database). 
    /// Will convert the stock id into the actual stock data from an api call and
    /// stores all stock price history from the past year
    /// 
    /// </summary>
    public class Stock
    {
        public string Symbol { get; set; }
        public int Shares { get; set; }
        public List<StockHistory> History { get; set; }

        public Stock(int StockId, string Symbol, int Shares, int UserId)
        {
            this.Symbol = Symbol;
            this.Shares = Shares;
            SetHistory();
        }
        private async void SetHistory()
        {
            History = await ApiHandler.GetStockData(this.Symbol);
        }
    }
}
