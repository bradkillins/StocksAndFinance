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

namespace StocksAndFinance.CustomControls
{
    //User control that formats how budget data is displayed to the user
    public partial class pnlBudgetItem : UserControl
    {
        public pnlBudgetItem()
        {
            InitializeComponent();
        }
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
            set{lblBudgetItemAmount.Text += value.ToString() + "  ";}
        }
        public string lblTime
        {
            get { return lblBudgetItemAmount.Text.ToString(); }
            set { lblBudgetItemAmount.Text += TimePeriod(value); }
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
    }
}
