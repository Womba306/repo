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
            Console.WriteLine("Введите сколько пользователей вы хотите добавить, нажмите Enter для использавания по умолчанию");
            string numbw = Console.ReadLine();
            int numb = 0;
            
            if (numbw == "")
            { 
                numb = 4;
                Console.WriteLine();
                Console.WriteLine("Введите имя пользователя, нажмите Enter для использавания по умолчанию");
            }
            else
            {
                numb = Convert.ToInt16(numbw);
                Console.WriteLine("Введите имя пользователя");
            }
            int Numbre = numb;
            string name = Console.ReadLine();
            string[] TeleName = new string[numb];
            if (name == "" )
            {
                TeleName = new string[4] {"Dmitry", "Alex", "Viktor", "Jo"};
            }
            else
            {
                
                for (;numb>1;numb--)
                {
                    int LengthTeleName = 0;
                    Console.WriteLine("Введите имя пользователя");
                    name = Console.ReadLine();
                    TeleName[LengthTeleName++] = name;
                }
            }
            int LengthTeleNumber = 0;
            Console.WriteLine($"Введите номер пользователя-{TeleName[LengthTeleNumber]}, нажмите Enter для использавания по умолчанию(до 4 друзей)");
            string number = Console.ReadLine();
            string[] TeleNumber = new string[Numbre];
            TeleNumber[2] = number;
            if (number == "")
            {
                TeleNumber = new string[4] {"89267814675", "8962485617", "89124562341", "84995482454"};

            }
            else
                Console.WriteLine(TeleNumber.Length); 
                Console.WriteLine(TeleName.Length);
            {
                for (;LengthTeleNumber<Numbre;)
                {
                    Console.WriteLine($"Введите номер пользователя-{TeleName[LengthTeleNumber]}");
                    number = Console.ReadLine();
                    TeleNumber[LengthTeleNumber++] = number;
                    Console.WriteLine(LengthTeleNumber);
                }
            }

            for (int w = 0; w < TeleName.Length; w++)
            {
                Console.Write(TeleName[w] + "-" + TeleNumber[w]);
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
            
            //"Морской бой"
        }
    }
}

