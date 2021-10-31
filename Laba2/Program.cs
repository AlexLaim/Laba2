using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Программа для решения квадратных уравнений вида: ax^2+bx+c=0");
                Console.WriteLine("Введите число a: ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    while (a == 0)
                    {
                        Console.WriteLine("Коэффициент а не может быть равен нулю! Введите число отличное от нуля.");
                        a = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Введите число b: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число c: ");
                c = int.Parse(Console.ReadLine());
            double P = Math.Pow(b, 2) - 4 * a * c;
            double D = Math.Sqrt(P);
            if (P < 0)
            {
                Console.WriteLine("Уравнение не имеет корней!");
                Console.WriteLine("Представим результат в виде комплексных чисел");
                double z1 = Math.Sqrt(-P) / 2 * a;
                double z2 = -b / 2 * a;
                Console.WriteLine($"x1={z2}+{z1}i; \a x2={z2}-{z1}i");
            }
            if (D == 0)
            {
                double X1 = -b / 2 * a;
                Console.WriteLine($"Уравнение имеет 1 корень: x1 = {X1}");
            }
            double x1 = (-b - D) / 2 * a;
            if (x1 < 0 ^ x1 > 0 & D != 0)
            {
                Console.WriteLine($"Первый корень уравнения равен: {x1}");
            }
            double x2 = (-b + D) / 2 * a;
            if (x2 < 0 ^ x2 > 0 & D != 0)
            {
                Console.WriteLine($"Второй корень уравнения равен: {x2}");
            }
        }
    }
            
}
    
