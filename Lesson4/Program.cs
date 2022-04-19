using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        public static string GetFullName(string firstname, string lastname, string patronymic)//создание метода получающего ФИО
        {
            string fio = firstname + " " + lastname + " " + patronymic;
            return fio;
        }

        static void Main(string[] args)
        {

            string firstname = "Иван";
            string patronymic = "Иванович";
            string lastname = "Иванов";

            string firstname2 = "Петр";
            string patronymic2 = "Петрович";
            string lastname2 = "Петров";

            string firstname3 = "Дмитрий";
            string patronymic3 = "Павлович";
            string lastname3 = "Петров";


            Console.WriteLine(GetFullName(lastname, firstname, patronymic));
            Console.WriteLine(GetFullName(lastname2, firstname2, patronymic2));
            Console.WriteLine(GetFullName(lastname3, firstname3, patronymic3));
            Console.ReadKey();

        }

    }


}

