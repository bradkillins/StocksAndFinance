
namespace StocksAndFinance.CustomControls
{
    partial class pnlBudgetItem
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
            this.progressBarBudget = new System.Windows.Forms.ProgressBar();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBudgetItem
            // 
            this.lblBudgetItem.AutoSize = true;
            this.lblBudgetItem.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetItem.Location = new System.Drawing.Point(12, 9);
            this.lblBudgetItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudgetItem.Name = "lblBudgetItem";
            this.lblBudgetItem.Size = new System.Drawing.Size(202, 27);
            this.lblBudgetItem.TabIndex = 0;
            this.lblBudgetItem.Text = "Budget Item Title:";
            this.lblBudgetItem.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.lblBudgetItem.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            // 
            // lblBudgetItemAmount
            // 
            this.lblBudgetItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudgetItemAmount.AutoSize = true;
            this.lblBudgetItemAmount.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetItemAmount.Location = new System.Drawing.Point(489, 9);
            this.lblBudgetItemAmount.Name = "lblBudgetItemAmount";
            this.lblBudgetItemAmount.Size = new System.Drawing.Size(110, 27);
            this.lblBudgetItemAmount.TabIndex = 1;
            this.lblBudgetItemAmount.Text = "$0 of $100";
            this.lblBudgetItemAmount.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.lblBudgetItemAmount.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            // 
            // progressBarBudget
            // 
            this.progressBarBudget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarBudget.ForeColor = System.Drawing.Color.Green;
            this.progressBarBudget.Location = new System.Drawing.Point(17, 48);
            this.progressBarBudget.Name = "progressBarBudget";
            this.progressBarBudget.Size = new System.Drawing.Size(819, 10);
            this.progressBarBudget.TabIndex = 2;
            this.progressBarBudget.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.progressBarBudget.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEdit.FlatAppearance.BorderSize = 0;
            this.iconButtonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButtonEdit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 30;
            this.iconButtonEdit.Location = new System.Drawing.Point(784, 0);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(37, 30);
            this.iconButtonEdit.TabIndex = 3;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonEdit.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonDelete.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 30;
            this.iconButtonDelete.Location = new System.Drawing.Point(820, 0);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(30, 30);
            this.iconButtonDelete.TabIndex = 4;
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonDelete.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(215, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(149, 22);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Short Description";
            this.lblDescription.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.lblDescription.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            // 
            // pnlBudgetItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.iconButtonEdit);
            this.Controls.Add(this.progressBarBudget);
            this.Controls.Add(this.lblBudgetItemAmount);
            this.Controls.Add(this.lblBudgetItem);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pnlBudgetItem";
            this.Size = new System.Drawing.Size(853, 75);
            this.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudgetItem;
        private System.Windows.Forms.Label lblBudgetItemAmount;
        private System.Windows.Forms.ProgressBar progressBarBudget;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private System.Windows.Forms.Label lblDescription;
    }
}
