using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Запишите значение a");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Запишите значение b");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Запишите значение c");
            double c = double.Parse(Console.ReadLine());
            if (a < 45 && b >= 45 && c >= 45)
            {
                Console.Write("Условие является истинным");
            }
            else if (a >= 45 && b < 45 && c >= 45)
            {
                Console.Write("Условие является истинным");
            }
            else if (a >= 45 && b >= 45 && c < 45)
            {
                Console.Write("Условие является истинным");
            }
            else
            {
                Console.Write("Условие не является истинным");
            }
        }
    }
}
