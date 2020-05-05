using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCount
{
    class CharacterCount
    {
        static void Main(string[] args)
        {
            string str = "azurefullstacktraining";
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (char ch in str)
            {
                if (characterCount.ContainsKey(ch))
                    characterCount[ch]++;
                else
                    characterCount[ch] = 1;
            }
            foreach(char ch in characterCount.Keys)
                Console.WriteLine(ch+ "," +characterCount[ch]);
        }
    }
}
