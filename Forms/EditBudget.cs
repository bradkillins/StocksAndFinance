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
    public partial class EditBudget : Form
    {
        internal int currentUserId;
        internal int currentBudgetId;
        internal EditBudget currentForm;
        public EditBudget(string currentName, string currentTime, string currentUsed, string currentBudget, int userId, int budgetId)
        {
            InitializeComponent();
            currentForm = this;
            currentUserId = userId;
            currentBudgetId = budgetId;
            txtBudgetName.Text = currentName;
            txtUsedAmount.Text = currentUsed;
            txtBudgetAmount.Text = currentBudget;
            cmbTimePeriod.Text = currentTime;
            cmbTimePeriod.Items.Add("Weekly");
            cmbTimePeriod.Items.Add("Bi-Weekly");
            cmbTimePeriod.Items.Add("Monthly");
            cmbTimePeriod.Items.Add("Quarterly");
            cmbTimePeriod.Items.Add("Yearly");
            cmbTimePeriod.SelectedIndex = cmbTimePeriod.FindStringExact(currentTime);
            FormClosing += Validators.ThisFormClosing;
            txtBudgetName.Validating += Validators.NameValidating;
            txtBudgetAmount.Validating += Validators.BudgetAmountValidating;
            txtUsedAmount.Validating += Validators.UsedAmountValidating;
            cmbTimePeriod.Validating += Validators.TimePeriodValidating;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DbHandler.UpdateBudget(txtBudgetName.Text, cmbTimePeriod.SelectedItem.ToString().ToCharArray()[0], double.Parse(txtUsedAmount.Text), double.Parse(txtBudgetAmount.Text), currentUserId, currentBudgetId);
                currentForm.Close();
            }
            BudgetForm.MainPanel.Controls.Clear();
            BudgetForm.CurrentBudgetForm.CreateBudgetItems();
        }
    }
}
