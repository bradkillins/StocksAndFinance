using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksAndFinance.Forms
{
    public partial class CreateBudget : Form
    {
        User currentUser;
        public CreateBudget(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnCreateBudget_Click(object sender, EventArgs e)
        {
            DbHandler.InsertBudget(txtBudgetName.Text, (char)cmbTimePeriod.SelectedItem, double.Parse(mtxtStartingAmount.Text), double.Parse(mtxtBudgetAmount.Text), currentUser.UserId);
        }
    }
}
