namespace MoneyManager
{
    partial class MainForm
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
            this.uxMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gainLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTransactionsListView = new System.Windows.Forms.ListView();
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxTransactionLabel = new System.Windows.Forms.Label();
            this.uxAddAmountBox = new System.Windows.Forms.TextBox();
            this.uxAddDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxDescriptionAddLabel = new System.Windows.Forms.Label();
            this.uxAmountAddLabel = new System.Windows.Forms.Label();
            this.uxDateAddTransaction = new System.Windows.Forms.DateTimePicker();
            this.uxTransactionAddButton = new System.Windows.Forms.Button();
            this.uxAddGoalButton = new System.Windows.Forms.Button();
            this.uxGoalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxGoalDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxGoalAmountBox = new System.Windows.Forms.TextBox();
            this.uxMonthLabel = new System.Windows.Forms.Label();
            this.uxLoseLabel = new System.Windows.Forms.Label();
            this.uxGainLabel = new System.Windows.Forms.Label();
            this.uxLossAmountLabel = new System.Windows.Forms.Label();
            this.uxGainAmountLabel = new System.Windows.Forms.Label();
            this.uxGoalsLabel = new System.Windows.Forms.Label();
            this.uxGoal1Label = new System.Windows.Forms.Label();
            this.uxGoal2Label = new System.Windows.Forms.Label();
            this.uxGoal3Label = new System.Windows.Forms.Label();
            this.uxTransactionRemoveButton = new System.Windows.Forms.Button();
            this.uxCatagoryPicker = new System.Windows.Forms.ComboBox();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxCatagoryLabel = new System.Windows.Forms.Label();
            this.uxGoalDateLabel = new System.Windows.Forms.Label();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMainMenuStrip
            // 
            this.uxMainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempToolStripMenuItem,
            this.uxSearchToolStripMenuItem,
            this.gainLossToolStripMenuItem,
            this.uxLoginToolStripMenuItem});
            this.uxMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMainMenuStrip.Name = "uxMainMenuStrip";
            this.uxMainMenuStrip.Size = new System.Drawing.Size(1226, 28);
            this.uxMainMenuStrip.TabIndex = 0;
            this.uxMainMenuStrip.Text = "menuStrip1";
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLocalToolStripMenuItem});
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.tempToolStripMenuItem.Text = "File";
            // 
            // saveLocalToolStripMenuItem
            // 
            this.saveLocalToolStripMenuItem.Name = "saveLocalToolStripMenuItem";
            this.saveLocalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.saveLocalToolStripMenuItem.Text = "Save Local";
            // 
            // uxSearchToolStripMenuItem
            // 
            this.uxSearchToolStripMenuItem.Name = "uxSearchToolStripMenuItem";
            this.uxSearchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.uxSearchToolStripMenuItem.Text = "Search";
            this.uxSearchToolStripMenuItem.Click += new System.EventHandler(this.uxSearchToolStripMenuItem_Click);
            // 
            // gainLossToolStripMenuItem
            // 
            this.gainLossToolStripMenuItem.Name = "gainLossToolStripMenuItem";
            this.gainLossToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.gainLossToolStripMenuItem.Text = "Gain/Loss";
            // 
            // uxLoginToolStripMenuItem
            // 
            this.uxLoginToolStripMenuItem.Name = "uxLoginToolStripMenuItem";
            this.uxLoginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.uxLoginToolStripMenuItem.Text = "Login";
            this.uxLoginToolStripMenuItem.Click += new System.EventHandler(this.uxLoginToolStripMenuItem_Click);
            // 
            // uxTransactionsListView
            // 
            this.uxTransactionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AmountColumn,
            this.DateColumn,
            this.DescriptionColumn,
            this.Category,
            this.Id});
            this.uxTransactionsListView.GridLines = true;
            this.uxTransactionsListView.Location = new System.Drawing.Point(12, 58);
            this.uxTransactionsListView.Name = "uxTransactionsListView";
            this.uxTransactionsListView.Size = new System.Drawing.Size(809, 515);
            this.uxTransactionsListView.TabIndex = 1;
            this.uxTransactionsListView.UseCompatibleStateImageBehavior = false;
            this.uxTransactionsListView.View = System.Windows.Forms.View.Details;
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "Amount";
            this.AmountColumn.Width = 116;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 105;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 400;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 127;
            // 
            // uxTransactionLabel
            // 
            this.uxTransactionLabel.AutoSize = true;
            this.uxTransactionLabel.Location = new System.Drawing.Point(12, 32);
            this.uxTransactionLabel.Name = "uxTransactionLabel";
            this.uxTransactionLabel.Size = new System.Drawing.Size(90, 17);
            this.uxTransactionLabel.TabIndex = 2;
            this.uxTransactionLabel.Text = "Transactions";
            // 
            // uxAddAmountBox
            // 
            this.uxAddAmountBox.Location = new System.Drawing.Point(12, 612);
            this.uxAddAmountBox.Name = "uxAddAmountBox";
            this.uxAddAmountBox.Size = new System.Drawing.Size(100, 22);
            this.uxAddAmountBox.TabIndex = 3;
            this.uxAddAmountBox.TextChanged += new System.EventHandler(this.uxAddAmountBox_TextChanged);
            // 
            // uxAddDescriptionBox
            // 
            this.uxAddDescriptionBox.Location = new System.Drawing.Point(172, 612);
            this.uxAddDescriptionBox.Name = "uxAddDescriptionBox";
            this.uxAddDescriptionBox.Size = new System.Drawing.Size(408, 22);
            this.uxAddDescriptionBox.TabIndex = 4;
            // 
            // uxDescriptionAddLabel
            // 
            this.uxDescriptionAddLabel.AutoSize = true;
            this.uxDescriptionAddLabel.Location = new System.Drawing.Point(172, 589);
            this.uxDescriptionAddLabel.Name = "uxDescriptionAddLabel";
            this.uxDescriptionAddLabel.Size = new System.Drawing.Size(79, 17);
            this.uxDescriptionAddLabel.TabIndex = 5;
            this.uxDescriptionAddLabel.Text = "Description";
            // 
            // uxAmountAddLabel
            // 
            this.uxAmountAddLabel.AutoSize = true;
            this.uxAmountAddLabel.Location = new System.Drawing.Point(12, 589);
            this.uxAmountAddLabel.Name = "uxAmountAddLabel";
            this.uxAmountAddLabel.Size = new System.Drawing.Size(56, 17);
            this.uxAmountAddLabel.TabIndex = 6;
            this.uxAmountAddLabel.Text = "Amount";
            // 
            // uxDateAddTransaction
            // 
            this.uxDateAddTransaction.Location = new System.Drawing.Point(106, 650);
            this.uxDateAddTransaction.Name = "uxDateAddTransaction";
            this.uxDateAddTransaction.Size = new System.Drawing.Size(298, 22);
            this.uxDateAddTransaction.TabIndex = 8;
            // 
            // uxTransactionAddButton
            // 
            this.uxTransactionAddButton.Location = new System.Drawing.Point(410, 648);
            this.uxTransactionAddButton.Name = "uxTransactionAddButton";
            this.uxTransactionAddButton.Size = new System.Drawing.Size(170, 23);
            this.uxTransactionAddButton.TabIndex = 9;
            this.uxTransactionAddButton.Text = "Add Transaction";
            this.uxTransactionAddButton.UseVisualStyleBackColor = true;
            this.uxTransactionAddButton.Click += new System.EventHandler(this.uxTransactionAddButton_Click);
            // 
            // uxAddGoalButton
            // 
            this.uxAddGoalButton.Enabled = false;
            this.uxAddGoalButton.Location = new System.Drawing.Point(1113, 687);
            this.uxAddGoalButton.Name = "uxAddGoalButton";
            this.uxAddGoalButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddGoalButton.TabIndex = 15;
            this.uxAddGoalButton.Text = "Add Goal";
            this.uxAddGoalButton.UseVisualStyleBackColor = true;
            this.uxAddGoalButton.Click += new System.EventHandler(this.uxAddGoalButton_Click);
            // 
            // uxGoalDate
            // 
            this.uxGoalDate.Location = new System.Drawing.Point(899, 688);
            this.uxGoalDate.Name = "uxGoalDate";
            this.uxGoalDate.Size = new System.Drawing.Size(200, 22);
            this.uxGoalDate.TabIndex = 14;
            this.uxGoalDate.ValueChanged += new System.EventHandler(this.checkGoalButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Goal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Goal Description";
            // 
            // uxGoalDescriptionBox
            // 
            this.uxGoalDescriptionBox.Location = new System.Drawing.Point(808, 648);
            this.uxGoalDescriptionBox.Name = "uxGoalDescriptionBox";
            this.uxGoalDescriptionBox.Size = new System.Drawing.Size(408, 22);
            this.uxGoalDescriptionBox.TabIndex = 11;
            this.uxGoalDescriptionBox.TextChanged += new System.EventHandler(this.checkGoalButton);
            // 
            // uxGoalAmountBox
            // 
            this.uxGoalAmountBox.Location = new System.Drawing.Point(903, 594);
            this.uxGoalAmountBox.Name = "uxGoalAmountBox";
            this.uxGoalAmountBox.Size = new System.Drawing.Size(100, 22);
            this.uxGoalAmountBox.TabIndex = 10;
            this.uxGoalAmountBox.TextChanged += new System.EventHandler(this.checkGoalButton);
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Location = new System.Drawing.Point(860, 32);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(47, 17);
            this.uxMonthLabel.TabIndex = 16;
            this.uxMonthLabel.Text = "Month";
            // 
            // uxLoseLabel
            // 
            this.uxLoseLabel.AutoSize = true;
            this.uxLoseLabel.Location = new System.Drawing.Point(860, 58);
            this.uxLoseLabel.Name = "uxLoseLabel";
            this.uxLoseLabel.Size = new System.Drawing.Size(42, 17);
            this.uxLoseLabel.TabIndex = 17;
            this.uxLoseLabel.Text = "Loss:";
            // 
            // uxGainLabel
            // 
            this.uxGainLabel.AutoSize = true;
            this.uxGainLabel.Location = new System.Drawing.Point(985, 58);
            this.uxGainLabel.Name = "uxGainLabel";
            this.uxGainLabel.Size = new System.Drawing.Size(42, 17);
            this.uxGainLabel.TabIndex = 18;
            this.uxGainLabel.Text = "Gain:";
            // 
            // uxLossAmountLabel
            // 
            this.uxLossAmountLabel.AutoSize = true;
            this.uxLossAmountLabel.Location = new System.Drawing.Point(909, 58);
            this.uxLossAmountLabel.Name = "uxLossAmountLabel";
            this.uxLossAmountLabel.Size = new System.Drawing.Size(46, 17);
            this.uxLossAmountLabel.TabIndex = 19;
            this.uxLossAmountLabel.Text = "label3";
            // 
            // uxGainAmountLabel
            // 
            this.uxGainAmountLabel.AutoSize = true;
            this.uxGainAmountLabel.Location = new System.Drawing.Point(1034, 58);
            this.uxGainAmountLabel.Name = "uxGainAmountLabel";
            this.uxGainAmountLabel.Size = new System.Drawing.Size(46, 17);
            this.uxGainAmountLabel.TabIndex = 20;
            this.uxGainAmountLabel.Text = "label4";
            // 
            // uxGoalsLabel
            // 
            this.uxGoalsLabel.AutoSize = true;
            this.uxGoalsLabel.Location = new System.Drawing.Point(860, 105);
            this.uxGoalsLabel.Name = "uxGoalsLabel";
            this.uxGoalsLabel.Size = new System.Drawing.Size(45, 17);
            this.uxGoalsLabel.TabIndex = 21;
            this.uxGoalsLabel.Text = "Goals";
            // 
            // uxGoal1Label
            // 
            this.uxGoal1Label.AutoSize = true;
            this.uxGoal1Label.Location = new System.Drawing.Point(876, 136);
            this.uxGoal1Label.Name = "uxGoal1Label";
            this.uxGoal1Label.Size = new System.Drawing.Size(43, 17);
            this.uxGoal1Label.TabIndex = 22;
            this.uxGoal1Label.Text = "goal1";
            // 
            // uxGoal2Label
            // 
            this.uxGoal2Label.AutoSize = true;
            this.uxGoal2Label.Location = new System.Drawing.Point(876, 172);
            this.uxGoal2Label.Name = "uxGoal2Label";
            this.uxGoal2Label.Size = new System.Drawing.Size(43, 17);
            this.uxGoal2Label.TabIndex = 23;
            this.uxGoal2Label.Text = "goal2";
            // 
            // uxGoal3Label
            // 
            this.uxGoal3Label.AutoSize = true;
            this.uxGoal3Label.Location = new System.Drawing.Point(876, 204);
            this.uxGoal3Label.Name = "uxGoal3Label";
            this.uxGoal3Label.Size = new System.Drawing.Size(43, 17);
            this.uxGoal3Label.TabIndex = 24;
            this.uxGoal3Label.Text = "goal3";
            // 
            // uxTransactionRemoveButton
            // 
            this.uxTransactionRemoveButton.Location = new System.Drawing.Point(410, 677);
            this.uxTransactionRemoveButton.Name = "uxTransactionRemoveButton";
            this.uxTransactionRemoveButton.Size = new System.Drawing.Size(170, 23);
            this.uxTransactionRemoveButton.TabIndex = 25;
            this.uxTransactionRemoveButton.Text = "Remove Transaction";
            this.uxTransactionRemoveButton.UseVisualStyleBackColor = true;
            this.uxTransactionRemoveButton.Click += new System.EventHandler(this.uxTransactionRemoveButton_Click);
            // 
            // uxCatagoryPicker
            // 
            this.uxCatagoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCatagoryPicker.FormattingEnabled = true;
            this.uxCatagoryPicker.Items.AddRange(new object[] {
            "Food",
            "Other"});
            this.uxCatagoryPicker.Location = new System.Drawing.Point(106, 677);
            this.uxCatagoryPicker.Name = "uxCatagoryPicker";
            this.uxCatagoryPicker.Size = new System.Drawing.Size(298, 24);
            this.uxCatagoryPicker.TabIndex = 26;
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(12, 654);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(42, 17);
            this.uxDateLabel.TabIndex = 27;
            this.uxDateLabel.Text = "Date:";
            // 
            // uxCatagoryLabel
            // 
            this.uxCatagoryLabel.AutoSize = true;
            this.uxCatagoryLabel.Location = new System.Drawing.Point(12, 680);
            this.uxCatagoryLabel.Name = "uxCatagoryLabel";
            this.uxCatagoryLabel.Size = new System.Drawing.Size(69, 17);
            this.uxCatagoryLabel.TabIndex = 28;
            this.uxCatagoryLabel.Text = "Category:";
            // 
            // uxGoalDateLabel
            // 
            this.uxGoalDateLabel.AutoSize = true;
            this.uxGoalDateLabel.Location = new System.Drawing.Point(807, 690);
            this.uxGoalDateLabel.Name = "uxGoalDateLabel";
            this.uxGoalDateLabel.Size = new System.Drawing.Size(72, 17);
            this.uxGoalDateLabel.TabIndex = 29;
            this.uxGoalDateLabel.Text = "Goal Date";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 722);
            this.Controls.Add(this.uxGoalDateLabel);
            this.Controls.Add(this.uxCatagoryLabel);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxCatagoryPicker);
            this.Controls.Add(this.uxTransactionRemoveButton);
            this.Controls.Add(this.uxGoal3Label);
            this.Controls.Add(this.uxGoal2Label);
            this.Controls.Add(this.uxGoal1Label);
            this.Controls.Add(this.uxGoalsLabel);
            this.Controls.Add(this.uxGainAmountLabel);
            this.Controls.Add(this.uxLossAmountLabel);
            this.Controls.Add(this.uxGainLabel);
            this.Controls.Add(this.uxLoseLabel);
            this.Controls.Add(this.uxMonthLabel);
            this.Controls.Add(this.uxAddGoalButton);
            this.Controls.Add(this.uxGoalDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxGoalDescriptionBox);
            this.Controls.Add(this.uxGoalAmountBox);
            this.Controls.Add(this.uxTransactionAddButton);
            this.Controls.Add(this.uxDateAddTransaction);
            this.Controls.Add(this.uxAmountAddLabel);
            this.Controls.Add(this.uxDescriptionAddLabel);
            this.Controls.Add(this.uxAddDescriptionBox);
            this.Controls.Add(this.uxAddAmountBox);
            this.Controls.Add(this.uxTransactionLabel);
            this.Controls.Add(this.uxTransactionsListView);
            this.Controls.Add(this.uxMainMenuStrip);
            this.MainMenuStrip = this.uxMainMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.uxMainMenuStrip.ResumeLayout(false);
            this.uxMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSearchToolStripMenuItem;
        private System.Windows.Forms.ListView uxTransactionsListView;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.Label uxTransactionLabel;
        private System.Windows.Forms.TextBox uxAddAmountBox;
        private System.Windows.Forms.TextBox uxAddDescriptionBox;
        private System.Windows.Forms.Label uxDescriptionAddLabel;
        private System.Windows.Forms.Label uxAmountAddLabel;
        private System.Windows.Forms.DateTimePicker uxDateAddTransaction;
        private System.Windows.Forms.Button uxTransactionAddButton;
        private System.Windows.Forms.Button uxAddGoalButton;
        private System.Windows.Forms.DateTimePicker uxGoalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxGoalDescriptionBox;
        private System.Windows.Forms.TextBox uxGoalAmountBox;
        private System.Windows.Forms.ToolStripMenuItem saveLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gainLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxLoginToolStripMenuItem;
        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.Label uxLoseLabel;
        private System.Windows.Forms.Label uxGainLabel;
        private System.Windows.Forms.Label uxLossAmountLabel;
        private System.Windows.Forms.Label uxGainAmountLabel;
        private System.Windows.Forms.Label uxGoalsLabel;
        private System.Windows.Forms.Label uxGoal1Label;
        private System.Windows.Forms.Label uxGoal2Label;
        private System.Windows.Forms.Label uxGoal3Label;
        private System.Windows.Forms.Button uxTransactionRemoveButton;
        private System.Windows.Forms.ComboBox uxCatagoryPicker;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.Label uxCatagoryLabel;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Label uxGoalDateLabel;
        private System.Windows.Forms.ColumnHeader Id;
    }
}

