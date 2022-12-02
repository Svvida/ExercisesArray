using System;
using System.Linq;
using System.Collections.Generic;

namespace exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input number of array elements: ");
            int numberOfArrayElements = Convert.ToInt16(Console.ReadLine());

            int[] array = new int[numberOfArrayElements];
            int i;
            for (i = 0; i < numberOfArrayElements; i++)
            {
                System.Console.Write("Element {0} - ", i);
                array[i] = Convert.ToInt16(Console.ReadLine());
            }

            sortArray(array);
            System.Console.WriteLine("Sorted array:");
            printArray(array);
        }
        static int[] sortArray(int[] array)
        {
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int element1 = array[i];
                    int element2 = array[i + 1];
                    if (element1 > element2)
                    {
                        array[i] = element2;
                        array[i + 1] = element1;
                        flag = true;
                    }
                }
            } while (flag);
            return array;
        }
        static void printArray(int[] array)
        {
            string txt = "[";
            for (int i = 0; i < array.Length; i++)
            {
                txt += array[i];
                if (i < array.Length - 1)
                {
                    txt += ", ";
                }
            }
            txt += "]";
            System.Console.WriteLine(txt);
        }
    }
}