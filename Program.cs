using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskLesson2
{
    class Program
    {
        static void Main(string[] args)//отображение названия месяца по порядковому номеру
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int monthOfYear = Convert.ToInt32(Console.ReadLine());

            string monthTitle = "";
            switch (monthOfYear - 1)
            {
                case 0:
                    monthTitle = "Январь";
                    break;
                case 1:
                    monthTitle = "Февраль";
                    break;
                case 2:
                    monthTitle = "Март";
                    break;
                case 3:
                    monthTitle = "Апрель";
                    break;
                case 4:
                    monthTitle = "Май";
                    break;
                case 5:
                    monthTitle = "Июнь";
                    break;
                case 6:
                    monthTitle = "Июль";
                    break;
                case 7:
                    monthTitle = "Август";
                    break;
                case 8:
                    monthTitle = "Сентябрь";
                    break;
                case 9:
                    monthTitle = "Октябрь";
                    break;
                case 10:
                    monthTitle = "Ноябрь";
                    break;
                case 11:
                    monthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Укажите значение от 1 до 12");
                    break;
            }

            Console.WriteLine(monthTitle);
            Console.ReadKey();
        }
    }
}
