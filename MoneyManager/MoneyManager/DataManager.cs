using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoneyManager
{
    static class DataManager
    {

        private static string _pathToUsers = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Transactions\\";
        private static string _pathToGoals = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\User_Goals\\";
        private static string _pathToScheduledTransactions = "C:\\users\\rinik\\desktop\\Senior Project\\MoneyManager\\Scheduled_Transactions\\";

        public static List<string> loadGoals(string username)
        {
            if (File.Exists(_pathToGoals + username))
            {
                List<string> goals = new List<string>();
                using (StreamReader sr = new StreamReader(_pathToGoals + username))
                {
                    while (!sr.EndOfStream)
                    {
                        goals.Add(sr.ReadLine());
                    }
                }
                return goals;
            }
            return new List<string>(); //Return empty list
        }

        public static void saveGoals(List<string> userGoals, string username)
        {
            using (StreamWriter sw = new StreamWriter(_pathToGoals + username))
            {
                for (int i = 0; i < userGoals.Count; i++)
                {
                    sw.WriteLine(userGoals[i]);
                }
            }
        }

        public static List<string> getTransactionInfo(string username)
        {
            if (File.Exists(_pathToUsers + username))
            {
                List<string> transactions = new List<string>();
                using (StreamReader sr = new StreamReader(_pathToUsers + username)) //mabey add .txt
                {
                    while (!sr.EndOfStream)
                    {
                        string rawTransactionInfo = sr.ReadLine();
                        transactions.Add(rawTransactionInfo);
                    }
                }
                return transactions;
            }
            return new List<string>(); //return empty list
        }

        public static void saveTransactionInfo(List<string> userTransactions, string username)
        {
            string filepath = _pathToUsers + username;
            //Might change to sql database

            using (StreamWriter sw = new StreamWriter(_pathToUsers + username))
            {
                for (int i = 0; i < userTransactions.Count; i++)
                {
                    sw.WriteLine(userTransactions[i]);
                }
            }
        }

        public static List<string> getScheduledTransactions(string username)
        {
            if(File.Exists(_pathToScheduledTransactions + username))
            {
                List<string> scheduledTransactions = new List<string>();
                using (StreamReader sr = new StreamReader(_pathToScheduledTransactions + username))
                {
                    while (!sr.EndOfStream)
                    {
                        scheduledTransactions.Add(sr.ReadLine());
                    }
                }
                return scheduledTransactions;
            }
            return new List<string>(); //Return empty list
        }

        public static void saveScheduledTransactions(List<string> scheduledTransactions, string username)
        {
            using (StreamWriter sw = new StreamWriter(_pathToScheduledTransactions + username))
            {
                for (int i = 0; i < scheduledTransactions.Count; i++)
                {
                    sw.WriteLine(scheduledTransactions[i]);
                }
            }
        }

        public static List<string> getCategories()
        {
            List<string> categories = new List<string>();
            using(StreamReader sr = new StreamReader("Categories.txt"))
            {
                while (!sr.EndOfStream)
                {
                    categories.Add(sr.ReadLine());
                }
            }
            return categories;
        }
    }
}
