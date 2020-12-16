using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите фразу");
            string stringUser = Console.ReadLine();
            
            for(int i = stringUser.Length; i > 0; i--)
            {
                Console.Write(stringUser[i - 1]);
            }
            
            Console.ReadLine();
        }
    }
}
