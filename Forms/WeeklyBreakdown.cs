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
    public partial class WeeklyBreakdown : Form
    {
        public WeeklyBreakdown(User user)
        {
            InitializeComponent();
            btnClose.Click += Close_Click;
            
            foreach (var history in user.PortfolioHistory)
            {
                WeeklyItem item = new WeeklyItem(history.Date, history.PercentDiff, history.StocksOwned);
                item.Location = new Point(0, pnlWeeklyItems.Controls.Count * item.Height);
                pnlWeeklyItems.Controls.Add(item);
            }
        }

        void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
