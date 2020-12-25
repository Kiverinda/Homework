using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255 через пробел");
            string stringCustom = Console.ReadLine();
            string[] numberStringCustom = stringCustom.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            byte[] numberByteCustom = new byte[numberStringCustom.Length];
            for(byte i = 0; i < numberStringCustom.Length; i++)
            {
                Byte.TryParse(numberStringCustom[i], out numberByteCustom[i]);
            }
            File.WriteAllBytes("bytes.bin", numberByteCustom);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");
            foreach (byte by in fromFile)
            {
                Console.WriteLine(by);
            }
            Console.ReadLine();
        }
    }
}
