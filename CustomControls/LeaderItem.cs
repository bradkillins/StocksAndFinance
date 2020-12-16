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

        public LeaderItem(string userName, double percentDiff)
        {
            InitializeComponent();
            PercentDiff = percentDiff;
            UserName.Text = userName;
            PercentDiffDisplay.Text = $"{Math.Round(percentDiff, 2)}%";
            if (percentDiff < 0)
                PercentDiffDisplay.ForeColor = Color.Red;
        }
    }
}
