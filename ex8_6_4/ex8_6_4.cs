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

            //ex8_6_4 A
            // Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            // for (i = 0; i < numberOfUserInputs; i++)
            // {
            //     array[i] = i;
            //     Console.WriteLine("element - {0} : {1}", i, i);

            // }

            //ex8_6_4 B
            // int el = 7;
            // Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            // for (i = 0; i < numberOfUserInputs; i++)
            // {
            //     array[i] = el;
            //     Console.WriteLine("element - {0} : {1}", i, el);
            //     el += 1;

            // }

            //ex8_6_4 C
            // int el = 4;
            // Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            // for (i = 0; i < numberOfUserInputs; i++)
            // {
            //     array[i] = el;
            //     Console.WriteLine("element - {0} : {1}", i, el);
            //     el += 4;

            // }

            //ex8_6_4 D
            // int el = 1;
            // Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            // for (i = 0; i < numberOfUserInputs; i++)
            // {
            //     array[i] = el;
            //     Console.WriteLine("element - {0} : {1}", i, el);
            //     el *= 2;

            // }

            //ex8_6_4 E
            int el = 2;
            Console.WriteLine("Input " + numberOfUserInputs + " elements in the array :");
            for (i = 0; i < numberOfUserInputs; i++)
            {
                array[i] = el;
                Console.WriteLine("element - {0} : {1}", i, el);
                el += 1;

            }
        }
    }
}