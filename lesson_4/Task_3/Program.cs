using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            int numberMonth = GetMonth();
            Console.WriteLine(GetSesonYear(numberMonth));
            Console.ReadLine();
        }
        
        static string GetSesonYear(int numberMonth)
        {
            if (((int)SesonYear.Winter & (int)Math.Pow(2, numberMonth - 1)) == (int)Math.Pow(2, numberMonth - 1)) return SesonYear.Winter.ToString();
            if (((int)SesonYear.Spring & (int)Math.Pow(2, numberMonth - 1)) == (int)Math.Pow(2, numberMonth - 1)) return SesonYear.Spring.ToString();
            if (((int)SesonYear.Summer & (int)Math.Pow(2, numberMonth - 1)) == (int)Math.Pow(2, numberMonth - 1)) return SesonYear.Summer.ToString();
            return SesonYear.Autumn.ToString();
        }
        
        static int GetMonth()
        {
            int data;
            do
            {
                Console.WriteLine("Введите номер месяца");
                if (int.TryParse(Console.ReadLine(), out data)) break;
                else Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            while (true);
            return data;
        }

        [Flags]
        enum SesonYear
        { 
            Winter = 0b100000000011,
            Spring = 0b000000011100,
            Summer = 0b000011100000,
            Autumn = 0b011100000000
        };

    }
}
