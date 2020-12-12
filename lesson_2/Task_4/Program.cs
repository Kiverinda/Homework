using System;


namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Получение исходных данных от пользователя
                float maxTemperature = GetTemperature("Введите максимальную тепературу за сутки.");
                float minTemperature = GetTemperature("Введите минимальную тепературу за сутки.");
                int numberMonth = GetMonth();
                //Вычисление среднесуточной температуры
                float averageTemperature = (maxTemperature + minTemperature) / 2;
                //Если пользователь указал месяц из зимнего периода, а средняя температура > 0, выводится сообщение “Дождливая зима”
                if (IsWinter(numberMonth) && averageTemperature > 0) Console.WriteLine("Дождливая зима");
                
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Получение от пользователя значений теператур и проверка полученных данных
        /// </summary>
        /// <param name="message">Сообщение пользователю</param>
        /// <returns></returns>
        static float GetTemperature(string message)
        {
            float data;
            do
            {
                Console.WriteLine(message);
                if (float.TryParse(Console.ReadLine(), out data)) break;
                else Console.WriteLine("Не корректные данные.\nВведите целое число или дробь с запятой в качестве разделителя");
            }
            while (true);
            return data;
        }
        /// <summary>
        /// Получение от пользователя номера месяца и проверка полученных данных
        /// </summary>
        /// <returns></returns>
        static int GetMonth()
        {
            int data;
            do
            {
                Console.WriteLine("Введите номер месяца");
                if (int.TryParse(Console.ReadLine(), out data)) break;
                else Console.WriteLine("Не корректные данные.\nВведите целое число");
            }
            while (true);
            return data;
        }

        /// <summary>
        /// Проверка на принадлежность месяца зимнему периоду. Метод возвращает true или false
        /// </summary>
        /// <param name="month">Номер месяца</param>
        /// <returns></returns>
        static bool IsWinter(int month)
        {
            if (month == 1 || month == 2 || month == 12) return true;
            else return false;
        }
    }
}
