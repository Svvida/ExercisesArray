﻿using System;
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
            }



            System.Console.WriteLine("Sorted array: ");
            Array.Sort(array); //sort array 
            int o = 0;
            foreach (int k in array)
            {
                System.Console.Write("element {0} : ", o);
                o += 1;
                System.Console.WriteLine(k);
            }





            System.Console.WriteLine("Array elements with even index numbers: ");
            for (int ind = 0; ind < numberOfUserInputs; ind++)
            {
                if (ind % 2 == 0)
                {
                    System.Console.WriteLine(array[ind]);
                }
            }

        }

    }
}