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
    public partial class WeeklyItem : UserControl
    {
        public WeeklyItem(DateTime date, double diff, string stocks)
        {
            InitializeComponent();

            lblDiff.ForeColor = Color.Green;

            string Date = $"{date.Year}/{date.Month}/{date.Day}";
            double Diff = Math.Round(diff, 2);
            if (diff < 0)
                lblDiff.ForeColor = Color.Red;

            lblDate.Text = Date;
            lblDiff.Text = $"{Diff}%";
            lblStocks.Text = stocks;
        }
    }
}
