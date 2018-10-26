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
    public partial class GainLossForm : Form
    {

        private string _username;
        private List<string> _categories = new List<string>();
        private List<string> _transactions = new List<string>();

        public GainLossForm(string username)
        {
            InitializeComponent();
            _username = username;
            _categories = DataManager.getCategories();
            _transactions = DataManager.getTransactionInfo(_username);
            updateDisplay();
        }

        public void updateDisplay()
        {
            for(int i = 0; i < _categories.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _categories[i];
                uxGainLoseListView.Items.Add(item);
            }
        }
    }
}
