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
            string[] YourDisk = new string[Drives.Length];
            string[] YourDiskToReturn = new string[Drives.Length];
            for (int runs = 0; runs < Drives.Length; runs++)
            {
                YourDiskToReturn[runs] = $"{runs+1} - {Drives[runs]}";
                Console.WriteLine(YourDiskToReturn[runs]);
            }
            Console.WriteLine(@"Выберите диск для вывода файлов"); 
            int ReturnDiskName = Console.Read();
            CheckDisk disc = new CheckDisk();
            disc.RunProcess(Drives[ReturnDiskName]); //ломаеться тут
        }
    }
}
