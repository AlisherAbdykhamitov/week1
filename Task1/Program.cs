using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static bool f(int n)
        {
            /* это у нас функция , которая находит Prime числа, это числа которые делять на 1 и на самого себя */
            if (n <= 1) return false;
            else
            {
                bool k = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        k = false;
                        break;
                    }
                }
                return k;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); /* Количество элементов массива */
            string s = Console.ReadLine(); /* */
            string[] a = s.Split();/* создаем массив стрингов которых разбиваем на подстроки с помощью s.Split*/
            int[] b = new int[n]; /* у нас массив с количеством n */ 
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]); /* массив стрингов делаем массивом челых чисел sting -> int , через int.Parse() */ 
            }
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (f(b[i]) == false) b[i] = 0;/*закидываем каждый элемент массива в функцию , чтоб проверить является ли число Prime? */
                else cnt++;
            }
            Console.WriteLine(cnt);/*показываем на экране количество чисел */ 
            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0) Console.Write(b[i] + " ");/* Prime числа на экране*/

            }
           
        }

    }
}
