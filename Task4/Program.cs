﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] b = new int[n, n];
            Console.WriteLine("Двумерный массив by Alisher");


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]" + " ");

                }
            }
            Console.ReadKey();

        }
    }
}