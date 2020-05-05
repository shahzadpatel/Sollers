using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseOrderOfWords
{
    class ReverseOrderOfWords
    {
        public static void Main(string[] args)
        {
            string str = "Azure FullStack Training by Sollers";
            string resultString = "";
            int i = str.Length - 1;
            int start, end;
            start = end = i + 1;

            while (i >= 0)
            {
                if (str[i] == ' ')
                {
                    start = i + 1;
                    while (start != end)
                        resultString += str[start++];
                    resultString += " ";
                    end = i;
                }
                i--;
            }

            start = 0;
            while (start != end)
                resultString += str[start++];

            Console.WriteLine("Original String is: ");
            Console.WriteLine(str);
            Console.WriteLine("String after reversing the order of words is: ");
            Console.WriteLine(resultString);

        }
    }
}
