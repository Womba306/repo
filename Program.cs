using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Как  тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {thisDay.ToString("D")}");
        }
    }

}
