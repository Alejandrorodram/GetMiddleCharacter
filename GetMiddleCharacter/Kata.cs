using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddleCharacter
{
    internal class Kata
    { 
        public static string GetMiddleCharacter1(string s)
        {
            if (s.Length % 2 == 0)
            {
                return s.Substring(s.Length / 2 - 1, 2);
            }
            else
            {
                return s.Substring(s.Length / 2, 1);
            }
        }
        public static string GetMiddleCharacter2(string s)
        {
            return s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2, 1);
        }
        public static string GetMiddleCharacter3(string s)
        {
            return string.IsNullOrEmpty(s)
            ? s
            : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }

        public static string GetMiddleCharacter4(string s)
        {
            string result = "";
            char[] sarr = s.ToCharArray();

            if (s.Length % 2 != 0)
            {
                result = sarr[((sarr.Length + 1) / 2) - 1].ToString();

            }

            if (s.Length % 2 == 0)
            {
                result = sarr[((sarr.Length + 1) / 2) - 1] + sarr[(sarr.Length + 1) / 2].ToString();

            }

            return result;
        }

    }
}
