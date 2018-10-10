namespace MoneyManager
{
    partial class SearchForm
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
            this.uxSearchListView = new System.Windows.Forms.ListView();
            this.uxStartDateSearch = new System.Windows.Forms.DateTimePicker();
            this.uxEndDateSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.uxAmountSearchBox = new System.Windows.Forms.TextBox();
            this.uxKeywordSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxBelowCheckBox = new System.Windows.Forms.CheckBox();
            this.uxAboveCheckBox = new System.Windows.Forms.CheckBox();
            this.uxRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxCatagorySearchBox = new System.Windows.Forms.TextBox();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxSearchListView
            // 
            this.uxSearchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.Date,
            this.Description,
            this.Category});
            this.uxSearchListView.GridLines = true;
            this.uxSearchListView.Location = new System.Drawing.Point(34, 314);
            this.uxSearchListView.Name = "uxSearchListView";
            this.uxSearchListView.Size = new System.Drawing.Size(718, 97);
            this.uxSearchListView.TabIndex = 0;
            this.uxSearchListView.UseCompatibleStateImageBehavior = false;
            this.uxSearchListView.View = System.Windows.Forms.View.Details;
            // 
            // uxStartDateSearch
            // 
            this.uxStartDateSearch.Location = new System.Drawing.Point(34, 207);
            this.uxStartDateSearch.Name = "uxStartDateSearch";
            this.uxStartDateSearch.Size = new System.Drawing.Size(200, 22);
            this.uxStartDateSearch.TabIndex = 1;
            // 
            // uxEndDateSearch
            // 
            this.uxEndDateSearch.Location = new System.Drawing.Point(343, 207);
            this.uxEndDateSearch.Name = "uxEndDateSearch";
            this.uxEndDateSearch.Size = new System.Drawing.Size(200, 22);
            this.uxEndDateSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by amount";
            // 
            // uxAmountSearchBox
            // 
            this.uxAmountSearchBox.Location = new System.Drawing.Point(170, 13);
            this.uxAmountSearchBox.Name = "uxAmountSearchBox";
            this.uxAmountSearchBox.Size = new System.Drawing.Size(100, 22);
            this.uxAmountSearchBox.TabIndex = 4;
            // 
            // uxKeywordSearchBox
            // 
            this.uxKeywordSearchBox.Location = new System.Drawing.Point(170, 42);
            this.uxKeywordSearchBox.Name = "uxKeywordSearchBox";
            this.uxKeywordSearchBox.Size = new System.Drawing.Size(100, 22);
            this.uxKeywordSearchBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by keyword";
            // 
            // uxBelowCheckBox
            // 
            this.uxBelowCheckBox.AutoSize = true;
            this.uxBelowCheckBox.Location = new System.Drawing.Point(343, 13);
            this.uxBelowCheckBox.Name = "uxBelowCheckBox";
            this.uxBelowCheckBox.Size = new System.Drawing.Size(67, 21);
            this.uxBelowCheckBox.TabIndex = 7;
            this.uxBelowCheckBox.Text = "Below";
            this.uxBelowCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxAboveCheckBox
            // 
            this.uxAboveCheckBox.AutoSize = true;
            this.uxAboveCheckBox.Location = new System.Drawing.Point(465, 13);
            this.uxAboveCheckBox.Name = "uxAboveCheckBox";
            this.uxAboveCheckBox.Size = new System.Drawing.Size(70, 21);
            this.uxAboveCheckBox.TabIndex = 8;
            this.uxAboveCheckBox.Text = "Above";
            this.uxAboveCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxRangeCheckBox
            // 
            this.uxRangeCheckBox.AutoSize = true;
            this.uxRangeCheckBox.Location = new System.Drawing.Point(553, 13);
            this.uxRangeCheckBox.Name = "uxRangeCheckBox";
            this.uxRangeCheckBox.Size = new System.Drawing.Size(72, 21);
            this.uxRangeCheckBox.TabIndex = 9;
            this.uxRangeCheckBox.Text = "Range";
            this.uxRangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(652, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search by Catagory";
            // 
            // uxCatagorySearchBox
            // 
            this.uxCatagorySearchBox.Location = new System.Drawing.Point(186, 78);
            this.uxCatagorySearchBox.Name = "uxCatagorySearchBox";
            this.uxCatagorySearchBox.Size = new System.Drawing.Size(100, 22);
            this.uxCatagorySearchBox.TabIndex = 14;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // Category
            // 
            this.Category.Text = "Category";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxCatagorySearchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.uxRangeCheckBox);
            this.Controls.Add(this.uxAboveCheckBox);
            this.Controls.Add(this.uxBelowCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxKeywordSearchBox);
            this.Controls.Add(this.uxAmountSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxEndDateSearch);
            this.Controls.Add(this.uxStartDateSearch);
            this.Controls.Add(this.uxSearchListView);
            this.Name = "SearchForm";
            this.Text = "text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxSearchListView;
        private System.Windows.Forms.DateTimePicker uxStartDateSearch;
        private System.Windows.Forms.DateTimePicker uxEndDateSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxAmountSearchBox;
        private System.Windows.Forms.TextBox uxKeywordSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox uxBelowCheckBox;
        private System.Windows.Forms.CheckBox uxAboveCheckBox;
        private System.Windows.Forms.CheckBox uxRangeCheckBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxCatagorySearchBox;
    }
}