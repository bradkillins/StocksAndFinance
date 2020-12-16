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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            AcceptButton = btnRegister;
            FormClosing += Validators.ThisFormClosing;
            txtEmail.Validating += Validators.EmailValidating;
            txtFirstName.Validating += Validators.NameValidating;
            txtLastName.Validating += Validators.NameValidating;
            txtPassword.Validating += Validators.PasswordValidating;
            txtPasswordConfirm.Validating += Validators.PasswordValidating;
            txtPasswordConfirm.Validating += Validators.MatchingPasswords;
            btnCancel.Click += Cancel_Click;
            btnRegister.Click += Register_Click;
            Load += Register_Load;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (Users.CheckForExsistingUser(txtEmail.Text))
                {
                    MessagePrompt prompt = new MessagePrompt($"A user with email '{txtEmail.Text}' already exists!");
                    if (prompt.ShowDialog() == DialogResult.OK)
                    {
                        txtEmail.Focus();
                        txtEmail.Text = String.Empty;
                    }
                }
                else //no exsisting users with email, proceed to register
                {
                    if (Users.RegisterNewUser(
                        txtEmail.Text,
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtPassword.Text,
                        (radioFree.Checked ? 'F' : 'P')))
                    {
                        MessagePrompt prompt = new MessagePrompt("Successfully Registered!");
                        if (prompt.ShowDialog() == DialogResult.OK)
                            Close();
                    }
                    else
                    {
                        MessagePrompt prompt = new MessagePrompt("Something went wrong! Possibly a database error.\nTry again.");
                        prompt.ShowDialog();
                    }
                }
            }
        }
    }
}
