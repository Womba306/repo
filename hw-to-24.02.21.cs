using System;
using System.ComponentModel.DataAnnotations;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == i)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }

                Console.WriteLine();
            }

            // №2
            Console.WriteLine();
            Console.WriteLine("Введите имя пользователя, нажмите Enter для использавания по умолчанию");
            string name = Console.ReadLine();
            string[] TeleName = new string[] { };
            if (name == "")
            {
                TeleName = new string[4] {"Dmitry", "Alex", "Viktor", "Jo"};
            }
            else
            {
                while (name != "") //как сделать такой вывод???
                {
                    int LengthTeleName = 0;
                    Console.WriteLine("Введите имя пользователя");
                    name = Console.ReadLine();
                    TeleName[LengthTeleName++] = name;
                }
            }
            Console.WriteLine("Введите номер пользователя, нажмите Enter для использавания по умолчанию");
            string number = Console.ReadLine();
            string[] TeleNumber = new string[] { };
            if (number == "")
            {
                TeleNumber = new string[4] {"89267814675", "8962485617", "89124562341", "84995482454"};
                
            }
            else
            {
                while (number != "") //как сделать такой вывод???
                {
                    int LengthTeleName = 0;
                    Console.WriteLine("Введите номер пользователя");
                    number = Console.ReadLine();
                    TeleName[LengthTeleName++] = number;
                }
            }

            for (int w = 0; w < 4; w++)
            {
                Console.Write(TeleName[w] + "-" + TeleNumber[w]);
                Console.WriteLine("");
            }


            //№3
            Console.WriteLine();
            Console.WriteLine("Введите слово");
            var str1 = Console.ReadLine();
            char[] massName = str1.ToCharArray();
            for (int Nmass = massName.Length; Nmass > 0; --Nmass)
            {
                Console.Write(massName[Nmass - 1]);
            }
        }
    }
}

