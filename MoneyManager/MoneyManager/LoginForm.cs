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
            if(results.Read())
            {
                MessageBox.Show(results.GetString(0));
                Username = results.GetString(0);
                Password = results.GetString(1);
                _db.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show("Incorrect username and password.");

            
        }

        /// <summary>
        /// For new users who want to create an account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSignUpButton_Click(object sender, EventArgs e)
        {
            //NEED TO GET WORKING
            //Create users in text file database
            string username = uxLoginUsernameBox.Text;
            string password = uxLoginPasswordBox.Text;
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
                Username = username;
                Password = password;
                _db.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
