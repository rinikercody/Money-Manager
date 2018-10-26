namespace MoneyManager
{
    partial class GainLossForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.uxGainLoseListView = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Net = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(457, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gain/loss";
            // 
            // uxGainLoseListView
            // 
            this.uxGainLoseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.Gain,
            this.Loss,
            this.Net});
            this.uxGainLoseListView.GridLines = true;
            this.uxGainLoseListView.Location = new System.Drawing.Point(16, 282);
            this.uxGainLoseListView.Name = "uxGainLoseListView";
            this.uxGainLoseListView.Size = new System.Drawing.Size(757, 164);
            this.uxGainLoseListView.TabIndex = 3;
            this.uxGainLoseListView.UseCompatibleStateImageBehavior = false;
            this.uxGainLoseListView.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.Text = "Catergory";
            // 
            // Gain
            // 
            this.Gain.Text = "Gain";
            // 
            // Loss
            // 
            this.Loss.Text = "Loss";
            // 
            // Net
            // 
            this.Net.Text = "Net";
            // 
            // GainLossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.uxGainLoseListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "GainLossForm";
            this.Text = "GainLossForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView uxGainLoseListView;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Gain;
        private System.Windows.Forms.ColumnHeader Loss;
        private System.Windows.Forms.ColumnHeader Net;
    }
}