using System;


namespace Task_2
{
    class Program
    {

        static void Main(string[] args)
        {

            // Вариант 1
            //Console.WriteLine("Введите номер месяца");
            //int month = Convert.ToInt32(Console.ReadLine());
            //switch (month)
            //{
            //    case 1: 
            //        Console.WriteLine("Январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("Февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("Март");
            //        break;
            //    case 4:
            //        Console.WriteLine("Апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("Май");
            //        break;
            //    case 6:
            //        Console.WriteLine("Июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("Июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("Август");
            //        break;
            //    case 9:
            //        Console.WriteLine("Сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("Октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("Декабрь");
            //        break;
            //    default:
            //        Console.WriteLine("Не корректный ввод номера месяца");
            //        break;
            //}




            // Вариант 2 (с проверкой введенных данных и использованием массива для хранения названия месяцев) 
            //string[] Month = {"Январь",
            //                    "Февраль",
            //                    "Март",
            //                    "Апрель",
            //                    "Май",
            //                    "Июнь",
            //                    "Июль",
            //                    "Август",
            //                    "Сентябрь",
            //                    "Октябрь",
            //                    "Ноябрь",
            //                    "Декабрь" };

            //Console.WriteLine("Введите номер месяца");
            //do
            //{
            //    if (int.TryParse(Console.ReadLine(), out int numberMonth))
            //    {
            //        if (numberMonth > 0 && numberMonth < 13)
            //        {
            //            Console.WriteLine($"Месяц: {Month[numberMonth - 1]}");
            //            break;
            //        }
            //        else Console.WriteLine("Не корректный ввод номера месяца");
            //    }
            //    else Console.WriteLine("Не корректный ввод номера месяца");
            //} while (true);

            // Вариант 3 (с использованием enum) 
            Console.WriteLine("Введите номер месяца");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            if (((int)(Math.Pow(2, number - 1)) & (int)Months.Winter) == (int)(Math.Pow(2, number - 1))) Console.WriteLine("Зима");
            Console.ReadLine();
        }

        [Flags]
        enum Months
        {
            January = 0b_000000000001,
            February = 0b_000000000010,
            December = 0b_100000000000,
            Winter = January | February | December
        }
    }
}
