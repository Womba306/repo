using System;
using System.Collections.Generic;
using System.Text;

namespace ToHomework
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] Drives = Environment.GetLogicalDrives();
            Console.WriteLine("Доступные диски:");
            string[] YourDiskToReturn = new string[Drives.Length];
            for (int runs = 0; runs < Drives.Length; runs++)
            {
                YourDiskToReturn[runs] = $"{runs+1} - {Drives[runs]}";
                Console.WriteLine(YourDiskToReturn[runs]);
            }
            Console.WriteLine(@"Выберите диск для вывода файлов");
            string ReturnDiskNum = Console.ReadLine();
            int ReturnDiskName = int.Parse(ReturnDiskNum);
            while (ReturnDiskName>Drives.Length || ReturnDiskName < 1)
            {
                Console.WriteLine($"Введите число от 1 до {Drives.Length}");
                ReturnDiskName = Console.Read();
                Console.WriteLine(ReturnDiskName);
            }
            CheckDisk disc = new CheckDisk();
            disc.RunProcess(Drives[ReturnDiskName-1]);
            DoDisk dodisk = new DoDisk();
            dodisk.RunProcess();
            
        }
    }
}
