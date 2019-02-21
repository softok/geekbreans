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
            Console.WriteLine("Введите ваш вес:");

            double m = double.Parse (Console.ReadLine());
           
            Console.WriteLine("Введите ваш рост:");
            double h = double.Parse (Console.ReadLine());
            double i = m/(h*h);
            Console.WriteLine("Индекс массы тела = " + i);

            Console.ReadKey();

        }
    }
}
