using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найдите кол-во четырехзначных чисел в ряду Фибоначчи");  
            double f0 = 0;
            double f1 = 1;
            while (f1 < 1000)
            {
                double f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            int i = 0; 
            while (f1 < 10000)
            {
                double f = f0 + f1;
                f0 = f1;
                f1 = f;
                i++;
            }
            Console.WriteLine($"Кол-во четырехзначных чисел = {i}");
        }
    }
}
