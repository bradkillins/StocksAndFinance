
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimePeriod = new System.Windows.Forms.ComboBox();
            this.mtxtBudgetAmount = new System.Windows.Forms.MaskedTextBox();
            this.txtBudgetDescription = new System.Windows.Forms.TextBox();
            this.btnCreateBudget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateBudget
            // 
            this.lblCreateBudget.AutoSize = true;
            this.lblCreateBudget.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateBudget.Location = new System.Drawing.Point(142, 71);
            this.lblCreateBudget.Name = "lblCreateBudget";
            this.lblCreateBudget.Size = new System.Drawing.Size(357, 45);
            this.lblCreateBudget.TabIndex = 0;
            this.lblCreateBudget.Text = "Create New Budget";
            // 
            // lblBudgetName
            // 
            this.lblBudgetName.AutoSize = true;
            this.lblBudgetName.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetName.Location = new System.Drawing.Point(157, 169);
            this.lblBudgetName.Name = "lblBudgetName";
            this.lblBudgetName.Size = new System.Drawing.Size(188, 31);
            this.lblBudgetName.TabIndex = 1;
            this.lblBudgetName.Text = "Budget Name:";
            // 
            // txtBudgetName
            // 
            this.txtBudgetName.Location = new System.Drawing.Point(429, 172);
            this.txtBudgetName.Name = "txtBudgetName";
            this.txtBudgetName.Size = new System.Drawing.Size(300, 30);
            this.txtBudgetName.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(157, 244);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(170, 31);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time Period:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(157, 319);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(210, 31);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Budget Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Short Description:";
            // 
            // cmbTimePeriod
            // 
            this.cmbTimePeriod.FormattingEnabled = true;
            this.cmbTimePeriod.Location = new System.Drawing.Point(429, 247);
            this.cmbTimePeriod.Name = "cmbTimePeriod";
            this.cmbTimePeriod.Size = new System.Drawing.Size(300, 30);
            this.cmbTimePeriod.TabIndex = 7;
            // 
            // mtxtBudgetAmount
            // 
            this.mtxtBudgetAmount.Location = new System.Drawing.Point(429, 322);
            this.mtxtBudgetAmount.Name = "mtxtBudgetAmount";
            this.mtxtBudgetAmount.Size = new System.Drawing.Size(300, 30);
            this.mtxtBudgetAmount.TabIndex = 8;
            // 
            // txtBudgetDescription
            // 
            this.txtBudgetDescription.Location = new System.Drawing.Point(429, 397);
            this.txtBudgetDescription.Name = "txtBudgetDescription";
            this.txtBudgetDescription.Size = new System.Drawing.Size(300, 30);
            this.txtBudgetDescription.TabIndex = 9;
            // 
            // btnCreateBudget
            // 
            this.btnCreateBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBudget.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBudget.Location = new System.Drawing.Point(429, 472);
            this.btnCreateBudget.Name = "btnCreateBudget";
            this.btnCreateBudget.Size = new System.Drawing.Size(300, 45);
            this.btnCreateBudget.TabIndex = 10;
            this.btnCreateBudget.Text = "Create Budget";
            this.btnCreateBudget.UseVisualStyleBackColor = true;
            this.btnCreateBudget.Click += new System.EventHandler(this.btnCreateBudget_Click);
            // 
            // CreateBudget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 603);
            this.Controls.Add(this.btnCreateBudget);
            this.Controls.Add(this.txtBudgetDescription);
            this.Controls.Add(this.mtxtBudgetAmount);
            this.Controls.Add(this.cmbTimePeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmount);
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
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimePeriod;
        private System.Windows.Forms.MaskedTextBox mtxtBudgetAmount;
        private System.Windows.Forms.TextBox txtBudgetDescription;
        private System.Windows.Forms.Button btnCreateBudget;
    }
}