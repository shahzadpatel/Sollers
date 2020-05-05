using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseWordsInString
{
    class ReverseWordsInString
    {
        static void Main(string[] args)
        {
            string str = "Azure Full Stack Training";
            Stack<char> wordStack = new Stack<char>();
            string newStr = "";

            for(int i = 0; i < str.Length; ++i)
            {
                if(str[i] != ' ')
                    wordStack.Push(str[i]);
                
                else
                {
                    while (wordStack.Count > 0)
                        newStr += wordStack.Pop();
                    newStr += " ";
                }
            }

            while (wordStack.Count > 0)
                newStr += wordStack.Pop();

            Console.WriteLine("Original String is: ");
            Console.WriteLine(str);
            Console.WriteLine("\n");
            Console.WriteLine("String after reversing the words is: ");
            Console.WriteLine(newStr);

        }
    }
}
