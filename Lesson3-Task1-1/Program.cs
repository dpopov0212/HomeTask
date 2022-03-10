using System;

namespace Lesson3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myarray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.Write("\n Диагональ: \n");
            for (int i = 0; i < myarray.GetLength(0); i++) //отображение диагонали массива
            {
                Console.Write(myarray[i, i] + "  ");
            }

        }
    }
}