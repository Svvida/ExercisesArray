using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace exercise
{
    internal class Program
    {


        static ArrayList naCzynniki(double liczba)
        {
            ArrayList lista = new ArrayList();
            int k = 2;
            while (liczba != 1)
            {
                while (liczba % k == 0)
                {
                    lista.Add(k);
                    liczba = liczba / k;
                }
                k++;
            }
            return lista;
        }


        static void Main(string[] args)
        {
            System.Console.Write("Pleace enter number you want to factorize: ");
            int yourNumber = int.Parse(System.Console.ReadLine());

            ArrayList czynniki = naCzynniki(yourNumber);
            foreach (var czynnik in czynniki)
            {
                Console.WriteLine(czynnik);
            }

        }
    }
}