using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace StocksAndFinance
{
    public static class ApiHandler
    {
        static HttpClient client = new HttpClient();
        static string apiDomain = "https://sandbox.iexapis.com/stable/stock/";
        static string apiToken = "?token=Tpk_568a99b487ff4ade901ef1b249601992";


        public static async Task<List<StockHistory>> GetStockData(string symbol)
        {
            string path = $"{apiDomain}{symbol}/chart/1y{apiToken}";
            List<StockHistory> historyData;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
                historyData = await response.Content.ReadAsAsync<List<StockHistory>>();
            else
                throw new Exception("API connection error.");
            return historyData;
        }

    }
}
