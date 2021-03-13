using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любой текст");
            string TextToFile = Console.ReadLine();
            File.WriteAllText("D:\\new_file.txt", $"{TextToFile}");
            DateTime date1 = new DateTime();
            File.WriteAllText("D:\\startup.txt", $"{date1}");
            string path = @"D:\\data.dat";
            Console.WriteLine("Введите любой текст");
            string text = Console.ReadLine();
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                byte[] input = Encoding.Default.GetBytes(text);
                writer.Write(input, 0, input.Length);
                Console.WriteLine("Текст записан в файл");
                string textFromFile = Encoding.Default.GetString(input);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }
    }
}

