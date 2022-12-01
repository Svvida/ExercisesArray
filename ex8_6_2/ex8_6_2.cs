using System;
using System.Linq;
using System.Collections.Generic;

namespace exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter how many Fibonacci sequence numbers you want to be written(two first numbers will be printed no mater of what): ");
            int numberOfElements = Convert.ToInt16(Console.ReadLine());

            System.Console.WriteLine(0);
            System.Console.WriteLine(1);
            int a = 0;
            int b = 1;
            for (int i = 0; i < numberOfElements; i++)
            {
                int c = a + b;
                System.Console.WriteLine(c);
                a = b;
                b = c;
            }

        }
    }
}