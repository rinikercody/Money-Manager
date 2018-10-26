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
        private List<string> _scheduledTransactions = new List<string>();

        private string _pathToUsers = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Transactions\\";
        private string _pathToGoals = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Goals\\";
        private string _pathToScheduled = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\Scheduled_Transactions\\";

        private string _username = "Cody2";
        private int _idCount = -1;

        public MainForm()
        {
            InitializeComponent();
            uxTransactionAddButton.Enabled = false;

            //checkScheduleTransactions();
            _userGoals = DataManager.loadGoals(_username);
            _userTransactions = DataManager.getTransactionInfo(_username);

            //This is used to make sure no ids are duplicated
            for (int i = 0; i < _userTransactions.Count; i++)
            {
                int id = Convert.ToInt32(_userTransactions[i].Split(',')[0]);
                if (id > _idCount) _idCount = id;
            }
            _idCount++;

            //Manage schedule transaction here then update user_transactions
            _scheduledTransactions = DataManager.getScheduledTransactions(_username);
            DateTime test = new DateTime(2018, 12, 15);
            //checkScheduleTransactions(test, "Cody2");
            DataManager.saveScheduledTransactions(_scheduledTransactions, _username);

            //Load categories
            List<string> categories = DataManager.getCategories();
            for(int i = 0; i < categories.Count; i++)
            {
                uxCatagoryPicker.Items.Add(categories[i]);
            }

            updateDisplay();
            _db.Open();
        }

        public void updateDisplay()
        {
            uxTransactionsListView.Items.Clear();
            _userTransactions = DataManager.getTransactionInfo(_username); //Realod incase othe class did something.
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

            DateTime dt1 = new DateTime(2018, 10, 1, 13, 30, 52); //year,month,day,hour,min,sec
            DateTime dt2 = new DateTime(2018, 11, 8, 13, 30, 52); 
            double [] gl = getBasicGainLoss(dt1, dt2);
           
            uxLossAmountLabel.Text = gl[0].ToString(); //Loss
            uxGainAmountLabel.Text = gl[1].ToString(); //Gain
            double netAmount = gl[1] + gl[0]; //Net
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

        private void addTransaction(double amount, string description, string date, string catagory)
        {
            int id = _idCount;
            _idCount++;
            string saveInfo = id + "," + amount + "," + description + "," + date + "," + catagory;
            DateTime dt = Convert.ToDateTime(date);

            if (_userTransactions.Count == 0)
            {
                _userTransactions.Add(saveInfo);
            }
            else if (dt >= Convert.ToDateTime(_userTransactions[_userTransactions.Count - 1].Split(',')[3]))
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
            DataManager.saveTransactionInfo(_userTransactions, _username);
        }

        private void uxTransactionAddButton_Click(object sender, EventArgs e)
        {
            
            double amount = Convert.ToDouble(uxAddAmountBox.Text);
            string description = uxAddDescriptionBox.Text;
            string date = uxDateAddTransaction.Value.ToString();
            string catagory = uxCatagoryPicker.Text;
            addTransaction(amount, description, date, catagory);

            updateDisplay();
        }
        

        private void uxSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(_username);
            sf.ShowDialog(); //Just want to show, Don't want users adding/removing things after form open.
        }

        private void uxTransactionRemoveButton_Click(object sender, EventArgs e)
        {
            if (uxTransactionsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = uxTransactionsListView.SelectedItems[0];

                int id = Convert.ToInt32(item.SubItems[4].Text);
                List<string> tempTransactions = new List<string>();
                for (int i = 0; i < _userTransactions.Count; i++)
                {
                    int checkID = Convert.ToInt32(_userTransactions[i].Split(',')[0]);
                    if (id == checkID)
                    {

                    }
                    else
                    {
                        tempTransactions.Add(_userTransactions[i]);
                    }
                }
                _userTransactions = tempTransactions;

                uxTransactionsListView.Items.Remove(item);
                DataManager.saveTransactionInfo(_userTransactions, _username);
            }
        }

        private void uxLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            if(lf.ShowDialog() == DialogResult.OK)
            {
                //Add later for testing just use Cody2
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
            string saveInfo = amount + "," + description + "," + goalDate.ToString();


            if (_userGoals.Count == 0)
            {
                _userGoals.Add(saveInfo);
            }
            else if (goalDate >= Convert.ToDateTime(_userGoals[_userGoals.Count - 1].Split(',')[2]))
            {
                _userGoals.Add(saveInfo);
            }
            else
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < _userGoals.Count; i++)
                {
                    DateTime date = Convert.ToDateTime(_userGoals[i].Split(',')[2]);

                    if (goalDate < date)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            temp.Add(_userGoals[j]);
                        }

                        temp.Add(saveInfo);

                        for (int j = i; j < _userGoals.Count; j++)
                        {
                            temp.Add(_userGoals[j]);
                        }
                        break;
                    }
                }
                _userGoals = temp;
            }
            DataManager.saveGoals(_userGoals,_username);
            updateGoals();
        }

        

        private void updateGoals()
        {
            _userGoals = DataManager.loadGoals(_username); //Reload goals incase other class messed with them.
            uxGoalsLabel.Text = "";
            uxGoalsLabel.ForeColor = Color.Blue;

            for (int i = 0; i < 5 && i < _userGoals.Count; i++)
            {
                string [] info = _userGoals[i].Split(',');
                uxGoalsLabel.Text += "Goal " + (i+1) + ":\n";
                uxGoalsLabel.Text += "Amount: " + info[0] + "\n";
                uxGoalsLabel.Text += "Description: " + info[1] + "\n";
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

        private void checkScheduleTransactions(DateTime test,string username)
        {
            string[] info;
            for(int i = 0; i < _scheduledTransactions.Count; i++)
            {
                info = _scheduledTransactions[i].Split(',');
                DateTime dt = Convert.ToDateTime(info[5]);
                //if(dt <= DateTime.Now)
                if(dt <= test)
                {
                    //Take out scheduled
                    addTransaction(Convert.ToDouble(info[0]), info[2], info[4], info[3]);
                    //Now edit scheduled transaction
                    DateTime endDate = Convert.ToDateTime(info[5]);
                    string [] frequency = info[6].Split('/');
                    DateTime newDate = endDate.AddMonths(Convert.ToInt32(frequency[0]));
                    string newSaveInfo = info[0] + "," + info[1] + "," + info[2] + "," + info[3] + "," + endDate.ToString() + "," + newDate.ToString() + "," + info[6];
                    _scheduledTransactions[i] = newSaveInfo;
                }
            }
        }

        private void sheduledTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTransactionForm stf = new ScheduleTransactionForm(_pathToScheduled,"Cody2");
            stf.Show();
        }

        private void uxViewGoalsButton_Click(object sender, EventArgs e)
        {
            GoalsForm gf = new GoalsForm(_pathToGoals,_username);
            gf.Show();
            //Update goal display on main page after

        }

        private void uxTransactionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxTransactionsListView.SelectedItems.Count > 0)
            {
                uxTransactionRemoveButton.Enabled = true;
            }
            else
            {
                uxTransactionRemoveButton.Enabled = false;
            }
        }

        private void gainLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GainLossForm glf = new GainLossForm(_username);
            glf.Show();
        }
    } //End class
} //End namespace

