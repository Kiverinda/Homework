using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            File.AppendAllText("startup.txt", $"\n{DateTime.Now.ToLongTimeString()}");
        }
    }
}
