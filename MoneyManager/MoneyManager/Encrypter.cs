using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace MoneyManager
{
    public static class Encrypter
    {
        /// <summary>
        /// Converts input string to byte data to hide it.
        /// </summary>
        /// <param name="data">The string that is going to be encrypted.</param>
        /// <param name="key">A key used for encryption</param>
        /// <returns>Encrypted byte data</returns>
        public static byte[] Encrypt(string data,byte key)
        {
            string str = "";
            
            for(int i = data.Length - 1; i > -1; i--)
            {
                str += data[i];
            }
           
            
            byte[] bytes = Encoding.ASCII.GetBytes(str);

            byte b = (byte)bytes.Length;
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] += 2;
            }
            return bytes;
        }

        /// <summary>
        /// Takes in encrypted byte data and returns it string in a usable format.
        /// </summary>
        /// <param name="bytes">An ecrypted string saved as bytes</param>
        /// <param name="key">A key used for encryption</param>
        /// <returns>The orginal string before it was encrypted</returns>
        public static string Decrypt(byte[] bytes, byte key)
        {

            string temp = Encoding.ASCII.GetString(bytes);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] -= 2;
            }
            
            temp = Encoding.ASCII.GetString(bytes);
            
            string str = "";

            for (int i = temp.Length - 1; i > -1; i--)
            {
                str += temp[i];
            }
          
            
            return str;
        }
    }
}
