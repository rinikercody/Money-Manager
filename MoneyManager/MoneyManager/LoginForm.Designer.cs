namespace MoneyManager
{
    partial class LoginForm
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
            this.uxLoginUsernameBox = new System.Windows.Forms.TextBox();
            this.uxLoginLabel = new System.Windows.Forms.Label();
            this.uxSignUpLabel = new System.Windows.Forms.Label();
            this.uxLoginPasswordBox = new System.Windows.Forms.TextBox();
            this.uxSignUpNameBox = new System.Windows.Forms.TextBox();
            this.uxSignUpPasswordBox = new System.Windows.Forms.TextBox();
            this.uxLoginUserNameLabel = new System.Windows.Forms.Label();
            this.uxLoginPasswordLabel = new System.Windows.Forms.Label();
            this.uxSignUpUsernameLabel = new System.Windows.Forms.Label();
            this.uxSignUpPasswordLabel = new System.Windows.Forms.Label();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.uxSignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLoginUsernameBox
            // 
            this.uxLoginUsernameBox.BackColor = System.Drawing.SystemColors.Window;
            this.uxLoginUsernameBox.Location = new System.Drawing.Point(110, 35);
            this.uxLoginUsernameBox.Name = "uxLoginUsernameBox";
            this.uxLoginUsernameBox.Size = new System.Drawing.Size(269, 22);
            this.uxLoginUsernameBox.TabIndex = 0;
            // 
            // uxLoginLabel
            // 
            this.uxLoginLabel.AutoSize = true;
            this.uxLoginLabel.Location = new System.Drawing.Point(13, 14);
            this.uxLoginLabel.Name = "uxLoginLabel";
            this.uxLoginLabel.Size = new System.Drawing.Size(43, 17);
            this.uxLoginLabel.TabIndex = 1;
            this.uxLoginLabel.Text = "Login";
            // 
            // uxSignUpLabel
            // 
            this.uxSignUpLabel.AutoSize = true;
            this.uxSignUpLabel.Location = new System.Drawing.Point(13, 144);
            this.uxSignUpLabel.Name = "uxSignUpLabel";
            this.uxSignUpLabel.Size = new System.Drawing.Size(58, 17);
            this.uxSignUpLabel.TabIndex = 2;
            this.uxSignUpLabel.Text = "Sign Up";
            // 
            // uxLoginPasswordBox
            // 
            this.uxLoginPasswordBox.Location = new System.Drawing.Point(110, 63);
            this.uxLoginPasswordBox.Name = "uxLoginPasswordBox";
            this.uxLoginPasswordBox.Size = new System.Drawing.Size(269, 22);
            this.uxLoginPasswordBox.TabIndex = 3;
            // 
            // uxSignUpNameBox
            // 
            this.uxSignUpNameBox.Location = new System.Drawing.Point(110, 164);
            this.uxSignUpNameBox.Name = "uxSignUpNameBox";
            this.uxSignUpNameBox.Size = new System.Drawing.Size(269, 22);
            this.uxSignUpNameBox.TabIndex = 4;
            // 
            // uxSignUpPasswordBox
            // 
            this.uxSignUpPasswordBox.Location = new System.Drawing.Point(110, 192);
            this.uxSignUpPasswordBox.Name = "uxSignUpPasswordBox";
            this.uxSignUpPasswordBox.PasswordChar = '*';
            this.uxSignUpPasswordBox.Size = new System.Drawing.Size(269, 22);
            this.uxSignUpPasswordBox.TabIndex = 5;
            // 
            // uxLoginUserNameLabel
            // 
            this.uxLoginUserNameLabel.AutoSize = true;
            this.uxLoginUserNameLabel.Location = new System.Drawing.Point(23, 38);
            this.uxLoginUserNameLabel.Name = "uxLoginUserNameLabel";
            this.uxLoginUserNameLabel.Size = new System.Drawing.Size(81, 17);
            this.uxLoginUserNameLabel.TabIndex = 6;
            this.uxLoginUserNameLabel.Text = "Username: ";
            // 
            // uxLoginPasswordLabel
            // 
            this.uxLoginPasswordLabel.AutoSize = true;
            this.uxLoginPasswordLabel.Location = new System.Drawing.Point(23, 66);
            this.uxLoginPasswordLabel.Name = "uxLoginPasswordLabel";
            this.uxLoginPasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.uxLoginPasswordLabel.TabIndex = 7;
            this.uxLoginPasswordLabel.Text = "Password";
            // 
            // uxSignUpUsernameLabel
            // 
            this.uxSignUpUsernameLabel.AutoSize = true;
            this.uxSignUpUsernameLabel.Location = new System.Drawing.Point(23, 169);
            this.uxSignUpUsernameLabel.Name = "uxSignUpUsernameLabel";
            this.uxSignUpUsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.uxSignUpUsernameLabel.TabIndex = 8;
            this.uxSignUpUsernameLabel.Text = "Username:";
            // 
            // uxSignUpPasswordLabel
            // 
            this.uxSignUpPasswordLabel.AutoSize = true;
            this.uxSignUpPasswordLabel.Location = new System.Drawing.Point(23, 195);
            this.uxSignUpPasswordLabel.Name = "uxSignUpPasswordLabel";
            this.uxSignUpPasswordLabel.Size = new System.Drawing.Size(77, 17);
            this.uxSignUpPasswordLabel.TabIndex = 9;
            this.uxSignUpPasswordLabel.Text = "Password: ";
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(169, 107);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(144, 33);
            this.uxLoginButton.TabIndex = 10;
            this.uxLoginButton.Text = "Log In";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // uxSignUpButton
            // 
            this.uxSignUpButton.Location = new System.Drawing.Point(169, 222);
            this.uxSignUpButton.Name = "uxSignUpButton";
            this.uxSignUpButton.Size = new System.Drawing.Size(144, 40);
            this.uxSignUpButton.TabIndex = 11;
            this.uxSignUpButton.Text = "Create Account";
            this.uxSignUpButton.UseVisualStyleBackColor = true;
            this.uxSignUpButton.Click += new System.EventHandler(this.uxSignUpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(467, 274);
            this.Controls.Add(this.uxSignUpButton);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxSignUpPasswordLabel);
            this.Controls.Add(this.uxSignUpUsernameLabel);
            this.Controls.Add(this.uxLoginPasswordLabel);
            this.Controls.Add(this.uxLoginUserNameLabel);
            this.Controls.Add(this.uxSignUpPasswordBox);
            this.Controls.Add(this.uxSignUpNameBox);
            this.Controls.Add(this.uxLoginPasswordBox);
            this.Controls.Add(this.uxSignUpLabel);
            this.Controls.Add(this.uxLoginLabel);
            this.Controls.Add(this.uxLoginUsernameBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxLoginUsernameBox;
        private System.Windows.Forms.Label uxLoginLabel;
        private System.Windows.Forms.Label uxSignUpLabel;
        private System.Windows.Forms.TextBox uxLoginPasswordBox;
        private System.Windows.Forms.TextBox uxSignUpNameBox;
        private System.Windows.Forms.TextBox uxSignUpPasswordBox;
        private System.Windows.Forms.Label uxLoginUserNameLabel;
        private System.Windows.Forms.Label uxLoginPasswordLabel;
        private System.Windows.Forms.Label uxSignUpUsernameLabel;
        private System.Windows.Forms.Label uxSignUpPasswordLabel;
        private System.Windows.Forms.Button uxLoginButton;
        private System.Windows.Forms.Button uxSignUpButton;
    }
}