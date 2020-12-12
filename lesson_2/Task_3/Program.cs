using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            do
            {
                Console.WriteLine("Введите число");
                if (int.TryParse(Console.ReadLine(), out data)) break;
                else Console.WriteLine("Не корректные данные.\nВведите целое число");
            }
            while (true);

            if (data % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное число");
            }
            else
            {
                Console.WriteLine("Вы ввели не четное число");
            }
            Console.ReadLine();
        }
    }
}
