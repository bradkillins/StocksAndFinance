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
        public string lblDescrip
        {
            get{return lblDescription.Text;}
            set{lblDescription.Text = value;}
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

        private string TimePeriod(string timeChar)
        {
            switch (timeChar)
            {
                case "W":
                    return "Weekly";
                    break;
                case "B":
                    return "Bi-Weekly";
                    break;
                case "M":
                    return "Monthly";
                    break;
                case "Q":
                    return "Quaterly";
                    break;
                case "Y":
                    return "Yearly";
                    break;
                default:
                    return "";
                    break;
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
