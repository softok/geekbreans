using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double y1;
            double x2;
            double y2;

            Console.WriteLine("Введите координаты x1:");
            string s1 = Console.ReadLine();
            x1 = Convert.ToDouble(s1);
            Console.WriteLine("Введите координаты y1:");
            string s2 = Console.ReadLine();
            y1 = Convert.ToDouble(s2);
            Console.WriteLine("Введите координаты x2:");
            string s3 = Console.ReadLine();
            x2 = Convert.ToDouble(s3);
            Console.WriteLine("Введите координаты y2:");
            string s4 = Console.ReadLine();
            y2 = Convert.ToDouble(s4);
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
