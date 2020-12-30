using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Properties.Settings.Default.greeting);
            
            if (!string.IsNullOrEmpty(Properties.Settings.Default.userName)) 
            {
                string greeting = Properties.Settings.Default.greeting;
                string userName = Properties.Settings.Default.userName;
                string userAge = Properties.Settings.Default.userAge;
                string userTypeActivity = Properties.Settings.Default.userTypeActivity;

                Console.WriteLine($"Ваше имя: {userName}!");
                Console.WriteLine($"Ваш возраст: {userAge}");
                Console.WriteLine($"Ваш род деятельности: {userTypeActivity}");
            }

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
