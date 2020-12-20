using System;


namespace Task_1
{
    class Program
    {
        //Вариант 1
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную тепературу за сутки.");
            Decimal maxTemperature = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите мминимальную тепературу за сутки.");
            Decimal minTemperature = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Среднесуточная тепература = {(maxTemperature + minTemperature) / 2}{'\u00b0'.ToString()}С");
            Console.ReadLine();
        }


        // Вариант 2 (с проверкой на корректность введенных данных при помощи TryParse. Можно, конечно, обработать исключения, но так проще :) )
        //static void Main(string[] args)
        //{
        //    float maxTemperature = GetData("Введите максимальную тепературу за сутки.");
        //    float minTemperature = GetData("Введите минимальную тепературу за сутки.");
        //    float averageTemperature = (maxTemperature + minTemperature) / 2;
        //    Console.WriteLine($"Среднесуточная тепература = {averageTemperature} {'\u00b0'.ToString()}С");
        //    Console.ReadLine();
        //}

        //static float GetData(string message)
        //{
        //    float data;
        //    do
        //    {
        //        Console.WriteLine(message);
        //        if (float.TryParse(Console.ReadLine(), out data)) break;
        //        else Console.WriteLine("Не корректные данные.\nВведите целое число или дробь с запятой в качестве разделителя");
        //    }
        //    while (true);
        //    return data;
        //}
    }
}
