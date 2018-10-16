using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Cech("Pepa Novak", 1, 1),
                new Slovak("Jano Mucha", 2, 1.2f),
                new Cizinec("Alfons Krajka", 1, false),
                new Cech("Jarda konepasek", 5, 222),
                new Slovak("Dalsi Novak", 2, 4.5f),
                new Cizinec("What the hell", 22, false),
                new Cech("Pepa Novak", 5, 222),
                new Slovak("Neznam Slovenske", 5, 1.2f),
                new Cizinec("Krivak", 22, false),
                new Cech("Pepa Novak", 5, 222),
                new Slovak("Jmena tak", 2, 1.2f),
                new Cizinec("Krejta obrovska", 22, false),
                new Cech("Pepa Novak", 5, 222),
                new Slovak("Pisu Kraviny", 2, 1.2f),
                new Cizinec("Kazdy bude novak", 22, false),
                new Cech("Pepa Novak", 5, 222),
                new Slovak("Aspon Aby", 2, 1.2f),
                new Cizinec("Alfons Krajka", 22, false),
            };

            students.ForEach((student) =>
            {
                Console.WriteLine($"{student.GetPopis()}\n");
            });

        }
    }
}
