using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MoneyManager
{
    public partial class LoginForm : Form
    {
        
        /// <summary>
        /// Creates a new LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            uxLoginPasswordBox.PasswordChar = '*';
        }

        /// <summary>
        /// Stores the username of the person that loged in.
        /// </summary>
        public string Username{get;set;}

        

        /// <summary>
        /// For current users that want to login into there account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            string username = uxLoginUsernameBox.Text;
            string password = uxLoginPasswordBox.Text;
            byte[] p = File.ReadAllBytes("User_Manafest");
            string temp = Encrypter.Decrypt(p,5);
            string[] arr = temp.Split('\n');
            bool found = false;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Length > 5)
                {
                    string[] info = arr[i].Split(',');
                    if (info[0] == username && info[1] == password)
                    {
                        Username = username;
                        found = true;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
            }
            if (!found)
            {
                MessageBox.Show("Username and password not found.");
            }
        }

        /// <summary>
        /// For new users who want to create an account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSignUpButton_Click(object sender, EventArgs e)
        {
            //Create users in text file database
            string username = uxSignUpNameBox.Text;
            string password = uxSignUpPasswordBox.Text;
            byte[] bytes = File.ReadAllBytes("User_Manafest");

            if (username.Length > 2 && username.Length < 16) {
                if (checkPasswordReqirements(password))
                {
                    bool usernameCheck = true;
                    string temp = Encrypter.Decrypt(bytes,5);
                    string[] arr = temp.Split('\n');
                    for(int i = 0; i < arr.Length - 1; i++)
                    {
                        string[] info = arr[i].Split(',');
                        if(info[0] == username)
                        {
                            usernameCheck = false;
                        }
                    }
                    if (usernameCheck)
                    {
                        string info = username +"," + password + "\n";

                        byte[] newBytes = Encrypter.Encrypt(info,5);
                       

                        using (var stream = new FileStream("User_Manafest", FileMode.Append))
                        {
                            stream.Write(newBytes, 0, newBytes.Length);
                        }

                       
                        
                        Username = username;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The username you entered is already taken.");
                    }
                 
                }
                else
                {
                    MessageBox.Show("Invalid password. \nPassword must be at least 7 characters long and contain at least 1 uppercase letters.\nThe only other characters that are allowed are ! @ # $ ?");
                }
            }
            else
            {
                MessageBox.Show("Username must be at least 3 characters long and at most 15 characters long.");
            }
        }

      
        /// <summary>
        /// Checks to see if password is at least 7 characters long, has at least one uppercase letter and dosn't contain any banned characters.
        /// </summary>
        /// <param name="password">The password that is being checked</param>
        /// <returns>True if the password is ok and false if there something wrong with it.</returns>
        private bool checkPasswordReqirements(string password)
        {
            bool check = false;
            if (password.Length > 6) check = true;
            else return false;

            check = false;
            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i])) check = true;
            }
            if (check == false) return false;

            check = true;
            char[] badSymbols = { '%', '^', '&', '*', '(', ')', '<', '>', '~', '"', '\'', '\t', '\n' };
            for(int i = 0; i < password.Length; i++)
            {
                for(int j = 0; j < badSymbols.Length; j++)
                {
                    if (password[i] == badSymbols[j]) return false;
                }
            }

            return true;
        }
    }
}
