using StocksAndFinance.Forms;
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
    public partial class CreateGoal : Form
    {
        User currentUser;
        internal CreateGoal currentForm;
        public CreateGoal(User user)
        {
            InitializeComponent();
            currentForm = this;
            currentUser = user;
            FormClosing += Validators.ThisFormClosing;
            txtGoalName.Validating += Validators.NameValidating;
            txtGoalAmount.Validating += Validators.GoalAmountValidating;
            txtStartingAmount.Validating += Validators.UsedAmountValidating;
        }

        private void btnCreateGoal_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DbHandler.InsertGoal(txtGoalName.Text, DueDate.Value, double.Parse(txtStartingAmount.Text, CultureInfo.InvariantCulture), double.Parse(txtGoalAmount.Text, CultureInfo.InvariantCulture), txtGoalDescription.Text, currentUser.UserId);
                Users.currentUser.Goals = DbHandler.SelectGoals(Users.currentUser.UserId);
                GoalForm parentForm = (GoalForm)this.Parent.Parent.Parent;
                parentForm.CurrentUser = Users.currentUser;
                parentForm.CreateGoalItems();
                currentForm.Close();
            }
            GoalForm.MainPanel.Controls.Clear();
            GoalForm.CurrentGoalForm.CreateGoalItems();
        }
    }
}
