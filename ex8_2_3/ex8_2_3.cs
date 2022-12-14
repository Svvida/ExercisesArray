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
            System.Console.WriteLine("");

            Console.WriteLine("***************************************");
            int maxValue = array.Max();
            System.Console.WriteLine("The biggest number is: " + maxValue);

            Console.WriteLine("***************************************");
            int numberOfMaxValues = 0;
            foreach (int g in array)
            {
                if (g == maxValue)
                    numberOfMaxValues++;
            }
            System.Console.WriteLine("Number of the biggest value is = {0}", numberOfMaxValues);
        }
    }
}