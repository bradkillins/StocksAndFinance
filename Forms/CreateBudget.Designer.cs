
namespace StocksAndFinance.Forms
{
    partial class CreateBudget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCreateBudget = new System.Windows.Forms.Label();
            this.lblBudgetName = new System.Windows.Forms.Label();
            this.txtBudgetName = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStartingAmount = new System.Windows.Forms.Label();
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.cmbTimePeriod = new System.Windows.Forms.ComboBox();
            this.mtxtStartingAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnCreateBudget = new System.Windows.Forms.Button();
            this.mtxtBudgetAmount = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCreateBudget
            // 
            this.lblCreateBudget.AutoSize = true;
            this.lblCreateBudget.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBudget.Location = new System.Drawing.Point(140, 27);
            this.lblCreateBudget.Name = "lblCreateBudget";
            this.lblCreateBudget.Size = new System.Drawing.Size(357, 45);
            this.lblCreateBudget.TabIndex = 0;
            this.lblCreateBudget.Text = "Create New Budget";
            // 
            // lblBudgetName
            // 
            this.lblBudgetName.AutoSize = true;
            this.lblBudgetName.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetName.Location = new System.Drawing.Point(155, 125);
            this.lblBudgetName.Name = "lblBudgetName";
            this.lblBudgetName.Size = new System.Drawing.Size(188, 31);
            this.lblBudgetName.TabIndex = 1;
            this.lblBudgetName.Text = "Budget Name:";
            // 
            // txtBudgetName
            // 
            this.txtBudgetName.Location = new System.Drawing.Point(427, 128);
            this.txtBudgetName.Name = "txtBudgetName";
            this.txtBudgetName.Size = new System.Drawing.Size(300, 30);
            this.txtBudgetName.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(155, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(170, 31);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time Period:";
            // 
            // lblStartingAmount
            // 
            this.lblStartingAmount.AutoSize = true;
            this.lblStartingAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingAmount.Location = new System.Drawing.Point(155, 275);
            this.lblStartingAmount.Name = "lblStartingAmount";
            this.lblStartingAmount.Size = new System.Drawing.Size(217, 31);
            this.lblStartingAmount.TabIndex = 4;
            this.lblStartingAmount.Text = "Starting Amount:";
            // 
            // lblBudgetAmount
            // 
            this.lblBudgetAmount.AutoSize = true;
            this.lblBudgetAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetAmount.Location = new System.Drawing.Point(155, 350);
            this.lblBudgetAmount.Name = "lblBudgetAmount";
            this.lblBudgetAmount.Size = new System.Drawing.Size(210, 31);
            this.lblBudgetAmount.TabIndex = 5;
            this.lblBudgetAmount.Text = "Budget Amount:";
            // 
            // cmbTimePeriod
            // 
            this.cmbTimePeriod.FormattingEnabled = true;
            this.cmbTimePeriod.Location = new System.Drawing.Point(427, 203);
            this.cmbTimePeriod.Name = "cmbTimePeriod";
            this.cmbTimePeriod.Size = new System.Drawing.Size(300, 30);
            this.cmbTimePeriod.TabIndex = 7;
            // 
            // mtxtStartingAmount
            // 
            this.mtxtStartingAmount.Location = new System.Drawing.Point(427, 278);
            this.mtxtStartingAmount.Name = "mtxtStartingAmount";
            this.mtxtStartingAmount.Size = new System.Drawing.Size(300, 30);
            this.mtxtStartingAmount.TabIndex = 8;
            // 
            // btnCreateBudget
            // 
            this.btnCreateBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBudget.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBudget.Location = new System.Drawing.Point(427, 428);
            this.btnCreateBudget.Name = "btnCreateBudget";
            this.btnCreateBudget.Size = new System.Drawing.Size(300, 45);
            this.btnCreateBudget.TabIndex = 10;
            this.btnCreateBudget.Text = "Create Budget";
            this.btnCreateBudget.UseVisualStyleBackColor = true;
            this.btnCreateBudget.Click += new System.EventHandler(this.btnCreateBudget_Click);
            // 
            // mtxtBudgetAmount
            // 
            this.mtxtBudgetAmount.Location = new System.Drawing.Point(427, 353);
            this.mtxtBudgetAmount.Name = "mtxtBudgetAmount";
            this.mtxtBudgetAmount.Size = new System.Drawing.Size(300, 30);
            this.mtxtBudgetAmount.TabIndex = 11;
            // 
            // CreateBudget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.mtxtBudgetAmount);
            this.Controls.Add(this.btnCreateBudget);
            this.Controls.Add(this.mtxtStartingAmount);
            this.Controls.Add(this.cmbTimePeriod);
            this.Controls.Add(this.lblBudgetAmount);
            this.Controls.Add(this.lblStartingAmount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtBudgetName);
            this.Controls.Add(this.lblBudgetName);
            this.Controls.Add(this.lblCreateBudget);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateBudget";
            this.Text = "Create New Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateBudget;
        private System.Windows.Forms.Label lblBudgetName;
        private System.Windows.Forms.TextBox txtBudgetName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStartingAmount;
        private System.Windows.Forms.Label lblBudgetAmount;
        private System.Windows.Forms.ComboBox cmbTimePeriod;
        private System.Windows.Forms.MaskedTextBox mtxtStartingAmount;
        private System.Windows.Forms.Button btnCreateBudget;
        private System.Windows.Forms.MaskedTextBox mtxtBudgetAmount;
    }
}