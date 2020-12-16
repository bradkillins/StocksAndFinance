using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksAndFinance
{
    public partial class LeaderboardStockView : Form
    {
        public LeaderboardStockView(string topStocks, string allStocks)
        {
            InitializeComponent();
            btnClose.Click += Close_Click;
            lblTopStocksDisplay.Text = topStocks;
            lblAllStocksDisplay.Text = allStocks;
        }

        void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
