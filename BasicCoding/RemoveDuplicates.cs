using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class RemoveDuplicates
    {
        static void Main(string[] args)
        {
            //using hashset
            string str = "azurefullstacktraining";
            HashSet<char> chr = new HashSet<char>();
            Console.WriteLine("Removing duplicates using hashset");
            Console.WriteLine("Original String is: " + str);
            //storing the elements in the hashset because in hashset, duplicate elements cannot be added
            for (int i = 0; i < str.Length; i++)
            {
                chr.Add(str[i]);
            }
            //hashset chr now contains only a single letter of each letter present in the original string
            Console.Write("String after removing duplicates is: ");
            //iterating through the array using foreach loop
            foreach (char ch in chr)
                Console.Write(ch);
            //time complexity it O(n)

            Console.WriteLine("\n");

            //using a temp char array and 2 index_pointers to iterate through the array
            Console.WriteLine("Removing duplicates using a temp array and 2 index pointers");
            string str1 = "azurefullstacktraining";
            Console.WriteLine("Original string is: " + str1);
            char[] temp = str1.ToCharArray();
            Array.Sort(temp);
            //the temp array now contains all the letters of the string str1 in the sorted order
            int left_index = 1;
            int right_index = 1;
            //here we iterate through the sorted array temp. The while loop executes till the right_index pointer reaches the end of the array
            while(right_index != temp.Length)
            {
                //this condition checks if the next letters at the lef_index and right_index pointers are equal.
                //If they are equal, then you store the character at the right_index, at the address of the left_index
                if(temp[right_index] != temp[right_index-1])
                {
                    temp[left_index] = temp[right_index];
                    left_index += 1;
                }
                right_index += 1;
            }
            //after the while loop is executed, the temp array uptil the left_index pointer contains only the first occurrence of the letters of the string
            str1 = new String(temp);//converting the temp array into a string
            //Console.WriteLine("After the while loop is executed the string looks like this: " + str1);
            str1 = str1.Substring(0, left_index);//slicing the string till the left_index pointer

            Console.WriteLine("String after removing duplicates is: " + str1);
            //time complexity is O(nlogn)

        }
    }
}
