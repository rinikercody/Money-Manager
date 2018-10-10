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
using System.IO;
//ffuts
//Save everytime but only open once.
//Handle when no user is loged in vs loged in
namespace MoneyManager
{
    public partial class MainForm : Form
    {
        private static string _dbPath = "Data Source=C:\\Users\\rinik\\desktop\\Senior Project\\MoneyManagerDB.db";
        private SQLiteConnection _db = new SQLiteConnection(_dbPath); //Put file path here, might not make this global

        private List<string> _userGoals = new List<string>();
        private List<string> _userTransactions = new List<string>();

        private string _pathToUsers = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Transactions\\";
        private string _pathToGoals = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Goals\\";

        private int _id = 0;
        public MainForm()
        {
            InitializeComponent();
            uxTransactionAddButton.Enabled = false;
            getTransactionInfo("Cody2");
            _db.Open();
            /*
            DateTime dt = new DateTime(2018,5,8,13,30,52);
            DateTime dt2 = new DateTime(2018, 5, 1, 13, 30, 52);
            MessageBox.Show((dt - dt2).ToString());
            */
        }

        public void updateDisplay(int id, double amount, string description, string date, string catagory)
        {
            ListViewItem item = new ListViewItem();
            item.Text = amount.ToString(); //First column of list view is set to amount
            item.SubItems.Add(date);
            item.SubItems.Add(description);
            item.SubItems.Add(catagory);
            item.SubItems.Add(id.ToString());

            if (amount < 0)
            {
                item.ForeColor = Color.Red;
            }
            if(amount > 0)
            {
                item.ForeColor = Color.Green;
            }
            uxTransactionsListView.Items.Add(item);
            //Save here
        }
        //stuff
        public void connectToDataBase(string path)
        {
            //Open connection to database. //This method might be removed If the database isnt global
        }

        public void getTransactionInfo(string username)
        {
            if (File.Exists(_pathToUsers + username))
            {
                string[] info = new string[10];
                using (StreamReader sr = new StreamReader(_pathToUsers + username)) //mabey add .txt
                {
                    while (!sr.EndOfStream)
                    {
                        string rawTransactionInfo = sr.ReadLine();
                        _userTransactions.Add(rawTransactionInfo);
                        info = rawTransactionInfo.Split(',');

                        //MIGHT MOVE AN MAKE MORE SAVE WITH CONVERTING like after reading in
                        //MessageBox.Show(info[4]);
                        updateDisplay(Convert.ToInt32(info[0]), Convert.ToDouble(info[1]), info[2], info[3], info[4]);
                    }
                }
                _id = _userTransactions.Count;
            }
        }


      
        public void getGoals(string username)
        {
            if (File.Exists(_pathToGoals + username))
            {
                using (StreamReader sr = new StreamReader(_pathToGoals + username)) //mabey add .txt
                {
                    while (!sr.EndOfStream)
                    {
                        _userTransactions.Add(sr.ReadLine());
                    }
                }
            }
        }

        public void addGoal()
        {
            //add a new goal
            //Update display after

        }

        public void removeGoal()
        {

        }

        public void addScheduledTransaction(string date, double amount)
        {
            //Add a new scheduledTransaction
            //Transaction Id will be generated here
        }

        public void removeScheduledTransaction(string username, int transactionId)
        {
            //Remove a transaction.
        }

        public void takeOutSheduledTransaction(string username)
        {
            //This will take out a scheduled transaction when the user logs in if the scheduled date has paseed.
            //A mysql database might fix this problem but this works for now.
        }

        private void uxTransactionAddButton_Click(object sender, EventArgs e)
        {
            int id = _id;
            _id++; //Be carful with this id.
            double amount = Convert.ToDouble(uxAddAmountBox.Text);
            string description = uxAddDescriptionBox.Text;
            string date = uxDateAddTransaction.Value.ToString();
            string catagory = uxCatagoryPicker.Text;
            //MessageBox.Show(catagory);
            updateDisplay(id, amount, description, date, catagory);

            //SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO test VALUES(9);",_db);
            //insertCommand.ExecuteNonQuery();

            string saveInfo = id + "," + amount + "," + description + "," + date + "," + catagory;

            saveTransactionInfo("Cody2",saveInfo);

        }

        //KEEP ABSOLUTLY ALL SAVING TO OUTSIDE SOURCES IN THIS FUNCTION
        //WILL HELP LATER IF I WANT TO CHANGE HOW I STORE DATA
        private void saveTransactionInfo(string username, string info)
        {
            string filepath = _pathToUsers + username;
            //Might change to sql database

            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(info);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(info);
                }
            }
        }

        
        private void uxSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uxTransactionRemoveButton_Click(object sender, EventArgs e)
        {
            //Get transaction id then delete it from the text file and load it back in after
        }

        private void uxLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            if(lf.ShowDialog() == DialogResult.OK)
            {
                //Check if user is in database or ok to log in.
            }
        }

        private void uxAddAmountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxAddAmountBox.Text);
                uxTransactionAddButton.Enabled = true;
            }
            catch(Exception ex)
            {
                uxTransactionAddButton.Enabled = false;
            }
        }

        private void uxAddGoalButton_Click(object sender, EventArgs e)
        {
            
        }

        //Used to check if goal inputs are in correct format
        private void checkGoalButton(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxGoalAmountBox.Text);
                uxAddGoalButton.Enabled = true;
                if (uxGoalDescriptionBox.Text.Length > 0)
                {
                    uxAddGoalButton.Enabled = true;
                    TimeSpan ts = new TimeSpan(6,0,0,0); //A little less than a week
                    //MessageBox.Show(ts.ToString());
                    //MessageBox.Show((uxGoalDate.Value - DateTime.Now).ToString());
                    if (uxGoalDate.Value - DateTime.Now > ts){ //Check if goal is at least a week away
                        uxAddGoalButton.Enabled = true;
                    }
                    else
                    {
                        uxAddGoalButton.Enabled = false;
                    }
                }
                else
                {
                    uxAddGoalButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                uxAddGoalButton.Enabled = false;
            }
        }

       
    } //End class
} //End namespace

