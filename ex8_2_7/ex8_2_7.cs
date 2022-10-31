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
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach (int j in array)
            {
                if (j > largest)
                {
                    second = largest;
                    largest = j;
                }
                else if (j > second)
                    second = j;
            }

            System.Console.WriteLine("Second highest number is " + second);
            System.Console.WriteLine("");
            int numberOfSecondHighestNumberInArray = 0;
            foreach (int k in array)
            {
                if (k == second)
                    numberOfSecondHighestNumberInArray++;

            }
            System.Console.WriteLine("Number of times that second highest number occur in array: " + numberOfSecondHighestNumberInArray);
        }
    }
}