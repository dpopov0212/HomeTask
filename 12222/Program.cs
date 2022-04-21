using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string mystring = Console.ReadLine();
            File.WriteAllText(@"C:\Users\intel\source\repos\TASK\my1file.txt", mystring);

            //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); 
            //TimeOnly time = new TimeOnly(); 
            File.AppendAllText(@"C:\Users\intel\source\repos\TASK\startup.txt", DateTime.Now.ToString("HH:mm:ss"));
            Console.ReadKey();
        }
    }
        
    
}
