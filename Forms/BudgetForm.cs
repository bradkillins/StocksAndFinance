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
        public BudgetForm()
        {
            InitializeComponent();
        }
        //List<Budget> BudgetData;
        //public BudgetForm(User currentUser)
        //{
        //    InitializeComponent();
        //    BudgetData = currntUser.Budgets;
        //}

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

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            //Use this once user data is pasaed into BudgetForm
            //foreach(Budget item in BudgetData)
            //{
            //    Budget currentBudget = new Budget();
            //}
            List<Budget> currentBudgetData = DbHandler.SelectBudgets(1);
            Budget currentBudget = new Budget();
            foreach (Budget item in currentBudgetData)
            {
                currentBudget.BudgetId = item.BudgetId;
                currentBudget.Name = item.Name;
                currentBudget.Description = item.Description;
                currentBudget.TimePeriod = item.TimePeriod;
                currentBudget.BudgetAmount = item.BudgetAmount;
                currentBudget.UsedAmount = item.UsedAmount;
            }
            Point itemLocation = new Point(10, 10);
            BudgetItem budgetItem = new BudgetItem();
            budgetItem.lblTitle = currentBudget.Name;
            budgetItem.progressMax = currentBudget.BudgetAmount;
            budgetItem.progressValue = currentBudget.UsedAmount;
            budgetItem.lblprogressValue = currentBudget.UsedAmount.ToString();
            budgetItem.lblprogressMax = currentBudget.BudgetAmount.ToString();
            if (currentBudget.Description != null)
            {
                budgetItem.lblDescrip = currentBudget.Description;
            }
            else
            {
                budgetItem.lblDescrip = "";
            }

            panelMain.Controls.Add(budgetItem);
            budgetItem.Location = itemLocation;


           // CreateBudgetItem();
            
            //separation of budgetitem controls once I'm looping through all budget items in list
            //budgetItem.Location = new Point(itemLocation.X, itemLocation.Y+85);
        }
        //Create BudgetItem Control
        private void CreateBudgetItem()
        {

        }
    }
}
