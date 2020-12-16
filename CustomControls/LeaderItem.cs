using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksAndFinance
{
    public partial class LeaderItem : UserControl
    {
        public double PercentDiff { get; set; }
        User itemUser;

        public LeaderItem(User user, int numOfWeeks)
        {
            InitializeComponent();
            btnViewStocks.Click += ViewStocks_Click;
            btnViewWeeks.Click += ViewBreakdown_Click;

            itemUser = user;
            PercentDiff = user.CalculatePortfolioPercentDiff(numOfWeeks);
            UserName.Text = user.FirstName;
            PercentDiffDisplay.Text = $"{Math.Round(PercentDiff, 2)}%";
            if (PercentDiff < 0)
                PercentDiffDisplay.ForeColor = Color.Red;
        }

        void ViewBreakdown_Click(object sender, EventArgs e)
        {
            WeeklyBreakdown view = new WeeklyBreakdown(itemUser);
            view.StartPosition = FormStartPosition.CenterParent;
            view.ShowDialog();
        }

        void ViewStocks_Click(object sender, EventArgs e)
        {
            string currentStocks = "No Stocks";
            List<string> stocks = new List<string>();
            int count = 0;
            foreach (var history in itemUser.PortfolioHistory)
            {
                if(count == 0)
                {
                    currentStocks = history.StocksOwned;
                }
                stocks.AddRange(history.StocksOwned.Split(','));
                count++;
            }

            List<string> allstocks = new List<string>();
            foreach (var stock in stocks)
            {
                if (!allstocks.Contains(stock))
                {
                    allstocks.Add(stock);
                }
            }

            string everystock = "";
            foreach (var stock in allstocks)
            {
                everystock += stock + " ";
            }

            LeaderboardStockView view = new LeaderboardStockView(currentStocks, everystock);
            view.StartPosition = FormStartPosition.CenterParent;
            view.ShowDialog();
        }

    }
}
