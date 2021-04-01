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
            CheckDisk list = new CheckDisk();
            Console.WriteLine("help - для вывода справки");
            string[] ReservCheck = { null, @"C:\" };
            string DetectComand = Console.ReadLine();
            string dirName = @"C:\";
            string[] Check = DetectComand.Split(' ');
            while (Check[0]!="exit") 
            {
                
                if (Check[0] == "help")
                {
                    Help();
                }
                if (Check[0] == "list")
                {
                    
                    list.RunProcess(dirName);
                }
                if (Check.Length == 1)
                {
                    ReservCheck[0] = Check[0];
                    Check = ReservCheck;
                }
                dirName = Check[1];
                if (Check[0] == "del")
                {
                    string[] files = Directory.GetFiles(dirName);
                    int indexOfChar = files.IndexOf(".");
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].EndsWith("."))
                            File.Delete(files[i]);
                    }
                    //DeleteFile(dirName);
                    DeleteFold(dirName);
                }
                if (Check[0] == "cd")
                {
                    dirName = Check[1];
                    Console.WriteLine("");
                    list.RunProcess(dirName);
                }
                ReservCheck = new string[] { null, dirName };
                DetectComand = Console.ReadLine();
                Check = DetectComand.Split(' ');

            }
        }
        static void Help()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("cd {Ваша папка} - смена папки");
            Console.WriteLine("del {Ваша папка/файла} - удаление папки/файла");
            Console.WriteLine("exit - для выхода из мэнаджера");
            Console.WriteLine("list {Ваша папка} - показывает содержимое текущей папки");
            
        }
        //static void DeleteFile(string FileName)
        //{
        //    File.Delete(FileName);
        //    Console.WriteLine($"Файл {FileName} удален");
        //}
        static void DeleteFold(string DirName)
        { 
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(DirName);
                dirInfo.Delete(true);
                Console.WriteLine($"Каталог {DirName} удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
