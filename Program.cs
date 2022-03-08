using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLesson2
{
    class Program
    {
        static void Main(string[] args)//определение четного/нечетного числа
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            double ostatok = number % 2;//вычисление остатка от деления числа на 2

            if (ostatok == 0)
            {
                Console.WriteLine($"Выбранное Вами число четное");
            }

            else
            {
                Console.WriteLine($"Выбранное Вами число нечетное");
            }
            Console.ReadKey();
        }
    }
}
