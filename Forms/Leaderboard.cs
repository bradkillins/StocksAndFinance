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
            NumOfWeeks.Maximum = LeaderboardHelper.MaxNumberOfWeeks();
            Load += Leaderboard_Load;
            NumOfWeeks.ValueChanged += NumOfWeeksChanged;
        }

        void Leaderboard_Load(object sender, EventArgs e)
        {
            LeaderboardHelper.UpdateLeaderBoard((int)NumOfWeeks.Value, pnlLeaderList);
        }

        void NumOfWeeksChanged(object sender, EventArgs e)
        {
            LeaderboardHelper.UpdateLeaderBoard((int)NumOfWeeks.Value, pnlLeaderList);
        }

    }
}
