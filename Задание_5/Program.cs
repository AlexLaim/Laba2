using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Программа выводящая на экран все комбинации  натуральных  чисел x, y, z,таких что x^3 + y^3 + z^3 = N");
            Console.WriteLine("Введите число N");
            double N = double.Parse(Console.ReadLine());           
                int j = 0;
                for (x = 0; x <= N; x++)
                {
                    
                    for (y = 0; y <= N; y++)
                    {
                        
                        for (z = 0; z <= N; z++)
                        {
                            
                            double sum = x*x*x + y*y*y + z*z*z;
                            if (sum == N)
                            {
                                Console.WriteLine($"{x}^3+{y}^3+{z}^3 = {N}");
                                j++;  
                            }                           
                        }
                    }
                }
                if (j == 0)
                {
                    Console.WriteLine("No such combinations!");
                }
            }
        }
    }
 

