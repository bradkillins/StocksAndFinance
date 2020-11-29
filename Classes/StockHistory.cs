using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StocksAndFinance
{
    public class StockHistory
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("close")]
        public double Price { get; set; }
    }
}
