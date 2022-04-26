using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Dynamic;
using System.Management;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processlist = Process.GetProcesses();//выводим на экран список запущенных процессов с именем и ID

            foreach (Process process in processlist)
            {
                Console.WriteLine($"Process: {process.ProcessName}  ID: {process.Id}");
            }

            Console.ReadKey();


            //не смог сделать вторую часть задачи. Увы.


            //Console.WriteLine("Ведите ID процесса, который вы хотите остановить");
            //string numberId = Console.ReadLine();

            //processlist = null;

            //processlist = Process.GetProcesses(numberId);

            //foreach (Process process in processlist)
            //{
            //    process.Kill();
            //}
            //Console.ReadKey();


        }


    }

}

