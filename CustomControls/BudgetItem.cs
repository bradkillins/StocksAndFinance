using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using StocksAndFinance.Forms;
using System.Diagnostics;

namespace StocksAndFinance
{
    //User control that formats how budget data is displayed to the user
    public partial class pnlBudgetItem : UserControl
    {
        
        public string lblTitle
        {
            get{return lblBudgetItem.Text;}
            set{lblBudgetItem.Text = value;}
        }
        public double progressMin = 0.00;
        
        public double progressMax
        {
            get{return progressBarBudget.Maximum;}
            set{progressBarBudget.Maximum = (int)value;}
        }
        public double progressValue
        {
            get{return progressBarBudget.Value;}
            set{progressBarBudget.Value = (int)value;}
        }
        public string lblprogressValue
        {
            get{return lblBudgetItemAmount.Text;}
            set{lblBudgetItemAmount.Text = "$" + value.ToString() + " of $";}
        }
        public string lblprogressMax
        {
            get{return lblBudgetItemAmount.Text;}
            set{lblBudgetItemAmount.Text += value.ToString();}
        }
        public string lblTime
        {
            get { return lblTimePeriod.Text; }
            set { lblTimePeriod.Text = TimePeriod(value); }
        }
        //Not sure if theres a better way to access budgetId and userId
        internal int budgetId;
        internal int userId;

        public pnlBudgetItem(string lblTitle, double progressMax, double progressValue, string lblProgressValue, string lblProgressMax, string lblTime, int currentBudgetId, int currentUserId )
        {
            InitializeComponent();
            this.lblTitle = lblTitle;
            this.progressMax = progressMax;
            this.progressValue = progressValue;
            this.lblprogressValue = lblProgressValue;
            this.lblprogressMax = lblProgressMax;
            this.lblTime = lblTime;
            this.budgetId = currentBudgetId;
            this.userId = currentUserId;
        }

        //Change time value from database into human readable value
        private string TimePeriod(string timeChar)
        {
            switch (timeChar)
            {
                case "W":
                    return "Weekly";
                case "B":
                    return "Bi-Weekly";
                case "M":
                    return "Monthly";
                case "Q":
                    return "Quaterly";
                case "Y":
                    return "Yearly";
                default:
                    return "";
            }
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
            this.BackColor = Color.FromArgb(40,40,40);
        }
                
        private void BudgetItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void BudgetItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void SendEmail(double used, double budget)
        {
            EmailSender.SendEmail(Users.currentUser.Email, $"your budget {lblTitle} was reached, Congratulations");
        }
        private void PopUpBudgetReachedWarning(double used, double budget)
        {
            MessagePrompt prompt = new MessagePrompt($"Your ${budget} budget for {lblBudgetItem.Text} this {lblTimePeriod.Text} time period has been reached!");
            prompt.StartPosition = FormStartPosition.CenterParent;
            prompt.Show();
        }
        private void iconButtonPlus_Click(object sender, EventArgs e)
        {
            progressValue += BudgetForm.BudgetStep;
            DbHandler.UpdateUsedAmount(progressValue, budgetId, userId);
            Users.currentUser.Budgets = DbHandler.SelectBudgets(Users.currentUser.UserId);
            lblBudgetItemAmount.Text = "$" + progressValue.ToString() + " of $" + progressMax.ToString();
            CheckBudget checker = new CheckBudget();
            checker.budgetReachedEvent += SendEmail;
            checker.budgetReachedEvent += PopUpBudgetReachedWarning;
            checker.BudgetCheck(progressValue, progressMax);
        }
        private void iconButtonMinus_Click(object sender, EventArgs e)
        {
            progressValue -= BudgetForm.BudgetStep;
            DbHandler.UpdateUsedAmount(progressValue, budgetId, userId);
            Users.currentUser.Budgets = DbHandler.SelectBudgets(Users.currentUser.UserId);
            lblBudgetItemAmount.Text = "$" + progressValue.ToString() + " of $" + progressMax.ToString();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            DbHandler.DeleteBudget(budgetId, userId);
            //update user
            Users.currentUser.Budgets = DbHandler.SelectBudgets(Users.currentUser.UserId);
            BudgetForm parentForm = (BudgetForm)this.Parent.Parent;
            parentForm.CurrentUser = Users.currentUser;
            parentForm.CreateBudgetItems();

            BudgetForm.MainPanel.Controls.Remove(this);
        }

        private void iconButtonEdit_Click(object sender, EventArgs e)
        {
            EditBudget edit = new EditBudget(lblBudgetItem.Text, lblTimePeriod.Text, progressBarBudget.Value.ToString(), progressBarBudget.Maximum.ToString(), userId, budgetId);
            BudgetForm.CurrentBudgetForm.OpenChildForm(edit);
            
        }
    }
}

public class CheckBudget
{
    public delegate void budgetReached(double used, double budget);
    public event budgetReached budgetReachedEvent;
    public void BudgetCheck(double used, double budget)
    {
        Debug.WriteLine(used.ToString() + budget.ToString());
        if (used == budget)
        {
            budgetReachedEvent(used, budget);
        }
    }

}

