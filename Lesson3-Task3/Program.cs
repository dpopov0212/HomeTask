using System;

namespace Lesson3_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myword = "HELLO";

            for (int i = 0; i < myword.Length; i++)
            {
                Console.Write(myword[i] + " "); // вывод каждого символа строки
                
            }
            Console.WriteLine();

            for (int i = 0; i < myword.Length; i++)
            {
                System.Console.Write(myword[myword.Length - i - 1] + " "); // вывод каждого символа строки в обратном порядке

            }
            Console.WriteLine();
        }
    }
}
