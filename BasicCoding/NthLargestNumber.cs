using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NthLargestNumber
{
    class NthLargestNumber
    {
        static void Main(string[] args)
        {
            //finding the second and third largest number in an array
            int[] nums = { 14, 25, 36, 74, 14, 69, 25, 12, 36, 58 };
            int first, second, third;
            first = second = third = Int32.MinValue;
            Console.WriteLine("Elements of the array are: ");
            foreach (int num in nums)
                Console.Write(num+ " ");
            Console.WriteLine("\n");

            foreach(int num in nums)
            {
                if (first <= num)
                {
                    third = second;
                    second = first;
                    first = num;
                }
                else if (second <= num)
                {
                    third = second;
                    second = num;
                }
                else if (third <= num)
                    third = num;
            }

            Console.WriteLine("Second largest number in the array is " + second);
            Console.WriteLine("Third largest number in the array is " + third);
        }
    }
}
