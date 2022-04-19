using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел : \n ");
            int[] values = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
            int sum = GetSum(values);
            Console.WriteLine("Summa = {0}", sum);
            Console.ReadLine();
        }

        private static int GetSum(params int[] list)
        {
            return list.Sum();
        }
    }

}
