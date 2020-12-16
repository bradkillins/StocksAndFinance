using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksAndFinance.CustomControls
{
    public partial class StockTabs : UserControl
    {
        string symbol;
        double price;
        int shares;
        public StockTabs(string _symbol, double _price, int _shares)
        {
            this.symbol = _symbol;
            this.price = _price;
            this.shares = _shares;
            InitializeComponent();
        }

        private void StockTabs_Load(object sender, EventArgs e)
        {
            lblPrice.Text = this.price.ToString();
            lblSymbol.Text = this.symbol;
            lblShares.Text = this.shares.ToString();
        }
    }
}
