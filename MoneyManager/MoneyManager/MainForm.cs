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
    //Need to handle sorting transactions like by earilest date when put in later
    public partial class MainForm : Form
    {
        private static string _dbPath = "Data Source=C:\\Users\\rinik\\desktop\\Senior Project\\MoneyManagerDB.db";
        private SQLiteConnection _db = new SQLiteConnection(_dbPath); //Put file path here, might not make this global

        private List<string> _userGoals = new List<string>();
        private List<string> _userTransactions = new List<string>();

        private string _pathToUsers = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Transactions\\";
        private string _pathToGoals = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Goals\\";

        private int _transactionCount = 0;

        public MainForm()
        {
            InitializeComponent();
            uxTransactionAddButton.Enabled = false;

            //Manage schedule transaction here then update user_transactions
            getTransactionInfo("Cody2");
            loadGoals("Cody2");
            _db.Open();
        }

        public void updateDisplay()
        {
            uxTransactionsListView.Items.Clear();
            for (int i = 0; i < _userTransactions.Count; i++)
            {
                string[] info = _userTransactions[i].Split(',');

                //Transaction update
                ListViewItem item = new ListViewItem();
                double amount = Convert.ToDouble(info[1]);
                item.Text = amount.ToString("c"); //First column of list view is set to amount
                item.SubItems.Add(info[3]); //Date
                item.SubItems.Add(info[2]); //Description
                item.SubItems.Add(info[4]); //Catagory
                item.SubItems.Add(info[0]); //Id

                if (amount < 0)
                {
                    item.ForeColor = Color.Red;
                }
                if (amount > 0)
                {
                    item.ForeColor = Color.Green;
                }
                uxTransactionsListView.Items.Add(item);
            }
            //Goals and other stuff update
            uxMonthLabel.Text = getMonth(DateTime.Now.Month);
            //uxGainAmountLabel
            DateTime dt1 = new DateTime(2018, 10, 1, 13, 30, 52); //year,month,day,hour,min,sec
            DateTime dt2 = new DateTime(2018, 11, 8, 13, 30, 52);
            double [] gl = getBasicGainLoss(dt1, dt2);
           
            uxLossAmountLabel.Text = gl[0].ToString();
            uxGainAmountLabel.Text = gl[1].ToString();
            double netAmount = gl[1] + gl[0];
            uxNetAmountLabel.Text = netAmount.ToString();
            if(netAmount < 0)
            {
                NetLabel.ForeColor = Color.Red;
                uxNetAmountLabel.ForeColor = Color.Red;
            }
            else
            {
                NetLabel.ForeColor = Color.Green;
                uxNetAmountLabel.ForeColor = Color.Green;
            }
            updateGoals();
        }

        public double[] getBasicGainLoss(DateTime dt1, DateTime dt2)
        {
            double[] gl = new double[2];
            gl[0] = 0;
            gl[1] = 0;

            for(int i = 0; i < _userTransactions.Count; i++)
            {
                string [] info = _userTransactions[i].Split(',');
                DateTime dt3 = Convert.ToDateTime(info[3]);
                if(dt3 > dt1 && dt3 < dt2)
                {
                    double d = Convert.ToDouble(info[1]);
                    if(d < 0)
                    {
                        gl[0] += d;
                    }
                    if(d > 0)
                    {
                        gl[1] += d;
                    }
                }
            }
            return gl;
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
                        updateDisplay();
                    }
                }
                _transactionCount = _userTransactions.Count;
            }
        }

        public string getMonth(int number)
        {
            switch (number)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "NA";
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

        private void uxTransactionAddButton_Click(object sender, EventArgs e)
        {
            int id = _userTransactions.Count;
            double amount = Convert.ToDouble(uxAddAmountBox.Text);
            string description = uxAddDescriptionBox.Text;
            string date = uxDateAddTransaction.Value.ToString();
            DateTime dt = uxDateAddTransaction.Value;
            string catagory = uxCatagoryPicker.Text;

            //SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO test VALUES(9);",_db);
            //insertCommand.ExecuteNonQuery();

            string saveInfo = id + "," + amount + "," + description + "," + date + "," + catagory;
            
            if(_userTransactions.Count == 0)
            {
                _userTransactions.Add(saveInfo);
            }
            else if (dt > Convert.ToDateTime(_userTransactions[_userTransactions.Count - 1].Split(',')[3]))
            {
                _userTransactions.Add(saveInfo);
            }
            else
            {
                List<string> tempList = new List<string>();
                for (int i = 0; i < _userTransactions.Count; i++)
                {
                    if (dt < Convert.ToDateTime(_userTransactions[i].Split(',')[3]))
                    {
                        for (int j = 0; j < i; j++)
                        {
                            tempList.Add(_userTransactions[j]);
                        }

                        tempList.Add(saveInfo);

                        for (int j = i; j < _userTransactions.Count; j++)
                        {
                            tempList.Add(_userTransactions[j]);
                        }
                        break;
                    }
                }
                _userTransactions = tempList;
            }
            
            saveTransactionInfo("Cody2");
            updateDisplay();
        }

        //KEEP ABSOLUTLY ALL SAVING TO OUTSIDE SOURCES IN THIS FUNCTION
        //WILL HELP LATER IF I WANT TO CHANGE HOW I STORE DATA
        private void saveTransactionInfo(string username)
        {
            string filepath = _pathToUsers + username;
            //Might change to sql database

            using (StreamWriter sw = File.CreateText(filepath))
            {
                for (int i = 0; i < _userTransactions.Count; i++)
                {
                    sw.WriteLine(_userTransactions[i]);
                }
            }
            
        }

        
        private void uxSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(_userTransactions);
            sf.ShowDialog();
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
            double amount = Convert.ToDouble(uxGoalAmountBox.Text);
            string description = uxGoalDescriptionBox.Text;

            DateTime goalDate = uxGoalDate.Value;
            TimeSpan tsp = new TimeSpan(10, 0, 0, 0);

            _userGoals.Add(amount + "," + description + "," + goalDate.ToString());
            saveGoals("Cody2");
            updateGoals();

            /*
            if (goalDate - DateTime.Now < tsp)
            {
                uxGoal1DescriptionLabel.ForeColor = Color.Orange;
                uxGoal1AmountDateLabel.ForeColor = Color.Orange;
            }

            uxGoal1DescriptionLabel.Text = description;
            uxGoal1AmountDateLabel.Text = amount.ToString("c") + goalDate.ToString();
            */
        }

        private void loadGoals(string username)
        {
            if (File.Exists(_pathToGoals + username))
            {
                using (StreamReader sr = new StreamReader(_pathToGoals + username))
                {
                    _userGoals.Add(sr.ReadLine());
                }
            }
        }

        private void saveGoals(string username)
        {
            using (StreamWriter sw  = new StreamWriter(_pathToGoals + username))
            {
                for(int i = 0; i < _userGoals.Count; i++)
                {
                    sw.WriteLine(_userGoals[i]);
                }
            }
        }

        private void updateGoals()
        {
            uxGoalsLabel.Text = "";
            uxGoalsLabel.ForeColor = Color.Blue;
            for (int i = 0; i < 5 && i < _userGoals.Count; i++)
            {
                string [] info = _userGoals[i].Split(',');
                uxGoalsLabel.Text += "Goal " + (i+1) + ":\n";
                uxGoalsLabel.Text += "Amount: " + info[0] + "\n";
                uxGoalsLabel.Text += "Description: " + _userGoals[1] + "\n";
                uxGoalsLabel.Text += "By: " + info[2] + "\n\n";
            }
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

        private void sheduledTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTransactionForm stf = new ScheduleTransactionForm();
            stf.Show();
        }

        private void uxViewGoalsButton_Click(object sender, EventArgs e)
        {
            GoalsForm gf = new GoalsForm(_userGoals);
            gf.Show();
        }
    } //End class
} //End namespace

