using System;
using System.Linq;

namespace exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input number of array elements:");
            int numberOfUserInputs = Convert.ToInt32(Console.ReadLine()); //take from user length of array

            int[] array = new int[numberOfUserInputs];
            int i;

            Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            for (i = 0; i < numberOfUserInputs; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] < 0)
                {
                    array[i] *= 0; //change all negative numbers to 0
                }
            }

            System.Console.WriteLine("Sorted array with all negative numbers changed to 0:");
            Array.Sort(array); //sort array
            foreach (int k in array)
            {
                System.Console.WriteLine(k);
            }
        }
    }
}