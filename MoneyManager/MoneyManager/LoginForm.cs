using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MoneyManager
{
    public partial class LoginForm : Form
    {

        //Path to the main sql database for the program.
        private static string _dbPath = "Data Source=C:\\Users\\rinik\\desktop\\Senior Project\\MoneyManagerDB.db";

        //Connect to database
        private SQLiteConnection _db = new SQLiteConnection(_dbPath); //Put file path here, might not make this global

        /// <summary>
        /// Creates a new LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            uxLoginPasswordBox.PasswordChar = '*';
            _db.Open();
        }

        /// <summary>
        /// Stores the username of the person that loged in.
        /// </summary>
        public string Username{get;set;}

        /// <summary>
        /// The password of the person that tryed to log in.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// For current users that want to login into there account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            string username = uxLoginUsernameBox.Text;
            string password = uxLoginPasswordBox.Text;
            

            //Check for user in database
            string sql = "SELECT * FROM USERS WHERE username ='" + username + "' AND password = '" + password + "';";
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, _db);
            SQLiteDataReader results = sqlCommand.ExecuteReader();
            if (results.Read())
            {
                Username = results.GetString(0);
                Password = results.GetString(1);
                _db.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username and password.");
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


            if (username.Length > 2) {
                if (checkPasswordReqirements(password))
                {
                    string sql = "SELECT * FROM USERS WHERE username = '" + username + "';";
                    SQLiteCommand sqlCommand = new SQLiteCommand(sql, _db);
                    SQLiteDataReader results = sqlCommand.ExecuteReader();
                    if (results.Read())
                    {
                        MessageBox.Show("Username is already taken.");
                    }
                    else
                    {

                        sql = "INSERT INTO USERS VALUES('" + username + "','" + password + "');";
                        sqlCommand = new SQLiteCommand(sql, _db);
                        sqlCommand.ExecuteNonQuery();

                        Username = username;
                        Password = password;
                        _db.Close();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid password. \nPassword must be at least 7 characters long and contain at least 1 uppercase letters.\nThe only other characters that are allowed are ! @ # $ ?");
                }
            }
            else
            {
                MessageBox.Show("Username must be at least 3 characters long.");
            }
        }

      

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
