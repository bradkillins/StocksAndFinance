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
                double stockPriceToday = stock.History[stock.History.Count-1].Price;
                StockTabs newTab = new StockTabs(stock.Symbol, stockPriceToday, stock.Shares);
                newTab.Location = new Point(0, height);
                pnlStocks.Controls.Add(newTab);
                height += 85;
            }

        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            lblInvalidEmailEntry.Text = "";
            string newEmail = txtEmail.Text;
            try
            {
                //confirm emailAddress is correct.
                MailAddress FormatedAddress = new MailAddress(newEmail);
                DbHandler.ChangeEmail(currentUser.UserId, FormatedAddress.Address);
                //update current user
                Users.currentUser.Email = newEmail;
                //update local user on profile page.
                currentUser = Users.currentUser;
            }
            catch
            {
                txtEmail.Text = currentUser.Email;
                lblInvalidEmailEntry.Text = "Email is incorrectly formated";
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //remove errorbox
            lblInvalidPassword.Text = "";

            string newPass = txtPassword.Text;
            //change pass
            if (ValidatePassword(newPass))
            {
                //update database
                DbHandler.ChangePass(currentUser.UserId, newPass);
                //update current user
                Users.currentUser.Password = newPass;
                //update local user on profile page.
                currentUser = Users.currentUser;
            }
            else //reset Pass and pop error
            {
                lblInvalidPassword.Text = "Password Must be 6 Characters long";
                txtPassword.Text = Users.currentUser.Password;
            }
        }

        private bool ValidatePassword(string password)
        {
            bool valid = true;
            if(password.Length < 6)
            {
                valid = false;
            }
            return valid;
        }

    }
}
