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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            NumOfWeeks.Maximum = MaxNumberOfWeeks();
            Load += Leaderboard_Load;
            NumOfWeeks.ValueChanged += NumOfWeeksChanged;
        }

        void Leaderboard_Load(object sender, EventArgs e)
        {
            UpdateLeaderBoard();
        }

        void NumOfWeeksChanged(object sender, EventArgs e)
        {
            UpdateLeaderBoard();
        }

        void UpdateLeaderBoard()
        {
            List<LeaderItem> items = new List<LeaderItem>();
            foreach (var user in Users.users)
            {
                items.Add(new LeaderItem(user.FirstName, user.CalculatePortfolioPercentDiff((int)NumOfWeeks.Value)));
            }
            items = items.OrderByDescending(x => x.PercentDiff).ToList();
            pnlLeaderList.Controls.Clear();
            foreach (var item in items)
            {
                AddLeaderItemToPanel(item);
            }
        }

        void AddLeaderItemToPanel(LeaderItem item)
        {
            int yPosition = pnlLeaderList.Controls.Count * item.Height;
            item.Location = new Point(0, yPosition);
            pnlLeaderList.Controls.Add(item);
        }

        int MaxNumberOfWeeks()
        {
            int mostWeeks = 0;
            foreach (var user in Users.users)
            {
                if (user.PortfolioHistory.Count > mostWeeks)
                    mostWeeks = user.PortfolioHistory.Count;
            }
            return mostWeeks;
        }
    }
}
