using FontAwesome.Sharp;
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
    public partial class GoalForm : Form
    {
        public static GoalForm CurrentGoalForm;
        public static Panel MainPanel;
        public static int GoalStep;
        private Form CurrentChildForm;
        public User CurrentUser;
        public GoalForm()
        {
            InitializeComponent();
            CurrentUser = Users.currentUser;
            //Allow access to CurrentGoalForm in child forms
            CurrentGoalForm = this;
            MainPanel = panelMain;
            Load += GoalForm_Load;
        }

        // Open Child form in main panel of GoalForm
        public void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void ChangeCreateItemColorOnMouseleave(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.WhiteSmoke;
            currentBtn.ForeColor = Color.WhiteSmoke;
        }

        private void ChangeCreateItemColorOnMouseeEnter(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.LightGreen;
            currentBtn.ForeColor = Color.LightGreen;
        }

        private void GoalForm_Load(object sender, EventArgs e)
        {
            CreateGoalItems();
        }
        //Create and display GoalItem Controls
        public void CreateGoalItems()
        {
            panelMain.Controls.Clear();
            int xPosGoalItem = 10;
            int yPosGoalItem = 10;
            //Create a goal item user control for each of the current users goal items
            foreach (Goal item in CurrentUser.Goals)
            {
                pnlGoalItem goalItem = new pnlGoalItem(item.Name, item.Description,item.GoalAmount, item.GoalProgress, item.GoalProgress.ToString(), item.GoalAmount.ToString(), item.DueDate, item.GoalId, CurrentUser.UserId);

                goalItem.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                panelMain.Controls.Add(goalItem);
                goalItem.Location = new Point(xPosGoalItem, yPosGoalItem);
                //space out the goal items
                yPosGoalItem += goalItem.Height +10;
            }
        }

        private void iconButtonCreateGoalItem_Click(object sender, EventArgs e)
        {
            CreateGoal newGoal = new CreateGoal(CurrentUser);
            GoalForm.CurrentGoalForm.OpenChildForm(newGoal);
        }

        private void goalStep_ValueChanged(object sender, EventArgs e)
        {
            GoalStep = (int)goalStepBox.Value;
        }
    }
}
