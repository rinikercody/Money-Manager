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
            this.uxSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gainLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheduledTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTransactionsListView = new System.Windows.Forms.ListView();
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.uxLossLabel = new System.Windows.Forms.Label();
            this.uxGainLabel = new System.Windows.Forms.Label();
            this.uxLossAmountLabel = new System.Windows.Forms.Label();
            this.uxGainAmountLabel = new System.Windows.Forms.Label();
            this.uxGoalsHeadingLabel = new System.Windows.Forms.Label();
            this.uxGoalsLabel = new System.Windows.Forms.Label();
            this.uxTransactionRemoveButton = new System.Windows.Forms.Button();
            this.uxCatagoryPicker = new System.Windows.Forms.ComboBox();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxCatagoryLabel = new System.Windows.Forms.Label();
            this.uxGoalDateLabel = new System.Windows.Forms.Label();
            this.NetLabel = new System.Windows.Forms.Label();
            this.uxNetAmountLabel = new System.Windows.Forms.Label();
            this.uxViewGoalsButton = new System.Windows.Forms.Button();
            this.uxMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMainMenuStrip
            // 
            this.uxMainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxSearchToolStripMenuItem,
            this.gainLossToolStripMenuItem,
            this.uxLoginToolStripMenuItem,
            this.sheduledTransactionsToolStripMenuItem});
            this.uxMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMainMenuStrip.Name = "uxMainMenuStrip";
            this.uxMainMenuStrip.Size = new System.Drawing.Size(1226, 28);
            this.uxMainMenuStrip.TabIndex = 0;
            this.uxMainMenuStrip.Text = "menuStrip1";
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
            this.gainLossToolStripMenuItem.Click += new System.EventHandler(this.gainLossToolStripMenuItem_Click);
            // 
            // uxLoginToolStripMenuItem
            // 
            this.uxLoginToolStripMenuItem.Name = "uxLoginToolStripMenuItem";
            this.uxLoginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.uxLoginToolStripMenuItem.Text = "Login";
            this.uxLoginToolStripMenuItem.Click += new System.EventHandler(this.uxLoginToolStripMenuItem_Click);
            // 
            // sheduledTransactionsToolStripMenuItem
            // 
            this.sheduledTransactionsToolStripMenuItem.Name = "sheduledTransactionsToolStripMenuItem";
            this.sheduledTransactionsToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.sheduledTransactionsToolStripMenuItem.Text = "Sheduled Transactions";
            this.sheduledTransactionsToolStripMenuItem.Click += new System.EventHandler(this.sheduledTransactionsToolStripMenuItem_Click);
            // 
            // uxTransactionsListView
            // 
            this.uxTransactionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AmountColumn,
            this.DateColumn,
            this.DescriptionColumn,
            this.Category,
            this.Id});
            this.uxTransactionsListView.FullRowSelect = true;
            this.uxTransactionsListView.GridLines = true;
            this.uxTransactionsListView.Location = new System.Drawing.Point(12, 64);
            this.uxTransactionsListView.MultiSelect = false;
            this.uxTransactionsListView.Name = "uxTransactionsListView";
            this.uxTransactionsListView.Size = new System.Drawing.Size(842, 509);
            this.uxTransactionsListView.TabIndex = 1;
            this.uxTransactionsListView.UseCompatibleStateImageBehavior = false;
            this.uxTransactionsListView.View = System.Windows.Forms.View.Details;
            this.uxTransactionsListView.SelectedIndexChanged += new System.EventHandler(this.uxTransactionsListView_SelectedIndexChanged);
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "Amount";
            this.AmountColumn.Width = 80;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 115;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 300;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 266;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 75;
            // 
            // uxTransactionLabel
            // 
            this.uxTransactionLabel.AutoSize = true;
            this.uxTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTransactionLabel.Location = new System.Drawing.Point(12, 32);
            this.uxTransactionLabel.Name = "uxTransactionLabel";
            this.uxTransactionLabel.Size = new System.Drawing.Size(151, 29);
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
            this.uxAddGoalButton.Location = new System.Drawing.Point(1131, 674);
            this.uxAddGoalButton.Name = "uxAddGoalButton";
            this.uxAddGoalButton.Size = new System.Drawing.Size(83, 27);
            this.uxAddGoalButton.TabIndex = 15;
            this.uxAddGoalButton.Text = "Add Goal";
            this.uxAddGoalButton.UseVisualStyleBackColor = true;
            this.uxAddGoalButton.Click += new System.EventHandler(this.uxAddGoalButton_Click);
            // 
            // uxGoalDate
            // 
            this.uxGoalDate.Location = new System.Drawing.Point(855, 675);
            this.uxGoalDate.Name = "uxGoalDate";
            this.uxGoalDate.Size = new System.Drawing.Size(246, 22);
            this.uxGoalDate.TabIndex = 14;
            this.uxGoalDate.ValueChanged += new System.EventHandler(this.checkGoalButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(852, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Goal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Goal Description";
            // 
            // uxGoalDescriptionBox
            // 
            this.uxGoalDescriptionBox.Location = new System.Drawing.Point(971, 612);
            this.uxGoalDescriptionBox.Multiline = true;
            this.uxGoalDescriptionBox.Name = "uxGoalDescriptionBox";
            this.uxGoalDescriptionBox.Size = new System.Drawing.Size(243, 42);
            this.uxGoalDescriptionBox.TabIndex = 11;
            this.uxGoalDescriptionBox.TextChanged += new System.EventHandler(this.checkGoalButton);
            // 
            // uxGoalAmountBox
            // 
            this.uxGoalAmountBox.Location = new System.Drawing.Point(958, 581);
            this.uxGoalAmountBox.Name = "uxGoalAmountBox";
            this.uxGoalAmountBox.Size = new System.Drawing.Size(100, 22);
            this.uxGoalAmountBox.TabIndex = 10;
            this.uxGoalAmountBox.TextChanged += new System.EventHandler(this.checkGoalButton);
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMonthLabel.Location = new System.Drawing.Point(860, 32);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(79, 29);
            this.uxMonthLabel.TabIndex = 16;
            this.uxMonthLabel.Text = "Month";
            // 
            // uxLossLabel
            // 
            this.uxLossLabel.AutoSize = true;
            this.uxLossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLossLabel.ForeColor = System.Drawing.Color.Red;
            this.uxLossLabel.Location = new System.Drawing.Point(610, 592);
            this.uxLossLabel.Name = "uxLossLabel";
            this.uxLossLabel.Size = new System.Drawing.Size(60, 25);
            this.uxLossLabel.TabIndex = 17;
            this.uxLossLabel.Text = "Loss:";
            // 
            // uxGainLabel
            // 
            this.uxGainLabel.AutoSize = true;
            this.uxGainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uxGainLabel.Location = new System.Drawing.Point(610, 629);
            this.uxGainLabel.Name = "uxGainLabel";
            this.uxGainLabel.Size = new System.Drawing.Size(59, 25);
            this.uxGainLabel.TabIndex = 18;
            this.uxGainLabel.Text = "Gain:";
            // 
            // uxLossAmountLabel
            // 
            this.uxLossAmountLabel.AutoSize = true;
            this.uxLossAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLossAmountLabel.ForeColor = System.Drawing.Color.Red;
            this.uxLossAmountLabel.Location = new System.Drawing.Point(676, 592);
            this.uxLossAmountLabel.Name = "uxLossAmountLabel";
            this.uxLossAmountLabel.Size = new System.Drawing.Size(64, 25);
            this.uxLossAmountLabel.TabIndex = 19;
            this.uxLossAmountLabel.Text = "label3";
            // 
            // uxGainAmountLabel
            // 
            this.uxGainAmountLabel.AutoSize = true;
            this.uxGainAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGainAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uxGainAmountLabel.Location = new System.Drawing.Point(676, 629);
            this.uxGainAmountLabel.Name = "uxGainAmountLabel";
            this.uxGainAmountLabel.Size = new System.Drawing.Size(64, 25);
            this.uxGainAmountLabel.TabIndex = 20;
            this.uxGainAmountLabel.Text = "label4";
            // 
            // uxGoalsHeadingLabel
            // 
            this.uxGoalsHeadingLabel.AutoSize = true;
            this.uxGoalsHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGoalsHeadingLabel.Location = new System.Drawing.Point(860, 131);
            this.uxGoalsHeadingLabel.Name = "uxGoalsHeadingLabel";
            this.uxGoalsHeadingLabel.Size = new System.Drawing.Size(63, 25);
            this.uxGoalsHeadingLabel.TabIndex = 21;
            this.uxGoalsHeadingLabel.Text = "Goals";
            // 
            // uxGoalsLabel
            // 
            this.uxGoalsLabel.AutoSize = true;
            this.uxGoalsLabel.Location = new System.Drawing.Point(876, 162);
            this.uxGoalsLabel.Name = "uxGoalsLabel";
            this.uxGoalsLabel.Size = new System.Drawing.Size(43, 17);
            this.uxGoalsLabel.TabIndex = 22;
            this.uxGoalsLabel.Text = "goal1";
            // 
            // uxTransactionRemoveButton
            // 
            this.uxTransactionRemoveButton.Enabled = false;
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
            this.uxGoalDateLabel.Location = new System.Drawing.Point(852, 650);
            this.uxGoalDateLabel.Name = "uxGoalDateLabel";
            this.uxGoalDateLabel.Size = new System.Drawing.Size(72, 17);
            this.uxGoalDateLabel.TabIndex = 29;
            this.uxGoalDateLabel.Text = "Goal Date";
            // 
            // NetLabel
            // 
            this.NetLabel.AutoSize = true;
            this.NetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLabel.Location = new System.Drawing.Point(610, 671);
            this.NetLabel.Name = "NetLabel";
            this.NetLabel.Size = new System.Drawing.Size(48, 25);
            this.NetLabel.TabIndex = 30;
            this.NetLabel.Text = "Net:";
            // 
            // uxNetAmountLabel
            // 
            this.uxNetAmountLabel.AutoSize = true;
            this.uxNetAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNetAmountLabel.Location = new System.Drawing.Point(676, 671);
            this.uxNetAmountLabel.Name = "uxNetAmountLabel";
            this.uxNetAmountLabel.Size = new System.Drawing.Size(64, 25);
            this.uxNetAmountLabel.TabIndex = 31;
            this.uxNetAmountLabel.Text = "label4";
            // 
            // uxViewGoalsButton
            // 
            this.uxViewGoalsButton.Location = new System.Drawing.Point(861, 549);
            this.uxViewGoalsButton.Name = "uxViewGoalsButton";
            this.uxViewGoalsButton.Size = new System.Drawing.Size(353, 23);
            this.uxViewGoalsButton.TabIndex = 32;
            this.uxViewGoalsButton.Text = "View All Goals";
            this.uxViewGoalsButton.UseVisualStyleBackColor = true;
            this.uxViewGoalsButton.Click += new System.EventHandler(this.uxViewGoalsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 722);
            this.Controls.Add(this.uxViewGoalsButton);
            this.Controls.Add(this.uxNetAmountLabel);
            this.Controls.Add(this.NetLabel);
            this.Controls.Add(this.uxGoalDateLabel);
            this.Controls.Add(this.uxCatagoryLabel);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxCatagoryPicker);
            this.Controls.Add(this.uxTransactionRemoveButton);
            this.Controls.Add(this.uxGoalsLabel);
            this.Controls.Add(this.uxGoalsHeadingLabel);
            this.Controls.Add(this.uxGainAmountLabel);
            this.Controls.Add(this.uxLossAmountLabel);
            this.Controls.Add(this.uxGainLabel);
            this.Controls.Add(this.uxLossLabel);
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
        private System.Windows.Forms.ToolStripMenuItem gainLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxLoginToolStripMenuItem;
        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.Label uxLossLabel;
        private System.Windows.Forms.Label uxGainLabel;
        private System.Windows.Forms.Label uxLossAmountLabel;
        private System.Windows.Forms.Label uxGainAmountLabel;
        private System.Windows.Forms.Label uxGoalsHeadingLabel;
        private System.Windows.Forms.Label uxGoalsLabel;
        private System.Windows.Forms.Button uxTransactionRemoveButton;
        private System.Windows.Forms.ComboBox uxCatagoryPicker;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.Label uxCatagoryLabel;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Label uxGoalDateLabel;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Label NetLabel;
        private System.Windows.Forms.Label uxNetAmountLabel;
        private System.Windows.Forms.ToolStripMenuItem sheduledTransactionsToolStripMenuItem;
        private System.Windows.Forms.Button uxViewGoalsButton;
    }
}

