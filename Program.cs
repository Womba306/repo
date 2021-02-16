using System;

namespace main
{
    public enum Monat
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Максимальная температура воздуха");
            string temp1 = Console.ReadLine();
            Console.WriteLine("Минимальнуя температура воздуха");
            string temp2 = Console.ReadLine();
            float temp = ((float.Parse(temp1) + float.Parse(temp2)) / 2);
            Console.WriteLine($"Средная температура воздуха {temp}");
            Console.WriteLine("Какой сейчас месяц(номер)");
            string mon = Console.ReadLine();
            for (int i = 1; i < 14; i++)
            {
              if (i==(int.Parse(mon)))
              {
                  Console.WriteLine((Monat)i);
                  if (((Monat)i==Monat.December || (Monat)i==Monat.February || (Monat)i==Monat.January) && temp>0)
                  {
                      Console.WriteLine("Дождливая зима");
                  }
              }
            }
            

            Console.WriteLine("Введите любое число");
            string number = Console.ReadLine();
            if (int.Parse(number) % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            
        }




    
    }

}