using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEXample_Csharp.Utils
{
    public class Utils
    {
        private Random random = new Random();

        public string RandomString(int length, bool toLower = true)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            if (toLower)
                chars = chars.ToLower();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string RandomNumericString(int length, bool toLower = true)
        {
            var chars = "0123456789";
            if (toLower)
                chars = chars.ToLower();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
