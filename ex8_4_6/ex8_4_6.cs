using System;
using System.Linq;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "1", "2", "4", "5", "7", "10", "22", "32", "213", "222", "100", "1000" };
            for (int arrayElement = 0; arrayElement < array.Length; arrayElement++)
            {
                bool isSumOfDigitsEqualOne = true;
                int NumberOfDigits = array[arrayElement].Length;

                for (int digit = 0; digit < NumberOfDigits; digit++)
                {
                    int sum = 0;
                    int ElementTablicy = Convert.ToInt32(array[arrayElement]);
                    while (ElementTablicy != 0)
                    {
                        sum += ElementTablicy % 10;
                        ElementTablicy /= 10;
                    }

                    if (sum > 1)
                    {
                        isSumOfDigitsEqualOne = false;
                    }
                }


                if (isSumOfDigitsEqualOne == true)
                {
                    System.Console.WriteLine(array[arrayElement]);
                }

            }

        }
    }
}