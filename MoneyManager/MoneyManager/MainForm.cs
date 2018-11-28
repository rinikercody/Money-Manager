using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

//Handle when no user is loged in vs loged out
namespace MoneyManager
{
    public partial class MainForm : Form
    {
        //All the current users goals in text format.
        private List<string> _userGoals = new List<string>();

        //All the current users transaction info in text format.
        private List<string> _userTransactions = new List<string>();

        //All the current users scheduled Transaction in text format.
        private List<string> _scheduledTransactions = new List<string>();

        //The current user of the program
        private string _username = "NOUSER";

        //_idCount helps track transactions ids to ensure there are no dublicate transaction ids.
        private int _idCount;

        /// <summary>
        /// Creates a new MainForm
        /// </summary>
        /// <param name="username">The user that logged in</param>
        public MainForm(string username)
        {
            InitializeComponent();

                _username = username;
                uxClockTimer.Interval = 1000;
                uxClockTimer.Start();
                uxCurrentTimeLabel.Text = "Today: ";

                _userGoals = DataManager.loadGoals(_username); //Get Goals
                _userTransactions = DataManager.getTransactionInfo(_username); //Get Transactions


                //This is used to make sure no ids are duplicated
                _idCount = -1; //Make _idCount lower than any possible id.
                for (int i = 0; i < _userTransactions.Count; i++)
                {
                    int id = Convert.ToInt32(_userTransactions[i].Split(',')[0]);
                    if (id > _idCount) _idCount = id;
                }
                _idCount++; //Increment so next id is one higher than the highest id.

                //Manage schedule transactions here then update user_transactions
                _scheduledTransactions = DataManager.getScheduledTransactions(_username);

                DateTime test = new DateTime(2018, 11, 15);
                checkScheduleTransactions(DateTime.Now, _username);

                DataManager.saveScheduledTransactions(_scheduledTransactions, _username);

                //Load categories
                List<string> categories = DataManager.getCategories();
                for (int i = 0; i < categories.Count; i++)
                {
                    uxCatagoryPicker.Items.Add(categories[i]);
                }

                updateDisplay(); //Display information to user

            /*
            string saveData = "";
            for (int i = 0; i < _userTransactions.Count; i++)
            {
                saveData += _userTransactions[i] + "\n";
            }
            byte[] encrypted;
            using (RijndaelManaged myRijndael = new RijndaelManaged())
            {
                myRijndael.GenerateKey();
                myRijndael.GenerateIV();
                encrypted = Encrypter.EncryptStringToBytes(saveData, myRijndael.Key, myRijndael.IV);
                string roundtrip = Encrypter.DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);
                MessageBox.Show(roundtrip);
            }
            */



        }

        ///////////////////////////////Updates the view/////////////////////////////////////////////////

