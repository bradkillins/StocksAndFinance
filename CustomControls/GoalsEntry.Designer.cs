namespace StocksAndFinance.CustomControls
{
    partial class GoalsEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSetAmount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkEditGoal = new System.Windows.Forms.LinkLabel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSetDate = new System.Windows.Forms.Label();
            this.lblGoalName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(560, 20);
            this.textBox2.TabIndex = 26;
            // 
            // btnSetAmount
            // 
            this.btnSetAmount.Location = new System.Drawing.Point(566, 51);
            this.btnSetAmount.Name = "btnSetAmount";
            this.btnSetAmount.Size = new System.Drawing.Size(35, 23);
            this.btnSetAmount.TabIndex = 25;
            this.btnSetAmount.Text = "Set";
            this.btnSetAmount.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Amount:";
            // 
            // linkEditGoal
            // 
            this.linkEditGoal.AutoSize = true;
            this.linkEditGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkEditGoal.Location = new System.Drawing.Point(620, 78);
            this.linkEditGoal.Name = "linkEditGoal";
            this.linkEditGoal.Size = new System.Drawing.Size(95, 24);
            this.linkEditGoal.TabIndex = 22;
            this.linkEditGoal.TabStop = true;
            this.linkEditGoal.Text = "Edit Goal";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(36, 109);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(87, 18);
            this.lblProgress.TabIndex = 21;
            this.lblProgress.Text = "Progress: ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(36, 49);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(137, 24);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Goal Amount:";
            // 
            // lblSetDate
            // 
            this.lblSetDate.AutoSize = true;
            this.lblSetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDate.Location = new System.Drawing.Point(36, 25);
            this.lblSetDate.Name = "lblSetDate";
            this.lblSetDate.Size = new System.Drawing.Size(94, 24);
            this.lblSetDate.TabIndex = 19;
            this.lblSetDate.Text = "Set Date:";
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalName.Location = new System.Drawing.Point(327, 7);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(119, 24);
            this.lblGoalName.TabIndex = 18;
            this.lblGoalName.Text = "Goal_Name";
            // 
            // GoalsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSetAmount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkEditGoal);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSetDate);
            this.Controls.Add(this.lblGoalName);
            this.Name = "GoalsEntry";
            this.Size = new System.Drawing.Size(750, 135);
            this.Load += new System.EventHandler(this.GoalsEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSetAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkEditGoal;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSetDate;
        private System.Windows.Forms.Label lblGoalName;
    }
}
