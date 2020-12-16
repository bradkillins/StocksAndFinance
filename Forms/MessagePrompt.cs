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
    public partial class MessagePrompt : Form
    {
        public string Message
        {
            get 
            {
                return lblMessage.Text;
            } 
            set 
            {
                lblMessage.Text = value;
            } 
        }
        public MessagePrompt(string message)
        {
            InitializeComponent();
            btnOkay.Click += Okay_Click;
            Message = message;
            AcceptButton = btnOkay;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
