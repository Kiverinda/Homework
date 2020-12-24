using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Task_5
{
    class Program
    {
        static void Main()
        {
            string pathToFile = "tasks1.json";
            if (!File.Exists(pathToFile)) File.WriteAllText(pathToFile, "[]");

            List<ToDo> task = new List<ToDo>();
            task = GetTask(pathToFile);
            WriteConsole(task);

            string userAction = "";
            
            while (true) {

                Console.WriteLine("Введите номер задачи, что бы отметить выполнение или Q для выхода");
                Console.WriteLine("Для добавления задачи введите А для удаления задачи из списка D \n");
                userAction = Console.ReadLine();

                if (int.TryParse(userAction, out int numberTask) && (numberTask - 1) <= task.Count)
                {
                    task[numberTask - 1].IsDone = true;
                    WriteConsole(task);
                }
                else if (userAction == "A" || userAction == "a")
                {
                    Console.WriteLine("Введите задачу");
                    task.Add(new ToDo(Console.ReadLine()));
                    WriteConsole(task);
                }
                else if (userAction == "D" || userAction == "d")
                {
                    Console.WriteLine("Введите номер задачи");
                    task.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                    WriteConsole(task);
                }
                else if (userAction == "Q" || userAction == "q")
                {
                    SetTask(task, pathToFile);
                    break;
                }
            }


        }

        static List<ToDo> GetTask(string pathToFile)
        {
            string json = File.ReadAllText(pathToFile);
            return JsonSerializer.Deserialize<List<ToDo>>(json);
        }
        static void SetTask(List<ToDo> task, string pathToFile)
        {
            string json = JsonSerializer.Serialize(task);
            File.WriteAllText(pathToFile, json);
        }
        static void WriteConsole(List<ToDo> task)
        {
            if (task != null)
            {
                Console.WriteLine();
                for (int i = 0; i < task.Count; i++)
                {
                    string str = " ";

                    if (task[i].IsDone) str = "X";
                    Console.WriteLine($"{i + 1}     {task[i].Title}   {str}");
                }
                Console.WriteLine();
            }
        }

    }
}
