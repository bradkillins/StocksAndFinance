namespace StocksAndFinance.CustomControls
{
    partial class GoalsTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewGoal = new System.Windows.Forms.Button();
            this.lblGoal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(51, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 406);
            this.panel1.TabIndex = 8;
            // 
            // btnNewGoal
            // 
            this.btnNewGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGoal.Location = new System.Drawing.Point(51, 54);
            this.btnNewGoal.Name = "btnNewGoal";
            this.btnNewGoal.Size = new System.Drawing.Size(254, 36);
            this.btnNewGoal.TabIndex = 7;
            this.btnNewGoal.Text = "Create New Goal";
            this.btnNewGoal.UseVisualStyleBackColor = true;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(56, 107);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(63, 24);
            this.lblGoal.TabIndex = 6;
            this.lblGoal.Text = "Goals";
            // 
            // GoalsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewGoal);
            this.Controls.Add(this.lblGoal);
            this.Name = "GoalsTab";
            this.Size = new System.Drawing.Size(913, 650);
            this.Load += new System.EventHandler(this.GoalsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewGoal;
        private System.Windows.Forms.Label lblGoal;
    }
}
