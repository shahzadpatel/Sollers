using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumber
{
    class PrimeNumber
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine()); //Accepting the number from the user
            //we use the function CheckPrime to check for each number
            if (CheckPrime(num))
                Console.WriteLine("Entered number is Prime");
            else
                Console.WriteLine("Entered number is not Prime");
        }
        public static bool CheckPrime(int num)
        {
            if (num == 0 || num == 1 || num < 1 || num % 2 == 0)
                return false;
            if (num == 2)
                return true;
            //after checking for the default conditions we iterate from the number 3 till half of the entered number
            //if even a single number from 3 till n/2 is divisible by num, then the number is not prime
            for(int i = 3; i < num/2; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
