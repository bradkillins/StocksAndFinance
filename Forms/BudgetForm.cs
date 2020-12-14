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
        List<Budget> BudgetData;
        int xPosBudgetItem = 10;
        int yPosBudgetItem = 10;
        public BudgetForm(User currentUser)
        {
            InitializeComponent();
            BudgetData = currentUser.Budgets;
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
            currentBtn.IconColor = Color.Green;
            currentBtn.ForeColor = Color.Green;
        }

        //private void BudgetForm_Load(object sender, EventArgs e)
        //{
        //    //Create a budget item user control for each of the current users budget items
        //    foreach (Budget item in BudgetData)
        //    {
        //        Budget currentBudget = item;
        //        currentBudget.BudgetId = item.BudgetId;
        //        currentBudget.Name = item.Name;
        //        currentBudget.Description = item.Description;
        //        currentBudget.TimePeriod = item.TimePeriod;
        //        currentBudget.BudgetAmount = item.BudgetAmount;
        //        currentBudget.UsedAmount = item.UsedAmount;
        //        CreateBudgetItem(currentBudget);
        //    }
        //}

        ////Create BudgetItem Control
        //private void CreateBudgetItem(Budget currentBudget)
        //{
        //    pnlBudgetItem budgetItem = new pnlBudgetItem();
        //    budgetItem.lblTitle = currentBudget.Name;
        //    budgetItem.progressMax = currentBudget.BudgetAmount;
        //    budgetItem.progressValue = currentBudget.UsedAmount;
        //    budgetItem.lblprogressValue = currentBudget.UsedAmount.ToString();
        //    budgetItem.lblprogressMax = currentBudget.BudgetAmount.ToString();
        //    if (currentBudget.Description != null)
        //    {
        //        budgetItem.lblDescrip = currentBudget.Description;
        //    }
        //    else
        //    {
        //        budgetItem.lblDescrip = "";
        //    }
        //    budgetItem.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //    panelMain.Controls.Add(budgetItem);
        //    budgetItem.Location = new Point(xPosBudgetItem, yPosBudgetItem);
        //    //space out the controls
        //    yPosBudgetItem += 85;
        //}

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            CreateBudgetItems();
        }
        //Create and display BudgetItem Controls
        private void CreateBudgetItems()
        {
            //Create a budget item user control for each of the current users budget items
            foreach (Budget item in BudgetData)
            {
                Budget currentBudget = item;
                currentBudget.BudgetId = item.BudgetId;
                currentBudget.Name = item.Name;
                currentBudget.Description = item.Description;
                currentBudget.TimePeriod = item.TimePeriod;
                currentBudget.BudgetAmount = item.BudgetAmount;
                currentBudget.UsedAmount = item.UsedAmount;

                pnlBudgetItem budgetItem = new pnlBudgetItem();
                budgetItem.lblTitle = currentBudget.Name;
                budgetItem.progressMax = currentBudget.BudgetAmount;
                budgetItem.progressValue = currentBudget.UsedAmount;
                budgetItem.lblprogressValue = currentBudget.UsedAmount.ToString();
                budgetItem.lblprogressMax = currentBudget.BudgetAmount.ToString();
                budgetItem.lblTime = currentBudget.TimePeriod.ToString();
                if (currentBudget.Description != null)
                {
                    budgetItem.lblDescrip = currentBudget.Description;
                }
                else
                {
                    budgetItem.lblDescrip = "";
                }

                budgetItem.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                panelMain.Controls.Add(budgetItem);
                budgetItem.Location = new Point(xPosBudgetItem, yPosBudgetItem);
                //space out the controls
                yPosBudgetItem += 85;
            }
        }
    }
}
