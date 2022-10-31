using System;
using System.Linq;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Input number of array elements:");
            int numberOfUserInputs = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[numberOfUserInputs];
            int i;

            Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            for (i = 0; i < numberOfUserInputs; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < numberOfUserInputs; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.Write("\n");
            int second = int.MaxValue;
            int smallest = int.MaxValue;
            foreach (int j in array)
            {
                if (j < smallest)
                {
                    second = smallest;
                    smallest = j;
                }
                else if (j < second)
                    second = j;
            }

            System.Console.WriteLine("Second smallest number is " + second);
            System.Console.WriteLine("");
            int numberOfSecondSmallestNumberInArray = 0;
            foreach (int k in array)
            {
                if (k == second)
                    numberOfSecondSmallestNumberInArray++;

            }
            System.Console.WriteLine("Number of times that second smallest number occur in array: " + numberOfSecondSmallestNumberInArray);
        }
    }
}