using System;
using System.Collections.Generic;
using System.Text;

namespace SubstringOfString
{
    class SubstringOfString
    {
        static void Main(string[] args)
        {
            string str = "sollers";
            Console.WriteLine("All possible Substrings of " + str + " are: ");
            int len = str.Length;
            //we use nested loops to iterate from each letter of the string, till the end of the string
            for(int i = 0; i<len+1; i++)
            {
                for(int j = 1; j <= len - i; j++)
                {
                    Console.WriteLine(str.Substring(i, j));
                }
            }
            //time complexity is O(n^2)
        }
    }
}
