using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                //Console.WriteLine(digit);
                sum += digit;
                num /= 10;
            }
            Console.WriteLine("Sum of the digits = " + sum);
        }
    }
}
