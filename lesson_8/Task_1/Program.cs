using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Properties.Settings.Default.greeting);
            
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userName)) Console.WriteLine($"Ваше имя: {Properties.Settings.Default.userName}");
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userAge)) Console.WriteLine($"Ваш возраст: {Properties.Settings.Default.userAge}");
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userTypeActivity)) Console.WriteLine($"Ваше род деятельности: {Properties.Settings.Default.userTypeActivity}");

            SetDataUser();
            
            Console.ReadLine();
        }

        static void SetDataUser()
        {
            Console.WriteLine("\nВведите имя");
            Properties.Settings.Default.userName = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            Properties.Settings.Default.userAge = Console.ReadLine();
            Console.WriteLine("Введите род деятельности");
            Properties.Settings.Default.userTypeActivity = Console.ReadLine();
            Properties.Settings.Default.Save();
        }
    }
}
