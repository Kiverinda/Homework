using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 2];
            //Заполнение массива
            string[] arrayNames = {"Вася", "Петя", "Коля", "Вова", "Дима", "Марина", "Света", "Оля", "Лена", "Таня"};
            Random randomize = new Random();
            for (int i = 0; i < 5; i++)
            {
                array[i, 0] = arrayNames[randomize.Next(10)];
                array[i, 1] = randomize.Next().ToString("0000000000");
;
            }
            //Вывод массива в консоль
            for(int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Имя: {array[i, 0],-10} Номер телефона: 8-{array[i, 1]}");
            }
            Console.ReadLine();
        }
    }
}
