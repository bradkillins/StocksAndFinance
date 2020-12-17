
namespace StocksAndFinance
{
    partial class EditGoal
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
            this.txtGoalAmount = new System.Windows.Forms.TextBox();
            this.txtUsedAmount = new System.Windows.Forms.TextBox();
            this.lblSpent = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.lblGoalName = new System.Windows.Forms.Label();
            this.lblEditGoal = new System.Windows.Forms.Label();
            this.txtGoalDescription = new System.Windows.Forms.TextBox();
            this.lblGoalNote = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtGoalAmount
            // 
            this.txtGoalAmount.Location = new System.Drawing.Point(441, 292);
            this.txtGoalAmount.Name = "txtGoalAmount";
            this.txtGoalAmount.Size = new System.Drawing.Size(300, 25);
            this.txtGoalAmount.TabIndex = 33;
            // 
            // txtUsedAmount
            // 
            this.txtUsedAmount.Location = new System.Drawing.Point(441, 229);
            this.txtUsedAmount.Name = "txtUsedAmount";
            this.txtUsedAmount.Size = new System.Drawing.Size(300, 25);
            this.txtUsedAmount.TabIndex = 32;
            // 
            // lblSpent
            // 
            this.lblSpent.AutoSize = true;
            this.lblSpent.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent.Location = new System.Drawing.Point(169, 229);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(151, 25);
            this.lblSpent.TabIndex = 31;
            this.lblSpent.Text = "Amount Spent:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(441, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 45);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update Goal";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(169, 289);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(143, 25);
            this.lblAmount.TabIndex = 28;
            this.lblAmount.Text = "Goal Amount:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(169, 169);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 25);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Due Date:";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(441, 112);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(300, 25);
            this.txtGoalName.TabIndex = 26;
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalName.Location = new System.Drawing.Point(169, 109);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(151, 25);
            this.lblGoalName.TabIndex = 25;
            this.lblGoalName.Text = "Budget Name:";
            // 
            // lblEditGoal
            // 
            this.lblEditGoal.AutoSize = true;
            this.lblEditGoal.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGoal.Location = new System.Drawing.Point(84, 29);
            this.lblEditGoal.Name = "lblEditGoal";
            this.lblEditGoal.Size = new System.Drawing.Size(281, 36);
            this.lblEditGoal.TabIndex = 24;
            this.lblEditGoal.Text = "Edit Financial Goal";
            // 
            // txtGoalDescription
            // 
            this.txtGoalDescription.Location = new System.Drawing.Point(441, 354);
            this.txtGoalDescription.Name = "txtGoalDescription";
            this.txtGoalDescription.Size = new System.Drawing.Size(300, 25);
            this.txtGoalDescription.TabIndex = 35;
            // 
            // lblGoalNote
            // 
            this.lblGoalNote.AutoSize = true;
            this.lblGoalNote.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalNote.Location = new System.Drawing.Point(169, 351);
            this.lblGoalNote.Name = "lblGoalNote";
            this.lblGoalNote.Size = new System.Drawing.Size(176, 25);
            this.lblGoalNote.TabIndex = 34;
            this.lblGoalNote.Text = "Goal Description:";
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(441, 169);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(300, 25);
            this.DueDate.TabIndex = 36;
            // 
            // EditGoal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.txtGoalDescription);
            this.Controls.Add(this.lblGoalNote);
            this.Controls.Add(this.txtGoalAmount);
            this.Controls.Add(this.txtUsedAmount);
            this.Controls.Add(this.lblSpent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.lblGoalName);
            this.Controls.Add(this.lblEditGoal);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditGoal";
            this.Text = "EditGoal";
            this.Load += new System.EventHandler(this.EditGoal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoalAmount;
        private System.Windows.Forms.TextBox txtUsedAmount;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.Label lblGoalName;
        private System.Windows.Forms.Label lblEditGoal;
        private System.Windows.Forms.TextBox txtGoalDescription;
        private System.Windows.Forms.Label lblGoalNote;
        private System.Windows.Forms.DateTimePicker DueDate;
    }
}