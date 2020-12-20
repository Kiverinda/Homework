using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9,9];
            //Заполнение массива случайными целыми числами от 0 до 9
            Random randomize = new Random();
   
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = randomize.Next(10);
                }
            }

            // Значения ячеек в главной диагонали
            for(int i = 0; i < array.GetLength(1); i++) Console.Write(array[i , i]);
            
            // Главная диагональ в массиве
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    Console.Write(array[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
