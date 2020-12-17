using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StocksAndFinance.Forms;
using System.Diagnostics;
namespace StocksAndFinance.CustomControls
{
    public partial class HomeButtonControl : UserControl
    {
        MainForm mainForm;
        public HomeButtonControl(MainForm _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;
        }

        private void HomeButtonControl_Load(object sender, EventArgs e)
        {
            pnlProfile.BorderStyle = BorderStyle.Fixed3D;
            Debug.WriteLine("my current directory is : " + Directory.GetCurrentDirectory() + "this is the end");

            //Profile Name
            lblProfileName.Text = Users.currentUser.Name;
            //top logo
            logoImage.SizeMode = PictureBoxSizeMode.StretchImage;
            logoImage.Image = Image.FromFile("../../Resources/DAlogo.png");
            //User button
            btnUser.Image = Image.FromFile("../../Resources/user.png");
            //LeaderBoard
            btnLeaderBoard.Image = Image.FromFile("../../Resources/Trophy.png");
            //Stocks
            btnStocks.Image = Image.FromFile("../../Resources/Stocks.png");
            //Budget
            btnBudget.Image = Image.FromFile("../../Resources/budget.png");
            //Goals
            btnGoals.Image = Image.FromFile("../../Resources/clipboard.png");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            resetButtons();

            Button userButton = (Button)sender;
            //disable this button
            userButton.Enabled = false;
            //change MainPanel to Profile.
            Profile newProfile = new Profile();
            mainForm.SetMainpnl(newProfile);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            resetButtons();
            Button stockButton = (Button)sender;
            //disable this button
            stockButton.Enabled = false;
            //change main panel to stocks.
            StockControl newStockControl = new StockControl();
            mainForm.SetMainpnl(newStockControl);
        }
        private void resetButtons()
        {
            this.btnBudget.Enabled = true;
            this.btnUser.Enabled = true;
            this.btnGoals.Enabled = true;

            this.btnLeaderBoard.Enabled = true;
            this.btnStocks.Enabled = true;

        }
        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            resetButtons();
            Button leaderboardButton = new Button();
            //disable this button
            leaderboardButton.Enabled = false;
            //change main panel to stocks.
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.TopLevel = false;
            leaderboard.AutoScroll = true;
            mainForm.SetMainpnl(leaderboard);
        }


        private void btnBudget_Click(object sender, EventArgs e)
        {
            resetButtons();
            if(Users.currentUser.Type == 'P')
            {
                Button budgetButton = new Button();
                //disable this button
                budgetButton.Enabled = false;
                //change main panel to stocks.
                BudgetForm budgetForm = new BudgetForm();
                budgetForm.TopLevel = false;
                budgetForm.AutoScroll = true;
                mainForm.SetMainpnl(budgetForm);
            }
            else
            {
                MessagePrompt prompt = new MessagePrompt("Sorry but Free users don't have access.\nUpgrade please :)");
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.ShowDialog();
                resetButtons();
            }

        }

        private void btnGoals_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            mainForm.Close();
            


        }
    }
}
