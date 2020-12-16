
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
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonPlus = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.lblBudgetItemAmount.Location = new System.Drawing.Point(39, 0);
            this.lblBudgetItemAmount.Name = "lblBudgetItemAmount";
            this.lblBudgetItemAmount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblBudgetItemAmount.Size = new System.Drawing.Size(88, 32);
            this.lblBudgetItemAmount.TabIndex = 1;
            this.lblBudgetItemAmount.Text = "$0 of $1";
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
            this.progressBarBudget.Size = new System.Drawing.Size(834, 10);
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
            this.iconButtonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonEdit.Location = new System.Drawing.Point(799, 0);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(37, 30);
            this.iconButtonEdit.TabIndex = 3;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.Click += new System.EventHandler(this.iconButtonEdit_Click);
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
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonDelete.Location = new System.Drawing.Point(835, 0);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(30, 30);
            this.iconButtonDelete.TabIndex = 4;
            this.iconButtonDelete.UseVisualStyleBackColor = true;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            this.iconButtonDelete.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonDelete.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // iconButtonMinus
            // 
            this.iconButtonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButtonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinus.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonMinus.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinus.IconSize = 20;
            this.iconButtonMinus.Location = new System.Drawing.Point(3, 3);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButtonMinus.Size = new System.Drawing.Size(30, 30);
            this.iconButtonMinus.TabIndex = 5;
            this.iconButtonMinus.UseVisualStyleBackColor = true;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            this.iconButtonMinus.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonMinus.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // iconButtonPlus
            // 
            this.iconButtonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonPlus.FlatAppearance.BorderSize = 0;
            this.iconButtonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButtonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPlus.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonPlus.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPlus.IconSize = 20;
            this.iconButtonPlus.Location = new System.Drawing.Point(133, 3);
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconButtonPlus.Size = new System.Drawing.Size(30, 30);
            this.iconButtonPlus.TabIndex = 6;
            this.iconButtonPlus.UseVisualStyleBackColor = true;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonPlus_Click);
            this.iconButtonPlus.MouseEnter += new System.EventHandler(this.MouseEnterChangeIconColor);
            this.iconButtonPlus.MouseLeave += new System.EventHandler(this.MouseLeaveChangeIconColor);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.iconButtonMinus);
            this.flowLayoutPanel1.Controls.Add(this.lblBudgetItemAmount);
            this.flowLayoutPanel1.Controls.Add(this.iconButtonPlus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(425, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 36);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.flowLayoutPanel1.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePeriod.Location = new System.Drawing.Point(679, 1);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(109, 27);
            this.lblTimePeriod.TabIndex = 7;
            this.lblTimePeriod.Text = "Bi-Weekly";
            this.lblTimePeriod.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.lblTimePeriod.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            // 
            // pnlBudgetItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.iconButtonEdit);
            this.Controls.Add(this.lblTimePeriod);
            this.Controls.Add(this.progressBarBudget);
            this.Controls.Add(this.lblBudgetItem);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pnlBudgetItem";
            this.Size = new System.Drawing.Size(868, 75);
            this.MouseEnter += new System.EventHandler(this.BudgetItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BudgetItem_MouseLeave);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudgetItem;
        private System.Windows.Forms.Label lblBudgetItemAmount;
        private System.Windows.Forms.ProgressBar progressBarBudget;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTimePeriod;
    }
}
