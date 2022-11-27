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
                if (i % 2 == 0)
                {
                    array[i] += 100; //increase each array element by 100
                }



            }




            System.Console.WriteLine("Sorted array with even numbers increased by 100:");
            Array.Sort(array); //sort array
            foreach (int k in array)
            {
                System.Console.WriteLine(k);
            }

            // Console.WriteLine("Even numbers: ");
            // foreach (int element in array)
            // {
            //     if (element % 2 == 0) //find even numbers   
            //     {

            //         System.Console.WriteLine(element);
            //     }
            // }



        }

    }
}