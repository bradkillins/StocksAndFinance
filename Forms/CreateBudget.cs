using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksAndFinance
{
    public partial class CreateBudget : Form
    {
        User currentUser;
        internal CreateBudget currentForm;
        public CreateBudget(User user)
        {
            InitializeComponent();
            currentForm = this;
            currentUser = user;
            cmbTimePeriod.Items.Add("Weekly");
            cmbTimePeriod.Items.Add("Bi-Weekly");
            cmbTimePeriod.Items.Add("Monthly");
            cmbTimePeriod.Items.Add("Quarterly");
            cmbTimePeriod.Items.Add("Yearly");
            FormClosing += Validators.ThisFormClosing;
            txtBudgetName.Validating += Validators.NameValidating;
            txtBudgetAmount.Validating += Validators.BudgetAmountValidating;
            txtStartingAmount.Validating += Validators.UsedAmountValidating;
            cmbTimePeriod.Validating += Validators.TimePeriodValidating;
        }

        private void btnCreateBudget_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DbHandler.InsertBudget(txtBudgetName.Text, cmbTimePeriod.SelectedItem.ToString().ToCharArray()[0], double.Parse(txtStartingAmount.Text, CultureInfo.InvariantCulture), double.Parse(txtBudgetAmount.Text, CultureInfo.InvariantCulture), currentUser.UserId);
                Users.currentUser.SetBudget();
                BudgetForm ParentForm = (BudgetForm)this.Parent.Parent;
                ParentForm.CreateBudgetItems();
                currentForm.Close();
            }
            BudgetForm.MainPanel.Controls.Clear();
            BudgetForm.CurrentBudgetForm.CreateBudgetItems();
        }
    }
}
