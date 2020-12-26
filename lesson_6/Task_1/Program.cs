using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string header = String.Format("{0, -30}{1, 18}{2, 18}\n",
                                "Name Process", "ID", "Memory /Kb");
            int numberLinesToConsole = 20; //Отрицательное значение отключает постраничный вывод

            IEnumerable<Process> sortInfoAllProcesses = Process.GetProcesses().OrderBy(p => p.Id);

            Console.WriteLine(header);
            ViewProcesses(sortInfoAllProcesses, numberLinesToConsole);
            SelectedProcess(sortInfoAllProcesses)?.Kill();
            Console.ReadLine();
        }

        private static Process SelectedProcess(IEnumerable<Process> sortInfoAllProcesses)
        {
            Console.WriteLine("\nВведите имя или Id процесса");
            string userData = Console.ReadLine();
            try
            {
                if (int.TryParse(userData, out int numberProcess)) return sortInfoAllProcesses.First(p => p.Id == numberProcess);
                else return sortInfoAllProcesses.First(p => p.ProcessName == userData);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Не верно указано имя или ID");
                return null;
            }
        }

        static void ViewProcesses(IEnumerable<Process> sortInfoAllProcesses, int numberLinesToConsole)
        {
            int count = 0;
            foreach (Process process in sortInfoAllProcesses)
            {
                Console.WriteLine($"{process.ProcessName,-30}{process.Id,18}{process.WorkingSet64 / 1024,18}");
                count++;
                if (count == numberLinesToConsole)
                {
                    Console.WriteLine("\nНажмите клавишу для продолжения...\n");
                    Console.ReadKey();
                    count = 0;
                }
            }
        }

    }
}
