
namespace StocksAndFinance.CustomControls
{
    partial class BudgetItem
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
            this.lblBudgetItem = new System.Windows.Forms.Label();
            this.lblBudgetItemAmount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblBudgetItem
            // 
            this.lblBudgetItem.AutoSize = true;
            this.lblBudgetItem.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetItem.Location = new System.Drawing.Point(11, 16);
            this.lblBudgetItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetItem.Name = "lblBudgetItem";
            this.lblBudgetItem.Size = new System.Drawing.Size(227, 31);
            this.lblBudgetItem.TabIndex = 0;
            this.lblBudgetItem.Text = "Budget Item Title";
            // 
            // lblBudgetItemAmount
            // 
            this.lblBudgetItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudgetItemAmount.AutoSize = true;
            this.lblBudgetItemAmount.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetItemAmount.Location = new System.Drawing.Point(582, 19);
            this.lblBudgetItemAmount.Name = "lblBudgetItemAmount";
            this.lblBudgetItemAmount.Size = new System.Drawing.Size(110, 27);
            this.lblBudgetItemAmount.TabIndex = 1;
            this.lblBudgetItemAmount.Text = "$0 of $100";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(17, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(766, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // BudgetItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblBudgetItemAmount);
            this.Controls.Add(this.lblBudgetItem);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BudgetItem";
            this.Size = new System.Drawing.Size(800, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudgetItem;
        private System.Windows.Forms.Label lblBudgetItemAmount;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
