using System;

namespace Lesson2_Task1
{
    class Program
    {
        static void Main(string[] args)//отображение среднесуточной температуры
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            double mintemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxtemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Среднесуточная температура за сутки составляет: {(mintemp + maxtemp) / 2 }");
            Console.ReadKey();
        }
    }
}
