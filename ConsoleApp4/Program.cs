using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Program
        {
            static void Main(string[] args)
            {
                int a = 1;     // Присваиваем начальное значение
                int b = 2;     // Присваиваем начальное значение
                int t = a;        // В t запоминаем значение a
                a = b;           // В a записываем b
                b = t;           // В b записываем сохраненное a
            }
        }

}
