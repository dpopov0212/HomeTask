using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now}].");
            Console.ReadKey();

        }
    }
}
