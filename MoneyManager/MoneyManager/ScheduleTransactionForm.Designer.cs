﻿namespace MoneyManager
{
    partial class ScheduleTransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxAmountBox = new System.Windows.Forms.TextBox();
            this.uxCategoryPicker = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.uxAddScheduledTransaction = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.uxDescriptionBox = new System.Windows.Forms.TextBox();
            this.uxScheduledTransactionListView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TakenOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxRemoveTransactionButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxFrequencyMonths = new System.Windows.Forms.TextBox();
            this.uxFrequencyWeeks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // uxAmountBox
            // 
            this.uxAmountBox.Location = new System.Drawing.Point(102, 14);
            this.uxAmountBox.Name = "uxAmountBox";
            this.uxAmountBox.Size = new System.Drawing.Size(353, 22);
            this.uxAmountBox.TabIndex = 1;
            this.uxAmountBox.TextChanged += new System.EventHandler(this.uxFrequencyWeeks_TextChanged);
            // 
            // uxCategoryPicker
            // 
            this.uxCategoryPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCategoryPicker.FormattingEnabled = true;
            this.uxCategoryPicker.Items.AddRange(new object[] {
            "Bill",
            "Car/Gas",
            "Paid",
            "Clothes",
            "Online",
            "Food",
            "Other"});
            this.uxCategoryPicker.Location = new System.Drawing.Point(102, 82);
            this.uxCategoryPicker.Name = "uxCategoryPicker";
            this.uxCategoryPicker.Size = new System.Drawing.Size(353, 24);
            this.uxCategoryPicker.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category:";
            // 
            // uxStartDate
            // 
            this.uxStartDate.Location = new System.Drawing.Point(102, 112);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(353, 22);
            this.uxStartDate.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Start Date:";
            // 
            // uxAddScheduledTransaction
            // 
            this.uxAddScheduledTransaction.Enabled = false;
            this.uxAddScheduledTransaction.Location = new System.Drawing.Point(12, 281);
            this.uxAddScheduledTransaction.Name = "uxAddScheduledTransaction";
            this.uxAddScheduledTransaction.Size = new System.Drawing.Size(443, 23);
            this.uxAddScheduledTransaction.TabIndex = 38;
            this.uxAddScheduledTransaction.Text = "Add Scheduled Transaction";
            this.uxAddScheduledTransaction.UseVisualStyleBackColor = true;
            this.uxAddScheduledTransaction.Click += new System.EventHandler(this.uxAddScheduledTransaction_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Description:";
            // 
            // uxDescriptionBox
            // 
            this.uxDescriptionBox.Location = new System.Drawing.Point(102, 42);
            this.uxDescriptionBox.Name = "uxDescriptionBox";
            this.uxDescriptionBox.Size = new System.Drawing.Size(353, 22);
            this.uxDescriptionBox.TabIndex = 40;
            // 
            // uxScheduledTransactionListView
            // 
            this.uxScheduledTransactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Amount,
            this.TakenOut,
            this.columnHeader,
            this.columnHeader1});
            this.uxScheduledTransactionListView.GridLines = true;
            this.uxScheduledTransactionListView.Location = new System.Drawing.Point(461, 8);
            this.uxScheduledTransactionListView.Name = "uxScheduledTransactionListView";
            this.uxScheduledTransactionListView.Size = new System.Drawing.Size(912, 430);
            this.uxScheduledTransactionListView.TabIndex = 41;
            this.uxScheduledTransactionListView.UseCompatibleStateImageBehavior = false;
            this.uxScheduledTransactionListView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 99;
            // 
            // TakenOut
            // 
            this.TakenOut.Text = "Taken Out";
            this.TakenOut.Width = 124;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Next Time";
            this.columnHeader.Width = 132;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 432;
            // 
            // uxRemoveTransactionButton
            // 
            this.uxRemoveTransactionButton.Location = new System.Drawing.Point(12, 415);
            this.uxRemoveTransactionButton.Name = "uxRemoveTransactionButton";
            this.uxRemoveTransactionButton.Size = new System.Drawing.Size(148, 23);
            this.uxRemoveTransactionButton.TabIndex = 42;
            this.uxRemoveTransactionButton.Text = "Remove Transaction";
            this.uxRemoveTransactionButton.UseVisualStyleBackColor = true;
            this.uxRemoveTransactionButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Day to take out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Months:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Weeks:";
            // 
            // uxFrequencyMonths
            // 
            this.uxFrequencyMonths.Location = new System.Drawing.Point(102, 178);
            this.uxFrequencyMonths.Name = "uxFrequencyMonths";
            this.uxFrequencyMonths.Size = new System.Drawing.Size(100, 22);
            this.uxFrequencyMonths.TabIndex = 46;
            this.uxFrequencyMonths.TextChanged += new System.EventHandler(this.uxFrequencyWeeks_TextChanged);
            // 
            // uxFrequencyWeeks
            // 
            this.uxFrequencyWeeks.Location = new System.Drawing.Point(102, 206);
            this.uxFrequencyWeeks.Name = "uxFrequencyWeeks";
            this.uxFrequencyWeeks.Size = new System.Drawing.Size(100, 22);
            this.uxFrequencyWeeks.TabIndex = 47;
            this.uxFrequencyWeeks.TextChanged += new System.EventHandler(this.uxFrequencyWeeks_TextChanged);
            // 
            // ScheduleTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 450);
            this.Controls.Add(this.uxFrequencyWeeks);
            this.Controls.Add(this.uxFrequencyMonths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uxRemoveTransactionButton);
            this.Controls.Add(this.uxScheduledTransactionListView);
            this.Controls.Add(this.uxDescriptionBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxAddScheduledTransaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxCategoryPicker);
            this.Controls.Add(this.uxAmountBox);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleTransactionForm";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxAmountBox;
        private System.Windows.Forms.ComboBox uxCategoryPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxAddScheduledTransaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxDescriptionBox;
        private System.Windows.Forms.ListView uxScheduledTransactionListView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader TakenOut;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button uxRemoveTransactionButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxFrequencyMonths;
        private System.Windows.Forms.TextBox uxFrequencyWeeks;
    }
}