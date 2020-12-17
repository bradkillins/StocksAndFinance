
namespace StocksAndFinance
{
    partial class CreateGoal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartingAmount = new System.Windows.Forms.TextBox();
            this.txtGoalAmount = new System.Windows.Forms.TextBox();
            this.btnCreateBudget = new System.Windows.Forms.Button();
            this.lblGoalAmount = new System.Windows.Forms.Label();
            this.lblStartingAmount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.lblGoalName = new System.Windows.Forms.Label();
            this.lblCreateGoal = new System.Windows.Forms.Label();
            this.txtGoalDescription = new System.Windows.Forms.TextBox();
            this.Goaldescription = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "$";
            // 
            // txtStartingAmount
            // 
            this.txtStartingAmount.Location = new System.Drawing.Point(423, 236);
            this.txtStartingAmount.Name = "txtStartingAmount";
            this.txtStartingAmount.Size = new System.Drawing.Size(300, 25);
            this.txtStartingAmount.TabIndex = 24;
            this.txtStartingAmount.Text = "0.00";
            // 
            // txtGoalAmount
            // 
            this.txtGoalAmount.Location = new System.Drawing.Point(423, 311);
            this.txtGoalAmount.Name = "txtGoalAmount";
            this.txtGoalAmount.Size = new System.Drawing.Size(300, 25);
            this.txtGoalAmount.TabIndex = 23;
            this.txtGoalAmount.Text = "0.00";
            // 
            // btnCreateBudget
            // 
            this.btnCreateBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBudget.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBudget.Location = new System.Drawing.Point(423, 446);
            this.btnCreateBudget.Name = "btnCreateBudget";
            this.btnCreateBudget.Size = new System.Drawing.Size(300, 45);
            this.btnCreateBudget.TabIndex = 22;
            this.btnCreateBudget.Text = "Create Goal";
            this.btnCreateBudget.UseVisualStyleBackColor = true;
            this.btnCreateBudget.Click += new System.EventHandler(this.btnCreateGoal_Click);
            // 
            // lblGoalAmount
            // 
            this.lblGoalAmount.AutoSize = true;
            this.lblGoalAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalAmount.Location = new System.Drawing.Point(151, 308);
            this.lblGoalAmount.Name = "lblGoalAmount";
            this.lblGoalAmount.Size = new System.Drawing.Size(143, 25);
            this.lblGoalAmount.TabIndex = 20;
            this.lblGoalAmount.Text = "Goal Amount:";
            // 
            // lblStartingAmount
            // 
            this.lblStartingAmount.AutoSize = true;
            this.lblStartingAmount.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingAmount.Location = new System.Drawing.Point(151, 233);
            this.lblStartingAmount.Name = "lblStartingAmount";
            this.lblStartingAmount.Size = new System.Drawing.Size(173, 25);
            this.lblStartingAmount.TabIndex = 19;
            this.lblStartingAmount.Text = "Starting Amount:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(151, 158);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 25);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Due Date:";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(423, 86);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(300, 25);
            this.txtGoalName.TabIndex = 17;
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalName.Location = new System.Drawing.Point(151, 83);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(127, 25);
            this.lblGoalName.TabIndex = 16;
            this.lblGoalName.Text = "Goal Name:";
            // 
            // lblCreateGoal
            // 
            this.lblCreateGoal.AutoSize = true;
            this.lblCreateGoal.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateGoal.Location = new System.Drawing.Point(136, 5);
            this.lblCreateGoal.Name = "lblCreateGoal";
            this.lblCreateGoal.Size = new System.Drawing.Size(382, 36);
            this.lblCreateGoal.TabIndex = 15;
            this.lblCreateGoal.Text = "Create New Financial Goal";
            // 
            // txtGoalDescription
            // 
            this.txtGoalDescription.Location = new System.Drawing.Point(423, 387);
            this.txtGoalDescription.Name = "txtGoalDescription";
            this.txtGoalDescription.Size = new System.Drawing.Size(300, 25);
            this.txtGoalDescription.TabIndex = 28;
            // 
            // Goaldescription
            // 
            this.Goaldescription.AutoSize = true;
            this.Goaldescription.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goaldescription.Location = new System.Drawing.Point(151, 384);
            this.Goaldescription.Name = "Goaldescription";
            this.Goaldescription.Size = new System.Drawing.Size(170, 25);
            this.Goaldescription.TabIndex = 27;
            this.Goaldescription.Text = "Goal Description";
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(423, 158);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(300, 25);
            this.DueDate.TabIndex = 29;
            // 
            // CreateGoal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.txtGoalDescription);
            this.Controls.Add(this.Goaldescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartingAmount);
            this.Controls.Add(this.txtGoalAmount);
            this.Controls.Add(this.btnCreateBudget);
            this.Controls.Add(this.lblGoalAmount);
            this.Controls.Add(this.lblStartingAmount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.lblGoalName);
            this.Controls.Add(this.lblCreateGoal);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateGoal";
            this.Text = "CreateGoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartingAmount;
        private System.Windows.Forms.TextBox txtGoalAmount;
        private System.Windows.Forms.Button btnCreateBudget;
        private System.Windows.Forms.Label lblGoalAmount;
        private System.Windows.Forms.Label lblStartingAmount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.Label lblGoalName;
        private System.Windows.Forms.Label lblCreateGoal;
        private System.Windows.Forms.TextBox txtGoalDescription;
        private System.Windows.Forms.Label Goaldescription;
        private System.Windows.Forms.DateTimePicker DueDate;
    }
}