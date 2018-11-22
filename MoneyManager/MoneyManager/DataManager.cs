using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace MoneyManager
{
    /// <summary>
    /// This class controls all saving and loading functions for the program.
    /// </summary>
    static class DataManager
    {
        /// <summary>
        /// Base path to all user transactions
        /// </summary>
        private static string _pathToUsers = "User_Transactions\\";

        /// <summary>
        /// Base path to all user goals
        /// </summary>
        private static string _pathToGoals = "User_Goals\\";

        /// <summary>
        /// Base path to all user scheduled transactions.
        /// </summary>
        private static string _pathToScheduledTransactions = "Scheduled_Transactions\\";


        private static void saveData(string path, List<string> info) 
        {
            string temp = "";
            for(int i = 0; i < info.Count; i++)
            {
                temp += info[i] + "\n";
            }

            byte[] bytes = Encrypter.Encrypt(temp);

            File.WriteAllBytes(path, bytes);
        }

        private static List<string> readInData(string path)
        {
            
            byte[] bytes = File.ReadAllBytes(path);
            string temp = Encrypter.Decrypt(bytes);

            List<string> result = new List<string>();
            string [] tempArray = temp.Split('\n');

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i].Length > 5)
                {
                    result.Add(tempArray[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Reads in all of a user goal information and returns it.
        /// </summary>
        /// <param name="username">The user who's goals are being read in</param>
        /// <returns>A List contain all the users goals as strings.</returns>
        public static List<string> loadGoals(string username)
        {
            if (username != "NOUSER")
            {
                
                if (File.Exists(_pathToGoals + username))
                {
                    
                    return readInData(_pathToGoals + username);
                }
                
                
            }
            return new List<string>(); //Return empty list
        }

        /// <summary>
        /// Writes the users goals to a text file.
        /// </summary>
        /// <param name="userGoals">All the users goals that are going to be saved</param>
        /// <param name="username">The user whos goals are being saved</param>
        public static void saveGoals(List<string> userGoals, string username)
        {
            if (username != "NOUSER")
            {
               
                saveData(_pathToGoals + username, userGoals);
            }
        }

        /// <summary>
        /// Reads in all of the users transaction information.
        /// </summary>
        /// <param name="username">The user whos transactions are being gathered</param>
        /// <returns>A list with all the users transactions info as strings</returns>
        public static List<string> getTransactionInfo(string username)
        {
            if (username != "NOUSER")
            {
                if (File.Exists(_pathToUsers + username))
                {
                    return readInData(_pathToUsers + username);
                }
            }
            return new List<string>(); //return empty list
        }

        /// <summary>
        /// Saves all the users transaction info to a text file.
        /// </summary>
        /// <param name="userTransactions">All of the users transaction information</param>
        /// <param name="username">The user whos transactions are being saved</param>
        public static void saveTransactionInfo(List<string> userTransactions, string username)
        {
            if (username != "NOUSER")
            {
                saveData(_pathToUsers + username, userTransactions);
            }
        }

        /// <summary>
        /// Gets all of a users scheduled transactions
        /// </summary>
        /// <param name="username">The user whos shceduled transactions are being looked up.</param>
        /// <returns>A list containing all the users scheduled transaction information in strings.</returns>
        public static List<string> getScheduledTransactions(string username)
        {
            if (username != "NOUSER")
            {
                if (File.Exists(_pathToScheduledTransactions + username))
                {
                  
                    return readInData(_pathToScheduledTransactions + username);
                }
            }
            return new List<string>(); //Return empty list
        }

        /// <summary>
        /// Saves all a users scheduled transaction to a text file.
        /// </summary>
        /// <param name="scheduledTransactions">All the user scheduled transactions</param>
        /// <param name="username">The user whos scheduled transactions are being saved</param>
        public static void saveScheduledTransactions(List<string> scheduledTransactions, string username)
        {
            if (username != "NOUSER")
            {
                saveData(_pathToScheduledTransactions + username, scheduledTransactions);
            }
        }

        /// <summary>
        /// Returns a list of all the catergories so that multiple forms can acess them.
        /// </summary>
        /// <returns>A list with each string being a category.</returns>
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
