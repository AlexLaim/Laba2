using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Вычисление числа P по заданной формуле: P/4 = 1 - 1/3 + 1/5 - 1/7 + 1/9 .... +");
            Console.WriteLine("Введите кол-во слагаемых");
            int Count = int.Parse(Console.ReadLine());
            double n = 3;
            double a = 1;
            while (i < Count)
            {
                a = a - (1 / n) + (1 / (n + 2));
                n = n + 4;
                i++;
            }    
            double P = a * 4;
            Console.WriteLine($"Значение P = {P}");
        }
    }
}
