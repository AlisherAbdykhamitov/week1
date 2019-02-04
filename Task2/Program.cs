using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public string yearofstudy;
        /* создал 3 стринга (public  - name , id , yearofstudy)*/ 
    
    public Student(string name, string id , string yearofstudy)
        {
            this.name = name;
            this.id = id;
            this.yearofstudy = yearofstudy;
                /* "this" это команда , которя присваивает значение к какому либо классу */
        }
        public void Taken()
        {
            Console.WriteLine(name + " " + id + " " + yearofstudy);
            /* Это у нас функция которые должна выводить нам Имя , айди его , и год учения  */
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Student ktk = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());/*задаем значения имя, айди и год обучения */
            ktk.Taken();/*закидываем в функция ,чтоб  вывести все на наш экран*/

        }
    }
}
