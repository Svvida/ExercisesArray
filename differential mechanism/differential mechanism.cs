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

        static double f(double x)
        {
            return x * x + 2 * x + 3;
        }
        static void Main(string[] args)
        {
            double poczatek = 0;
            double koniec = 10;
            double h = 0.01;
            int n = (int)((koniec - poczatek) / h);

            double pole = 0;
            for (int i = 0; i < n; i++)
            {
                double x0 = poczatek + i * h;
                double x1 = x0 + h;
                double a = f(x0);
                double b = f(x1);
                double poleTrapezu = ((a + b) / 2) * h;
                pole = pole + poleTrapezu;
            }
            System.Console.WriteLine(pole);
        }
    }
}