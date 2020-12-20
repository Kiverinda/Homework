using System;

namespace Task_4
{
    class Program
    {

        static int numberInSeries = GetNumberSeries(); 
        static int[] arrayNymberFibonacci = new int[numberInSeries + 1];

        static void Main()
        {
            //Вывод только заданного элемента последовательности Фибонначи 
            Console.WriteLine(GetarrayNymberFibonacci(numberInSeries));
            // Вывод всей последовательности Фибонначи от 0 до заданного элемента
            foreach(int num in arrayNymberFibonacci)
            {
                Console.Write($"{num}  ");
            }

            Console.ReadLine();
        }
 
        static int GetNumberSeries()
        {
            int data;
            do
            {
                Console.WriteLine("Введите целое число");
                if (int.TryParse(Console.ReadLine(), out data)) break;
                else Console.Write("Ошибка: ");
            }
            while (true);
            return data;
        }

        static int GetarrayNymberFibonacci(int numberInSeries)
        {
            if (numberInSeries < 2)
            {
                arrayNymberFibonacci[1] = 1;
                return arrayNymberFibonacci[numberInSeries];
            } 
            else arrayNymberFibonacci[numberInSeries] = GetarrayNymberFibonacci(numberInSeries - 1) + GetarrayNymberFibonacci(numberInSeries - 2);

            return arrayNymberFibonacci[numberInSeries];
        }

    }
}
