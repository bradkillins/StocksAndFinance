using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StocksAndFinance
{
    public static class LeaderboardHelper
    {
        public static void UpdateLeaderBoard(int numOfWeeks, Panel panel)
        {
            List<LeaderItem> items = new List<LeaderItem>();
            foreach (var user in Users.users)
            {
                //items.Add(new LeaderItem(user.FirstName, user.CalculatePortfolioPercentDiff(numOfWeeks)));
                items.Add(new LeaderItem(user, numOfWeeks));
            }
            items = items.OrderByDescending(x => x.PercentDiff).ToList();
            panel.Controls.Clear();
            foreach (var item in items)
            {
                AddLeaderItemToPanel(item, panel);
            }
        }

        public static void AddLeaderItemToPanel(LeaderItem item, Panel panel)
        {
            int yPosition = panel.Controls.Count * item.Height;
            item.Location = new Point(0, yPosition);
            panel.Controls.Add(item);
        }

        public static int MaxNumberOfWeeks()
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
