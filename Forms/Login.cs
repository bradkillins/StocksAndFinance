//logo retrived from: https://logodix.com/logos/606388 License: Non-comercial use
//error icon from: https://www.iconsdb.com/red-icons/error-7-icon.html

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace StocksAndFinance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            txtLoginEmail.Validating += Validators.EmailValidating;
            txtLoginPassword.Validating += Validators.PasswordValidating;
            FormClosing += Validators.ThisFormClosing;
            btnLogin.Click += Login_Click;
            btnRegister.Click += Register_Click;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("OPENING");
            if (ValidateChildren())
            {
                if(Users.Login(txtLoginEmail.Text, txtLoginPassword.Text))
                {
                    //Load main form? 
                    this.Hide();
                    Forms.MainForm MainPage = new Forms.MainForm(this);

                    MainPage.ShowDialog();

                    //temp code for testing
                    //MessagePrompt prompt = new MessagePrompt("Successful Login!");
                    //prompt.ShowDialog();
                }
                else
                {
                    string message = "No user found with email/password combination provided." +
                        "\n\nRegister if you're new here!";
                    MessagePrompt prompt = new MessagePrompt(message);
                    prompt.ShowDialog();
                }
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            SetupNewForm(register);
        }

        private void SetupNewForm(Form form)
        {
            form.TopLevel = false;
            form.Parent = this;
            form.Top = 0;
            form.Left = 0;
            form.BringToFront();
            form.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
