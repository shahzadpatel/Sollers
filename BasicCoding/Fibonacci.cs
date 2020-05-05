using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements you want from the fibonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            Console.WriteLine("The elements of the Fibonacci series are: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            for(int i = 2; i < num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
