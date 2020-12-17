using FontAwesome.Sharp;
using StocksAndFinance.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksAndFinance
{
    //User control that formats how goal data is displayed to the user
    public partial class pnlGoalItem : UserControl
    {

        public string lblTitle
        {
            get { return lblGoalItem.Text; }
            set { lblGoalItem.Text = value; }
        }
        public double progressMin = 0.00;

        public double progressMax
        {
            get { return progressBarGoal.Maximum; }
            set { progressBarGoal.Maximum = (int)value; }
        }
        public double progressValue
        {
            get { return progressBarGoal.Value; }
            set { progressBarGoal.Value = (int)value; }
        }
        public string lblprogressValue
        {
            get { return lblGoalItemAmount.Text; }
            set { lblGoalItemAmount.Text = "$" + value.ToString() + " of $"; }
        }
        public string lblprogressMax
        {
            get { return lblGoalItemAmount.Text; }
            set { lblGoalItemAmount.Text += value.ToString(); }
        }
        public DateTime lblDue
        {
            get { return DueDate.Value; }
            set { DueDate.Value = value; }
        }
        //Not sure if theres a better way to access goalId and userId
        internal int goalId;
        internal int userId;

        public pnlGoalItem(string lblTitle,string description, double progressMax, double progressValue, string lblProgressValue, string lblProgressMax, DateTime lblDueDate, int currentGoalId, int currentUserId)
        {
            InitializeComponent();
            this.GoalDescription.Text = description;
            this.lblTitle = lblTitle;
            this.progressMax = progressMax;
            this.progressValue = progressValue;
            this.lblprogressValue = lblProgressValue;
            this.lblprogressMax = lblProgressMax;
            this.lblDue = lblDueDate;
            this.goalId = currentGoalId;
            this.userId = currentUserId;
        }

        private void MouseEnterChangeIconColor(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.Red;
            currentBtn.ForeColor = Color.Red;
            this.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void MouseLeaveChangeIconColor(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.WhiteSmoke;
            currentBtn.ForeColor = Color.WhiteSmoke;
            this.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void GoalItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void GoalItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
        }


        private void PopUpGoalReachedWarning(double used, double goal)
        {
            MessagePrompt prompt = new MessagePrompt($"You have reached your financial goal of ${goal} for {lblGoalItem.Text}!");
            prompt.Show();
        }
        private void iconButtonPlus_Click(object sender, EventArgs e)
        {
            //Update Goal on UI and Database
            progressValue += GoalForm.GoalStep;
            DbHandler.UpdateUsedAmountGoals(progressValue, goalId, userId);
            //Update Static User
            Users.currentUser.Goals = DbHandler.SelectGoals(Users.currentUser.UserId);
            GoalForm parentForm = (GoalForm)this.Parent.Parent.Parent;
            parentForm.CurrentUser = Users.currentUser;

            lblGoalItemAmount.Text = "$" + progressValue.ToString() + " of $" + progressMax.ToString();
            CheckGoal checker = new CheckGoal();


            checker.GoalCheck(progressValue, progressMax);
        }
        //private void SendEmail(double used, double goal)
        //{

        //}
 
        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            progressValue -= GoalForm.GoalStep;
            DbHandler.UpdateUsedAmountGoals(progressValue, goalId, userId);

            Users.currentUser.Goals = DbHandler.SelectGoals(Users.currentUser.UserId);
            GoalForm parentForm = (GoalForm)this.Parent.Parent.Parent;
            parentForm.CurrentUser = Users.currentUser;

            lblGoalItemAmount.Text = "$" + progressValue.ToString() + " of $" + progressMax.ToString();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            DbHandler.DeleteGoal(goalId, userId);

            Users.currentUser.Goals = DbHandler.SelectGoals(Users.currentUser.UserId);

            GoalForm parentForm = (GoalForm)this.Parent.Parent.Parent;
            parentForm.CurrentUser = Users.currentUser;
            parentForm.CreateGoalItems();

            GoalForm.MainPanel.Controls.Remove(this);
        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            EditGoal edit = new EditGoal(lblGoalItem.Text, DueDate.Text, progressBarGoal.Value.ToString(), progressBarGoal.Maximum.ToString(), userId, goalId);
            GoalForm.CurrentGoalForm.OpenChildForm(edit);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(this.Parent != null)
            {
                DateTimePicker datePiker = (DateTimePicker)sender;
                DateTime newDate = datePiker.Value;
                //send database update
                DbHandler.UpadateGoalsDate(goalId, newDate);
                //update static user
                Users.currentUser.Goals = DbHandler.SelectGoals(Users.currentUser.UserId);
                //update parent user.
                GoalForm parentForm = (GoalForm)this.Parent.Parent.Parent;
                parentForm.CurrentUser = Users.currentUser;
                parentForm.CreateGoalItems();
            }
        }
  
    }
    public class CheckGoal
{
    public delegate void goalReached(double used, double goal);
    public event goalReached goalReachedEvent;
    public void GoalCheck(double used, double goal)
    {
        Debug.WriteLine(used.ToString() + goal.ToString());
        if (used == goal)
        {
            goalReachedEvent(used, goal);
        }
    }
}
}
