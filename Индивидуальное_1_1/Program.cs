using System;

namespace Индивидуальное_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант №7
            double a, b, c, x;
            Console.WriteLine("Введите первое вещественное число a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое вещественное число b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое вещественное число c:");
            c = double.Parse(Console.ReadLine());
            if (b < c & c < a)
            {
                x = a - b;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            }
             else if (c < b & b < a )
            {
                x = a - c;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            }
             else if (c < a & a < b )
            {
                x = b - c;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            }
             else if (a < c & c < b )
            {
                x = b - a;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            }
             else if (b < a & a < c)
            {
                x = c - b;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            }
             else if (a < b & b < c)
            {
                x = c - a;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            }
             else if (a == b && a==c)
            {
                Console.WriteLine("Все числа равны");
            }
            else if (a == b & b < c)
            {
                x = c - a;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            } 
            else if (b == c & b < a)
            {
                x = a - c;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            } 
            else if (a == c & c < b)
            {
                x = b - c;
                Console.WriteLine($"Разность максимального и минимального чисел равна: {x}");
            } 
        }
    }
}
