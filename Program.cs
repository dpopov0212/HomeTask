using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLesson_2
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
