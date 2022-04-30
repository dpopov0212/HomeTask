using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число!");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число!");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine($"Число {first} > числа {second}");
            }

            else if (first < second)
            {
                Console.WriteLine($"Число {first} < числа {second}");

            }

            else
            {
                Console.WriteLine($"Число {first} = числу {second}");
            }

            Console.ReadKey();
        }
    }
}
