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
        public static byte[] Encrypt(string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] += 2;
            }
            return bytes;
        }

        public static string Decrypt(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] -= 2;
            }
            string temp = Encoding.ASCII.GetString(bytes);
            return temp;
        }
    }
}
