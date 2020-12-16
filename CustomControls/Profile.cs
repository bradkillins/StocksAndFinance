using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
namespace StocksAndFinance.CustomControls
{
    public partial class Profile : UserControl
    {
        private User currentUser;
        public Profile()
        {
            currentUser = Users.currentUser;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            SetAllText();
            SetStockTable();
        }

        private void SetAllText()
        {
            lblUserFullName.Text = currentUser.Name;
            txtEmail.Text = currentUser.Email;
            txtPassword.Text = currentUser.Password;
        }
        private void SetStockTable()
        {
            //initial height
            int height = 0;
            foreach (Stock stock in currentUser.Stocks)
            {
                StockTabs newTab = new StockTabs(stock.Symbol, 100.00, stock.Shares);
                newTab.Location = new Point(0, height);
                pnlStocks.Controls.Add(newTab);
                height += 85;
            }

        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            lblErrorEmail.Text = "";
            string newEmail = txtEmail.Text;
            try
            {
                //confirm emailAddress is correct.
                MailAddress FormatedAddress = new MailAddress(newEmail);
                DbHandler.ChangeEmail(currentUser.UserId, FormatedAddress.Address);
            }
            catch
            {
                lblErrorEmail.Text = "Email is incorrectly formated";
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPass = txtPassword.Text;
            DbHandler.ChangePass(currentUser.UserId, newPass);
        }
    }
}
