﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split();
            int[] b = new int[n]; /* Создаю массив одномерный который состоит из  n чисел */
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]); /*передаю в массив числа из "a" стринга */

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " "); /* вывожу числа массива и все */
                Console.Write(a[i] + " ");

            }

        }
    }
}