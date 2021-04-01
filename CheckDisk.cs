using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ToHomework
{
    class CheckDisk
    {
        public void RunProcess(string DiskName)
        {
            string dirName = $@"{DiskName}";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
