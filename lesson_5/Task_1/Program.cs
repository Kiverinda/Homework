using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст");
            string stringCustom = Console.ReadLine();
            File.WriteAllText("text.txt", stringCustom);
        }
    }
}
