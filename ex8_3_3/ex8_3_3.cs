﻿using System;
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

            System.Console.WriteLine("Sorted array:");
            Array.Sort(array);
            foreach (int k in array)
            {
                System.Console.WriteLine(k);
            }

            Console.WriteLine("Increased by 1 elements in array: ");
            for (i = 0; i < numberOfUserInputs; i++)
            {
                int increase = array[i] + 1;
                System.Console.WriteLine("Increased element - " + i + " : " + increase);

            }

        }
    }
}