using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StocksAndFinance
{
    public static class Validators
    {
        static ErrorProvider error = new ErrorProvider();

        public static void SetupErrorProvidor()
        {
            error.Icon = Properties.Resources.errorIcon;
        }

        public static void EmailValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Regex emailCheck = new Regex(@"^(([A-z0-9#$*+\-_])+(\.){0,1}([A-z0-9#$*+\-_])+)*(([A-z0-9#$*+\-_])+)*\@(([A-z0-9])+([A-z0-9\-])+([A-z0-9])+)*([A-z0-9])*\.[A-z]{2,}$");
            if (emailCheck.IsMatch(textBox.Text))
            {
                error.SetError(textBox, String.Empty);
                e.Cancel = false;
            }
            else
            {
                error.SetError(textBox, "Invalid email.");
                e.Cancel = true;
            }
        }

        public static void PasswordValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 6 && textBox.Text.Length <= 20)
            {
                error.SetError(textBox, String.Empty);
                e.Cancel = false;
            }
            else
            {
                error.SetError(textBox, "Password must be at least 6 characters, but not more than 20.");
                e.Cancel = true;
            }
        }

        public static void NameValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text))
            {
                error.SetError(textBox, "Name field cannot be empty.");
                e.Cancel = true;
            }
            else
            {
                error.SetError(textBox, String.Empty);
                e.Cancel = false;
            }
        }

        public static void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        public static void MatchingPasswords(object sender, CancelEventArgs e)
        {
            Form parent = (Form)((TextBox)sender).Parent;
            TextBox password1 = (TextBox)parent.Controls["txtPassword"];
            TextBox password2 = (TextBox)parent.Controls["txtPasswordConfirm"];

            if(password1.Text != password2.Text)
            {
                error.SetError(password2, "Passwords must match.");
                e.Cancel = true;
            }
            else
            {
                error.SetError(password2, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
