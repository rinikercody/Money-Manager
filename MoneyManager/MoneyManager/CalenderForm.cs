using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class CalenderForm : Form
    {
        private List<string> _userTransactions;
        private List<string> _userGoals;
        private List<string> _scheduledTransactions;
        private string _username;

        
        private Label[] _dates;
        private Label[] _info;
        private Panel[] _panels;

        private int _month;
        private int _year;
        
        public CalenderForm(string username)
        {
            InitializeComponent();
            _username = username;
            _month = DateTime.Now.Month;
            _year = DateTime.Now.Year;

            //JUST GET NUMBER FROM PANEL AND USE MONTH TO CHECK DATES NO DICTONARY
            
            
            Label [] dates = {
                uxDate1,uxDate2,uxDate3,uxDate4,uxDate5,uxDate6,uxDate7,
                uxDate8,uxDate9,uxDate10,uxDate11,uxDate12,uxDate13,uxDate14,
                uxDate15,uxDate16,uxDate17,uxDate18,uxDate19,uxDate20,uxDate21,
                uxDate22,uxDate23,uxDate24,uxDate25,uxDate26,uxDate27,uxDate28,
                uxDate29,uxDate30,uxDate31,uxDate32,uxDate33,uxDate34,uxDate35,
                uxDate36,uxDate37,uxDate38,uxDate39,uxDate40,uxDate41,uxDate42
            };
            _dates = dates;

            Label[] info = {
                uxInfo1,uxInfo2,uxInfo3,uxInfo4,uxInfo5,uxInfo6,uxInfo7,
                uxInfo8,uxInfo9,uxInfo10,uxInfo11,uxInfo12,uxInfo13,uxInfo14,
                uxInfo15,uxInfo16,uxInfo17,uxInfo18,uxInfo19,uxInfo20,uxInfo21,
                uxInfo22,uxInfo23,uxInfo24,uxInfo25,uxInfo26,uxInfo27,uxInfo28,
                uxInfo29,uxInfo30,uxInfo31,uxInfo32,uxInfo33,uxInfo34,uxInfo35,
                uxInfo36,uxInfo37,uxInfo38,uxInfo39,uxInfo40,uxInfo41,uxInfo42
            };
            _info = info;

            Panel[] panels =
            {
                panel1,panel2,panel3,panel4,panel5,panel6,panel7,
                panel8,panel9,panel10,panel11,panel12,panel13,panel14,
                panel15,panel16,panel17,panel18,panel19,panel20,panel21,
                panel22,panel23,panel24,panel25,panel26,panel27,panel28,
                panel29,panel30,panel31,panel32,panel33,panel34,panel35,
                panel36,panel37,panel38,panel39,panel40,panel41,panel42
            };
            _panels = panels;
            

            updateDisplay();
           
        }

    

        public void updateDisplay()
        {
            for(int i = 0; i < 42; i++)
            {
                _dates[i].Text = "";
                _info[i].Text = "";
            }

            _userTransactions = DataManager.getTransactionInfo(_username);
            _userGoals = DataManager.loadGoals(_username);
            _scheduledTransactions = DataManager.getScheduledTransactions(_username);
            uxMonthLabel.Text = getMonth(_month) + _year;

            int daysinmonth = DateTime.DaysInMonth(_year, _month);
            DateTime startDay = new DateTime(_year,_month,1);

            int start = (int)startDay.DayOfWeek;//Sun = 0; Sat = 6;


            
            for (int i = 0; i < 42; i++)
            {
                if (i < start || i > daysinmonth + start - 1)
                {
                    //panelSwitch(i, "Empty ", "Nothing");
                    _panels[i].BackColor = Control.DefaultBackColor;
                }
                else
                {
                    _panels[i].BackColor = Color.White;
                    string info = "";
                    for (int j = 0; j < _userGoals.Count; j++)
                    {
                        string date = _userGoals[j].Split(',')[2];
                        DateTime temp = Convert.ToDateTime(date);

                        if(temp.Month == startDay.Month && temp.Day == (i + 1 - start) && temp.Year == _year)
                        {
                            info += "Goal: $" + _userGoals[j].Split(',')[0] + "\n";
                        }
                      
                    }

                    for(int j = 0; j < _scheduledTransactions.Count; j++)
                    {
                        string date = _scheduledTransactions[j].Split(',')[4];
                        DateTime temp = Convert.ToDateTime(date);
                        if (temp.Month == startDay.Month && temp.Day == (i + 1 - start) && temp.Year == _year)
                        {
                            info += "ST: $" + _scheduledTransactions[j].Split(',')[0] + "\n";
                        }
                    }

                    panelSwitch(i, (i - start + 1).ToString(), info);
                    
                }
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("DATE");
        }

        private void getStartingPoint(string day)
        {
            switch (day)
            {

            }
        }

        private void panelSwitch(int postion, string date, string info) //Date is like 11/17 
        {
            _dates[postion].Text = date;

            //Check for length by new lines here
            _info[postion].Text += info;
        }

        private void uxLastMonth_Click(object sender, EventArgs e)
        {
            if(_month > 1)
            {
                _month--;
            }
            else
            {
                _month = 12;
                _year--;
            }
            updateDisplay();
        }

        private void uxNextMonth_Click(object sender, EventArgs e)
        {
            if(_month < 12)
            {
                _month++;
            }
            else
            {
                _month = 1;
                _year++;
            }
            updateDisplay();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Click(object sender,EventArgs e)
        {
            Panel p = (Panel)sender;

            DateTime startDay = new DateTime(_year, _month, 1);
            int start = (int)startDay.DayOfWeek;//Sun = 0; Sat = 6;

            int day = Convert.ToInt32(p.Name.Substring(5)) - start;


            int itemCount = 0;
            string info = getMonth(_month) + " " + day + "\n\n";
            int startLength = info.Length;

            string temp = "Transactions:\n";
            for(int i = 0; i < _userTransactions.Count; i++)
            {
                string [] transactionInfo = _userTransactions[i].Split(',');
                DateTime date = Convert.ToDateTime(transactionInfo[3]);
                
                if (date.Year == _year && date.Month == _month && date.Day == day)
                {
                    temp += "$" + transactionInfo[1] + transactionInfo[2] + "\n";
                    itemCount++;
                }
            }

            if(itemCount > 0)
            {
                info += temp;
            }
            itemCount = 0;

            temp = "Goals:\n";
            for (int i = 0; i < _userGoals.Count; i++)
            {
                string[] transactionInfo = _userTransactions[i].Split(',');
                DateTime date = Convert.ToDateTime(transactionInfo[3]);

                if (date.Year == _year && date.Month == _month && date.Day == day)
                {
                    temp += "$" + transactionInfo[0] + "  " + transactionInfo[1] + "\n";
                    itemCount++;
                }
            }

            if (itemCount > 0)
            {
                info += temp;
            }

            itemCount = 0;
           

            temp = "Scheduled Transactions:\n";
            for (int i = 0; i < _scheduledTransactions.Count; i++)
            {
                string[] transactionInfo = _scheduledTransactions[i].Split(',');
                DateTime date = Convert.ToDateTime(transactionInfo[5]);

                if (date.Year == _year && date.Month == _month && date.Day == day)
                {
                    temp += "$" + transactionInfo[1] + "  " + transactionInfo[2] + "\n";
                    itemCount++;
                }
            }

            if(itemCount > 0)
            {
                info += temp;
            }

            if (info.Length > startLength)
            {
                MessageBox.Show(info);
            }
        }
    }
}
