using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string b = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            var c = Console.ReadLine();

            Console.WriteLine("Введите ваш рост:");
            var d = Console.ReadLine();
            
            Console.WriteLine("Введите ваш вес:");
            var e = Console.ReadLine();
            
            Console.WriteLine(a + b + c + d + e);
            Console.WriteLine(a + b + c + d + e);
            Console.WriteLine(a + b + c + d + e);
            Console.ReadKey();
        }
    }
}
