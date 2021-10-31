using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N = от 1 до 100");
            int N = int.Parse(Console.ReadLine());
            if (N < 1 ^ N > 100)
            {
                while (N < 1 ^ N > 100)
                {
                    Console.WriteLine("Ошибка! Введите число от 1 до 100");
                    N = int.Parse(Console.ReadLine());
                }
            }
            if (N % 10 == 1 & (N > 11 || N < 2))
            {
                Console.WriteLine($"{N} год");
            }
            else if (N % 10 == 2 || N % 10 == 3 || N % 10 == 4 )
            {
                Console.WriteLine($"{N} года");
            }
            else
            {
                Console.WriteLine($"{N} лет");
            }
        }
    }
}
