using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
namespace StocksAndFinance
{
    /// <summary>
    /// https://iexcloud.io Data provided by IEX Cloud
    /// sends an api call and retrieves data from IEX cloud servers.
    /// 
    /// </summary>
    public static class ApiHandler
    {
        static HttpClient client = new HttpClient();
        static string apiDomain = "https://sandbox.iexapis.com/stable/stock/";
        static string apiToken = "?token=Tpk_568a99b487ff4ade901ef1b249601992";
        //Example path  = https://sandbox.iexapis.com/stable/stock/IBM/chart/1y?token=Tpk_568a99b487ff4ade901ef1b249601992

        public static async Task<List<StockHistory>> GetStockData(string symbol)
        {
            //slow down api calls as to not get "429 - too many request" error
            Thread.Sleep(500);
            //assemble path
            string path = $"{apiDomain}{symbol}/chart/1y{apiToken}";

            List<StockHistory> historyData;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
                historyData = await response.Content.ReadAsAsync<List<StockHistory>>();
            else
                throw new Exception("API connection error. ERROR: "+response.ReasonPhrase);
            return historyData;
        }
        public static async Task<bool> CheckValidCall(string Symbol)
        {
            //slow down api calls as to not get "429 - too many request" error
            Thread.Sleep(100);
            string path = $"https://sandbox.iexapis.com/stable/stock/market/batch?symbols={Symbol}&types=chart&range=1m&last=5&token=Tsk_5ececf47c7af4ef1bc724f9e2d85b68e";

            HttpResponseMessage responce = await client.GetAsync(path);
            //if the get request succeeds, return true.
            if (responce.IsSuccessStatusCode)
                return true;
            else
                return false;


        }
    }
}
