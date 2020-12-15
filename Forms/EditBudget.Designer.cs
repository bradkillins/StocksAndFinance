
namespace StocksAndFinance.Forms
{
    partial class EditBudget
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbTimePeriod = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtBudgetName = new System.Windows.Forms.TextBox();
            this.lblBudgetName = new System.Windows.Forms.Label();
            this.lblEditBudget = new System.Windows.Forms.Label();
            this.lblSpent = new System.Windows.Forms.Label();
            this.txtUsedAmount = new System.Windows.Forms.TextBox();
            this.txtBudgetAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(430, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 45);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Budget";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbTimePeriod
            // 
            this.cmbTimePeriod.FormattingEnabled = true;
            this.cmbTimePeriod.Location = new System.Drawing.Point(430, 183);
            this.cmbTimePeriod.Name = "cmbTimePeriod";
            this.cmbTimePeriod.Size = new System.Drawing.Size(300, 30);
            this.cmbTimePeriod.TabIndex = 17;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(158, 300);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(210, 31);
            this.lblAmount.TabIndex = 15;
            this.lblAmount.Text = "Budget Amount:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(158, 180);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(170, 31);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time Period:";
            // 
            // txtBudgetName
            // 
            this.txtBudgetName.Location = new System.Drawing.Point(430, 123);
            this.txtBudgetName.Name = "txtBudgetName";
            this.txtBudgetName.Size = new System.Drawing.Size(300, 30);
            this.txtBudgetName.TabIndex = 13;
            // 
            // lblBudgetName
            // 
            this.lblBudgetName.AutoSize = true;
            this.lblBudgetName.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetName.Location = new System.Drawing.Point(158, 120);
            this.lblBudgetName.Name = "lblBudgetName";
            this.lblBudgetName.Size = new System.Drawing.Size(188, 31);
            this.lblBudgetName.TabIndex = 12;
            this.lblBudgetName.Text = "Budget Name:";
            // 
            // lblEditBudget
            // 
            this.lblEditBudget.AutoSize = true;
            this.lblEditBudget.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBudget.Location = new System.Drawing.Point(143, 34);
            this.lblEditBudget.Name = "lblEditBudget";
            this.lblEditBudget.Size = new System.Drawing.Size(229, 45);
            this.lblEditBudget.TabIndex = 11;
            this.lblEditBudget.Text = "Edit Budget";
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent.Location = new System.Drawing.Point(158, 240);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(190, 31);
            this.lblSpent.TabIndex = 21;
            this.lblSpent.Text = "Amount Spent:";
            // 
            // txtUsedAmount
            // 
            this.txtUsedAmount.Location = new System.Drawing.Point(430, 240);
            this.txtUsedAmount.Name = "txtUsedAmount";
            this.txtUsedAmount.Size = new System.Drawing.Size(300, 30);
            this.txtUsedAmount.TabIndex = 22;
            // 
            // txtBudgetAmount
            // 
            this.txtBudgetAmount.Location = new System.Drawing.Point(430, 303);
            this.txtBudgetAmount.Name = "txtBudgetAmount";
            this.txtBudgetAmount.Size = new System.Drawing.Size(300, 30);
            this.txtBudgetAmount.TabIndex = 23;
            // 
            // EditBudget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.txtBudgetAmount);
            this.Controls.Add(this.txtUsedAmount);
            this.Controls.Add(this.lblSpent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbTimePeriod);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtBudgetName);
            this.Controls.Add(this.lblBudgetName);
            this.Controls.Add(this.lblEditBudget);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBudget";
            this.Text = "EditBudget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbTimePeriod;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtBudgetName;
        private System.Windows.Forms.Label lblBudgetName;
        private System.Windows.Forms.Label lblEditBudget;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.TextBox txtUsedAmount;
        private System.Windows.Forms.TextBox txtBudgetAmount;
    }
}