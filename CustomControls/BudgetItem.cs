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
    public partial class BudgetItem : UserControl
    {
        public BudgetItem()
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
            set{lblBudgetItemAmount.Text += value.ToString();}
        }

        private void MouseEnterChangeIconColor(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.Red;
            currentBtn.ForeColor = Color.Red;
        }

        private void MouseLeaveChangeIconColor(object sender, EventArgs e)
        {
            var currentBtn = (IconButton)sender;
            currentBtn.IconColor = Color.WhiteSmoke;
            currentBtn.ForeColor = Color.WhiteSmoke;
        }
    }
}
