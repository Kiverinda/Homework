using System;


namespace Task_2
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            string text = Console.ReadLine();
            string[] number = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string str in number)
            {
                Int32.TryParse(str, out int result);
                sum += result;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
