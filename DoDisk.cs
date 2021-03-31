using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ToHomework
{
    class DoDisk
    {
        public void RunProcess()
        {
            Console.WriteLine("help - для вывода справки");
            string DetectComand = Console.ReadLine();
            string[] Check = new string[2];
            Check[1] = "";
            Check = DetectComand.Split(' ');
            string dirName = "C:\\SomeFolder";
            while (Check[0]!="exit") 
            {
                if (Check[0] == "help")
                {
                    Help();
                }
                else
                {
                    if (Check[1] == "")
                    {
                        dirName = "C:\\";
                    }
                    else
                    {
                        dirName = Check[1];
                    }
                    
                }
                if (Check[0] == "del")
                {
                    Delete(dirName);
                }
                if (Check[0] == "list")
                {
                    List(dirName);
                }
                DetectComand = Console.ReadLine();
                Check = DetectComand.Split(' ');
                if (Check[0] == "cd")
                {
                    dirName=Check[1];
                }
            }
        }
        static void Help()
        {
            Console.WriteLine("del {Ваша папка/файла} - удаление папки/файла");
            Console.WriteLine("exit - для выхода из мэнаджера");
            Console.WriteLine("list {Ваша папка} - показывает содержимое текущей папки");
            Console.WriteLine("cd {Ваша папка} - смена папки");
        }
        static void List(string DirName)
        {
            Console.WriteLine("Подкаталоги:");
            string[] dirs = Directory.GetDirectories(DirName);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(DirName);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
        }
        static void Delete(string DirName)
        { 
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(DirName);
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