        /// <summary>
        /// Updates all information from the model to main form display.
        /// </summary>
        public void updateDisplay()
        {
            uxTransactionsListView.Items.Clear(); //Clear out listview before putting new things in.
            _userTransactions = DataManager.getTransactionInfo(_username); //Reload incase other forms altered data.
            for (int i = 0; i < _userTransactions.Count; i++)
            {
                //id,amount,description,date,category
                string[] info = _userTransactions[i].Split(',');

                //Create item with transaction infomation.
                ListViewItem item = new ListViewItem();
                double amount = Convert.ToDouble(info[1]);
                item.Text = amount.ToString("c"); //First column of list view is set to amount
                DateTime temp = Convert.ToDateTime(info[3]);
                item.SubItems.Add(temp.ToString("MM/dd/yyyy")); //Date
                item.SubItems.Add(info[2]); //Description
                item.SubItems.Add(info[4]); //Catagory
                item.SubItems.Add(info[0]); //Id

                if (amount < 0) item.ForeColor = Color.Red; //Negative amount
                else item.ForeColor = Color.Green; //Positive amount

                uxTransactionsListView.Items.Add(item); //Add the transaction information to the listview.
            }
           
            //Update everything else on the display
            
            uxUserLabel.Text = "Signed in: " + _username;

            DateTime dt1 = new DateTime(2018, 10, 1, 13, 30, 52); //year,month,day,hour,min,sec
            DateTime dt2 = new DateTime(2018, 11, 8, 13, 30, 52); 
            double [] gl = getBasicGainLoss();
           
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

        /// <summary>
        /// Displays all the users current goals. This is called by updateDisplay and when goals are add/deleted
        /// </summary>
        private void updateGoals()
        {
            _userGoals = DataManager.loadGoals(_username); //Reload goals incase other class messed with them.
            uxGoalsLabel.Text = "";
            uxGoalsLabel.ForeColor = Color.Blue;

            /*
            for(int i = 0; i < _userGoals.Count; i++)
            {
                MessageBox.Show(_userGoals[i]);
            }
            */

            for (int i = 0; i < 5 && i < _userGoals.Count; i++)
            {
                string[] info = _userGoals[i].Split(',');
                uxGoalsLabel.Text += "Goal " + (i + 1) + ":\n";
                uxGoalsLabel.Text += "Amount: " + info[0] + "\n";
                uxGoalsLabel.Text += "Description: " + info[1] + "\n";
                uxGoalsLabel.Text += "By: " + info[2] + "\n\n";
            }
        }

        //////////////////////Methods that help updateDisplay/////////////////////////////////////

        /// <summary>
        /// Gets the amount of money spent and gained over all transactions.
        /// </summary>
        /// <returns>A dobule array with [0] being loss and [1] being gain</returns>
        public double[] getBasicGainLoss()
        {
            double[] gl = new double[2];
            gl[0] = 0;
            gl[1] = 0;

            for(int i = 0; i < _userTransactions.Count; i++)
            {
                string [] info = _userTransactions[i].Split(',');
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
            return gl;
        }    

        /// <summary>
        /// Returns the name of the month based on the month number.
        /// </summary>
        /// <param name="number">The number of the month, 1-12</param>
        /// <returns>The name of the month with the corrisponding number.</returns>
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


        /////////////////////////////////Methods that do a lot of work////////////////////////////////////////////

        /// <summary>
        /// Adds a new transaction to the users transaction list and saves it.
        /// </summary>
        /// <param name="amount">Money involed in transaction</param>
        /// <param name="description">Why was this money spent/ what was it spent on.</param>
        /// <param name="date">The date when this transaction occured</param>
        /// <param name="catagory">The subgroup of transactions that this transaction belongs to</param>
        private void addTransaction(double amount, string description, string date, string catagory)
        {
            int id = _idCount; //Get the next id available
            _idCount++; //Increment _idCount so next id is unique
            string saveInfo = id + "," + amount + "," + description + "," + date + "," + catagory;
            DateTime dt = Convert.ToDateTime(date);

            //If there are currently no transaction for the user.
            //Or the transaction date of the one being added is after all the previous transaction dates.
            if (_userTransactions.Count == 0 || dt >= Convert.ToDateTime(_userTransactions[_userTransactions.Count - 1].Split(',')[3]))
            {
                _userTransactions.Add(saveInfo);
            }
            else //Add the transaction in the approiate spot according to date.
            {
                List<string> tempList = new List<string>(); //A temporay list used to transfer inforation
                for (int i = 0; i < _userTransactions.Count; i++)
                {
                    //If the new transactions date is lower than date i.
                    if (dt < Convert.ToDateTime(_userTransactions[i].Split(',')[3]))
                    {
                        //Copy all transactions before date to temp list
                        for (int j = 0; j < i; j++)
                        {
                            tempList.Add(_userTransactions[j]);
                        }

                        //Add new transation info in the correct spot
                        tempList.Add(saveInfo);

                        //Copy the rest of the transaction over.
                        for (int j = i; j < _userTransactions.Count; j++)
                        {
                            tempList.Add(_userTransactions[j]);
                        }

                        //transaction is in correct spot so exit loop
                        break;
                    }
                }
                //_userTransactions now equals the updated list with the new transaction.
                _userTransactions = tempList;
            }
            //Save updated transaction info.
            DataManager.saveTransactionInfo(_userTransactions, _username);
        }

        /// <summary>
        /// Checks to see if any scheduled transactions need to be taken out when the program is started.
        /// If a transaction needs to be done than the transaction will be added and the scheduled transaction will be updated.
        /// </summary>
        /// <param name="currentDate">The current date which scheduled transactions are being check against</param>
        /// <param name="username">The current user</param>
        private void checkScheduleTransactions(DateTime currentDate, string username)
        {
           
            string[] info;
            int i = 0;
            int limit = _scheduledTransactions.Count;
            for (i = 0; i < limit; i++)
            {
                info = _scheduledTransactions[i].Split(',');
                DateTime dt = Convert.ToDateTime(info[5]);
                if (dt <= currentDate)
                {
                    //Take out scheduled
                    addTransaction(Convert.ToDouble(info[1]), info[2], info[4], info[3]);
                    //Now edit scheduled transaction
                    DateTime endDate = Convert.ToDateTime(info[5]);
                    string[] frequency = info[6].Split('/');
                    //MessageBox.Show(frequency[0]);
                    int f = Convert.ToInt32(frequency[0]);
                    int f2 = Convert.ToInt32(frequency[1]);

                    if (f == 0 && f2 == 0)
                    {
                        List<string> temp = new List<string>();
                        for (int j = 0; j < limit; j++)
                        {
                            if (j != i)
                            {
                                temp.Add(_scheduledTransactions[j]);
                            }
                        }
                        _scheduledTransactions = temp;
                    }
                    else
                    {
                        DateTime newDate = endDate.AddMonths(f);
                        newDate = newDate.AddDays(f2 * 7);
                        string newSaveInfo = info[0] + "," + info[1] + "," + info[2] + "," + info[3] + "," + endDate.ToString("MM/dd/yyyy") + "," + newDate.ToString() + "," + info[6];
                        _scheduledTransactions[i] = newSaveInfo;
                    }
                    i = -1; //Restart loop after taking something out
                    limit = _scheduledTransactions.Count;
                }
                
            } //End forloop
            DataManager.saveScheduledTransactions(_scheduledTransactions, _username);
        }


        //////////////////////Click events that do a good amount of work /////////////////////////////////////

        /// <summary>
        /// Button click event for a adding a new transaction
        /// Calls addTransaction where most of the work is done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxTransactionAddButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(uxAddAmountBox.Text);
            string description = uxAddDescriptionBox.Text;
            string date = uxDateAddTransaction.Value.ToString("MM/dd/yyyy");
            
            string catagory = uxCatagoryPicker.Text;
            addTransaction(amount, description, date, catagory);
            updateDisplay();
        }
        
        /// <summary>
        /// Button click event for removing a transaction.
        /// Removes transaction from user transactions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Button click event for adding a goal.
        /// Adds goal to users goals and updates display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        ////////////////////////////////Basic requirment checks on input/////////////////////////////////////

        /// <summary>
        /// An event that checks if the current amount entered is a double.
        /// This is the only requirement check for adding a new transaction.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddAmountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxAddAmountBox.Text);
                uxTransactionAddButton.Enabled = true;
            }
            catch (Exception ex)
            {
                uxTransactionAddButton.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if all goal information is in the correct format and withen defined rules.
        /// Is the amount a double, is there a description, and is the date in the future
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkGoalButton(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(uxGoalAmountBox.Text);
                if (uxGoalDescriptionBox.Text.Length > 0)
                {
                    TimeSpan ts = new TimeSpan(6, 0, 0, 0); //A little less than a week
                    if (uxGoalDate.Value - DateTime.Now > ts)
                    { //Check if goal is at least a week away
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

        /// <summary>
        /// Enables/disables remove button depeding on if something is selected or not
        /// Makes sure something is selected before trying to remove it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        ////////////////////////////////Basic click events for opening forms//////////////////////////////////////

        /// <summary>
        /// Opens a new GainLossForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gainLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GainLossForm glf = new GainLossForm(_username);
            glf.Show();
        }

        /// <summary>
        /// Opens a new ScheduledTransactionForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sheduledTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTransactionForm stf = new ScheduleTransactionForm(_username);
            stf.Show();
        }

        /// <summary>
        /// Opens a new GoalsForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxViewGoalsButton_Click(object sender, EventArgs e)
        {
            GoalsForm gf = new GoalsForm(_username);
            gf.ShowDialog();
            updateDisplay();
            //Update goal display on main page after

        }

        /// <summary>
        /// Opens a login form which the user can use to sign in to use the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                _username = lf.Username;
                updateDisplay();
            }
        }

        /// <summary>
        /// Opens a new SearchForm when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(_username);
            sf.ShowDialog(); //Just want to show, Don't want users adding/removing things after form open.
        }

        /// <summary>
        /// Updates time label on form to display the current time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxClockTimer_Tick(object sender, EventArgs e)
        {
            //uxCurrentTimeLabel.Text = "Today: " + getMonth(DateTime.Now.Month) + " " + DateTime.Now.Day + "," + DateTime.Now.ToString("hh:mm");
            uxCurrentTimeLabel.Text = "Today: " + getMonth(DateTime.Now.Month) + " " + DateTime.Now.ToString("dd, yyyy Time:  hh:mm");
        }

        private void uxCalenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalenderForm c = new CalenderForm(_username);
            c.Show();
        }
    } //End class
} //End namespace

