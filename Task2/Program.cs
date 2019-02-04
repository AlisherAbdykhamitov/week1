using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public name;
        public id;
        public yearofstudy;
    
    public Student(name, id , yearofstudy)
    {
        a.name = name;
        a.id = id;
        a.yearofstudy = yearofstudy;
          
    }
        public void Getinfo()
        {
            Cosole.WriteLine(name + " " + id + " " + yearofstudy);
        }
    
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Student ktk = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            ktk.Getinfo();
            
        }
    }
}
