﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: "); //вводим произвольную строку и сохраняем ее в файл myfile.txt
            string mystring = Console.ReadLine();
            File.WriteAllText(@"C:\Users\intel\source\repos\TASK\my1file.txt", mystring);

            Console.ReadKey();
        }
    }
}
