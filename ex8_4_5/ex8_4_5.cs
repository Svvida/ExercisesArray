using System;
using System.Linq;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "2", "4", "5", "10", "22", "32", "213", "222" };
            for (int arrayElement = 0; arrayElement < array.Length; arrayElement++)
            {
                bool isAllDigitsEven = true;
                string number = array[arrayElement]; // array[i]
                int numberOfDigits = number.Length;
                for (int digit = 0; digit < numberOfDigits; digit++)
                {
                    if (number[digit] % 2 != 0) isAllDigitsEven = false;
                }
                if (isAllDigitsEven == true)
                {
                    System.Console.WriteLine(number);
                }
            }

        }
    }
}