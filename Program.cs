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
                console.writeline("введите фамилию");
                string n1 = console.readline();
                console.writeline("введите имя");
                string n2 = console.readline();
                console.writeline("введите отчество");
                string n3 = console.readline();
                console.writeline(getfullname(n1, n2, n3));

            }
            Console.WriteLine("ввыдите масив цыфр через пробел");
            Console.WriteLine(GetSum(Console.ReadLine()));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }

        static int GetSum(string inputLine)
        {
          
            string[] splitted = inputLine.Split(' ');
            int[] nums = new int[splitted.Length];
            int summ = 0;
            for (int j = 0; j < splitted.Length; j++)
            {
                nums[j] = int.Parse(splitted[j]);
                summ += nums[j];
            }
            return summ;
        }

        static YearsSeason Monat(int MonatNum)
        {
            YearsSeason season = YearsSeason.None;
            while(season==YearsSeason.None)
            { 
                switch (MonatNum)
                {
                    case 12:
                    case 1:
                    case 2:
                        season = YearsSeason.Winter;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = YearsSeason.Spring;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = YearsSeason.Summer;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = YearsSeason.Autumn;
                        break;

                }
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            return season;
        }


        [Flags]
        public enum YearsSeason
        {
            Winter = 0,
            Spring,
            Summer,
            Autumn,
            None
        }
    }
}

