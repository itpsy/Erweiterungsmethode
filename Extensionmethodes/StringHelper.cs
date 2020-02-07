using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethodes
{
    static class StringHelper
    {
        public static int CountChar(this string s) 
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else
            {
                return s.Length;
            }
        }


        public static int CountWords(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else
            {
                char seperator = ' ';
                string[] v = s.Split(seperator);
                return v.Count();
            }
        }

        public static void AddCopyright(this string s1, string text, string copyright, int stellenwert)
        {
            char[] charSeparators = new char[] { ' ' };
            string[] result;

            result = s1.Split(charSeparators, StringSplitOptions.None);

            for (int i = 0; i < result.Length; i += stellenwert)
            {
                result[i] = copyright;
            }

            foreach (string entry in result)
            {
                Console.Write("{0} ", entry);
            }
        }
    }
}
