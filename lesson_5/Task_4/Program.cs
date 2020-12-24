using System;
using System.Collections.Generic;
using System.IO;



namespace Task_4
{
    class Program
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
        static void Main()
        {
            string pathFileToWriteRecurs = "recurs.txt";
            string pathFileToWriteStack = "stack.txt";
            Console.WriteLine("Введите путь к директории");
            string pathDirectory = Console.ReadLine();
            DirectoryInfo rootDir = new DirectoryInfo(pathDirectory);
            WriteRecurs(rootDir, pathFileToWriteRecurs);
            WriteStack(pathDirectory, pathFileToWriteStack);
            Console.ReadLine();
        }
        static void WriteRecurs(DirectoryInfo root, string pathFileToWrite)
        {
            FileInfo[] files = default;
            DirectoryInfo[] subDir;
            try
            {
                File.AppendAllText(pathFileToWrite, $"\n{root.FullName}");
                files = root.GetFiles("*.*");
            }
            catch(UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            if (files != null)
            {
                foreach (FileInfo fi in files) File.AppendAllText(pathFileToWrite, $"\n{fi.FullName}");


                subDir = root.GetDirectories();
                foreach (DirectoryInfo dirInfo in subDir) WriteRecurs(dirInfo, pathFileToWrite);
            }
            
        }

        static void WriteStack(string root, string pathFileToWrite)
        {
            Stack<string> dirs = new Stack<string>(20);
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dirs.Push(root);
            while(dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                File.AppendAllText(pathFileToWrite, $"\n{currentDir}");
                string[] subDirs;
                try
                {
                    subDirs = Directory.GetDirectories(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(currentDir);
                }
                catch(UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                foreach(string file in files)
                {
                    try
                    {
                        FileInfo fi = new FileInfo(file);
                        File.AppendAllText(pathFileToWrite, $"\n{fi.FullName}");
                    }
                    catch(FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                foreach(string str in subDirs)
                {
                    dirs.Push(str);
                }
            }
        }
    }
}
