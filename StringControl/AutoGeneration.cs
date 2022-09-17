using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringControl
{
    internal static class AutoGeneration
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        static char[] stringChars = new char[8];
        static Random random = new Random();
        
        public static string Generation()
        {
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var result = new string(stringChars);
            return result;
        }
    }
}
