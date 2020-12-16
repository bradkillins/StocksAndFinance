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
    public partial class Testing : Form
    {
        List<User> users = DbHandler.SelectAllUsers();
        public Testing()
        {
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            foreach(User user in users)
            {
                if (user.UserId == 1)
                {
                    BudgetForm budget = new BudgetForm(user);
                    budget.Show();
                }
            }
            
            //BudgetForm budget = new BudgetForm(currentUser);
            //budget.Show();
        }
    }
}
