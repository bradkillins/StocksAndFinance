using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StocksAndFinance.CustomControls;
namespace StocksAndFinance.Forms
{
    public partial class MainForm : Form
    {
        public Login parentLogin;
        public MainForm(Login _parentLogin)
        {
            this.parentLogin = _parentLogin;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlWidget.Controls.Add(new HomeButtonControl(this));
        }
        public void SetMainpnl(UserControl userControl)
        {
            pnlMaincontent.Controls.Clear();
            pnlMaincontent.Controls.Add(userControl);
        }
        public void SetMainpnl(Form form)
        {
            pnlMaincontent.Controls.Clear();
            pnlMaincontent.Controls.Add(form);
            form.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }
    }
}
