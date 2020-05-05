using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = FactNum(num);

            Console.WriteLine("Factorial of number is: " + fact);

        }

        public static int FactNum(int number)
        {
            if (number == 0)
                return 1;

            return number * FactNum(number - 1);
        }
    }
}
