using StocksAndFinance.Forms;
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

        public partial class EditGoal : Form
        {
            internal int currentUserId;
            internal int currentGoalId;
            internal EditGoal currentForm;
            public EditGoal(string currentName, string dueDate, string currentUsed, string currentGoal, int userId, int goalId)
            {
                InitializeComponent();
                currentForm = this;
                currentUserId = userId;
                currentGoalId = goalId;

                txtGoalName.Text = currentName;
                txtUsedAmount.Text = currentUsed;
                txtGoalAmount.Text = currentGoal;

                FormClosing += Validators.ThisFormClosing;
                txtGoalName.Validating += Validators.NameValidating;
                txtGoalDescription.Validating += Validators.NameValidating;
                txtGoalAmount.Validating += Validators.GoalAmountValidating;
                txtUsedAmount.Validating += Validators.UsedAmountValidating;
                //cmbTimePeriod.Validating += Validators.TimePeriodValidating;
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (ValidateChildren())
                {
                    DbHandler.UpdateGoal(txtGoalName.Text, 
                                        DueDate.Value, 
                                        double.Parse(txtUsedAmount.Text), 
                                        double.Parse(txtGoalAmount.Text), 
                                        txtGoalDescription.Text,
                                        currentUserId, 
                                        currentGoalId);
                    //update static User
                    Users.currentUser.Goals = DbHandler.SelectGoals(Users.currentUser.UserId);
                    GoalForm parentForm = (GoalForm)this.Parent.Parent.Parent;
                    parentForm.CurrentUser = Users.currentUser;
                    //force parent to load
                    parentForm.CreateGoalItems();
                    currentForm.Close();
                }
                

            }
        private void EditGoal_Load(object sender, EventArgs e)
        {

        }
    }
}
