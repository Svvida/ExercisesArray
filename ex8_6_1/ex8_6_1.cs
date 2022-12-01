using System;
using System.Linq;
using System.Collections.Generic;

namespace exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("Input number of List elements: ");
            int numberOfListElements = Convert.ToInt16(Console.ReadLine());
            List<int> list = new List<int>(numberOfListElements);
            int i;
            for (i = 2; i < numberOfListElements; i++)
            {
                list.Add(i);
            }


            int squareOfNumberOfListElements = Convert.ToInt16(Math.Sqrt(numberOfListElements));
            int k;
            for (k = 2; k < squareOfNumberOfListElements + 1; k++)
            {
                for (i = 2; i < list.Count; i++)
                {
                    if (list[i] % k == 0 && list[i] > k)
                    {
                        list.Remove(list[i]);
                    }
                }
            }


            System.Console.WriteLine("Primary numbers: ");
            for (int w = 0; w < list.Count; w++)
            {
                System.Console.WriteLine(list[w]);
            }
        }
    }
}