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
using StocksAndFinance.CustomControls;

namespace StocksAndFinance.Forms
{
    public partial class BudgetForm : Form
    {
        public static BudgetForm CurrentBudgetForm;
        public static Panel MainPanel;
        public static int BudgetStep;
        private Form CurrentChildForm;
        private User CurrentUser;
        public BudgetForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            //Allow access to CurrentBudgetForm in child forms
            CurrentBudgetForm = this;
            MainPanel = panelMain;
        }

       // Open Child form in main panel of BudgetForm
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

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            CreateBudgetItems();
        }
        //Create and display BudgetItem Controls
        public void CreateBudgetItems()
        {
            int xPosBudgetItem = 10;
            int yPosBudgetItem = 10;
            //Create a budget item user control for each of the current users budget items
            foreach (Budget item in CurrentUser.Budgets)
            {  
                pnlBudgetItem budgetItem = new pnlBudgetItem(item.Name, item.BudgetAmount, item.UsedAmount, item.UsedAmount.ToString(), item.BudgetAmount.ToString(), item.TimePeriod.ToString(), item.BudgetId, CurrentUser.UserId);

                budgetItem.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                panelMain.Controls.Add(budgetItem);
                budgetItem.Location = new Point(xPosBudgetItem, yPosBudgetItem);
                //space out the budget items
                yPosBudgetItem += 85;
            }
        }

        private void iconButtonCreateBudgetItem_Click(object sender, EventArgs e)
        {
            CreateBudget newBudget = new CreateBudget(CurrentUser);
            BudgetForm.CurrentBudgetForm.OpenChildForm(newBudget);
        }

        private void budgetStep_ValueChanged(object sender, EventArgs e)
        {
            BudgetStep = (int)budgetStepBox.Value;
        }
    }
}
