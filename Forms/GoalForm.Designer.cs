
namespace StocksAndFinance.Forms
{
    partial class GoalForm
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
            this.panelGoalsMain = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblGoalStep = new System.Windows.Forms.Label();
            this.goalStepBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButtonCreateBudgetItem = new FontAwesome.Sharp.IconButton();
            this.panelGoalsMain.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalStepBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGoalsMain
            // 
            this.panelGoalsMain.Controls.Add(this.panelMain);
            this.panelGoalsMain.Controls.Add(this.panelTopBar);
            this.panelGoalsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoalsMain.Location = new System.Drawing.Point(0, 0);
            this.panelGoalsMain.Name = "panelGoalsMain";
            this.panelGoalsMain.Size = new System.Drawing.Size(877, 556);
            this.panelGoalsMain.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(877, 456);
            this.panelMain.TabIndex = 3;
            // 
            // panelTopBar
            // 
            this.panelTopBar.Controls.Add(this.lblGoalStep);
            this.panelTopBar.Controls.Add(this.goalStepBox);
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Controls.Add(this.comboBox1);
            this.panelTopBar.Controls.Add(this.iconButtonCreateBudgetItem);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(877, 100);
            this.panelTopBar.TabIndex = 2;
            // 
            // lblGoalStep
            // 
            this.lblGoalStep.AutoSize = true;
            this.lblGoalStep.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalStep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGoalStep.Location = new System.Drawing.Point(351, 52);
            this.lblGoalStep.Name = "lblGoalStep";
            this.lblGoalStep.Size = new System.Drawing.Size(99, 18);
            this.lblGoalStep.TabIndex = 4;
            this.lblGoalStep.Text = "Set Goal Step";
            // 
            // goalStepBox
            // 
            this.goalStepBox.Location = new System.Drawing.Point(500, 47);
            this.goalStepBox.Name = "goalStepBox";
            this.goalStepBox.Size = new System.Drawing.Size(68, 25);
            this.goalStepBox.TabIndex = 3;
            this.goalStepBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(574, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(656, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // iconButtonCreateBudgetItem
            // 
            this.iconButtonCreateBudgetItem.FlatAppearance.BorderSize = 0;
            this.iconButtonCreateBudgetItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCreateBudgetItem.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreateBudgetItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonCreateBudgetItem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonCreateBudgetItem.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonCreateBudgetItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreateBudgetItem.IconSize = 40;
            this.iconButtonCreateBudgetItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCreateBudgetItem.Location = new System.Drawing.Point(12, 33);
            this.iconButtonCreateBudgetItem.Name = "iconButtonCreateBudgetItem";
            this.iconButtonCreateBudgetItem.Size = new System.Drawing.Size(229, 54);
            this.iconButtonCreateBudgetItem.TabIndex = 0;
            this.iconButtonCreateBudgetItem.Text = "Create Budget Item";
            this.iconButtonCreateBudgetItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCreateBudgetItem.UseVisualStyleBackColor = true;
            // 
            // GoalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(877, 556);
            this.Controls.Add(this.panelGoalsMain);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoalForm";
            this.Text = "Goals";
            this.panelGoalsMain.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalStepBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGoalsMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblGoalStep;
        private System.Windows.Forms.NumericUpDown goalStepBox;
        private FontAwesome.Sharp.IconButton iconButtonCreateBudgetItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}