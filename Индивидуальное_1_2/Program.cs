using System;

namespace Индивидуальное_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант №7
            Console.WriteLine("Программа выводит на экран все двузначные числа, сумма цифр которых делится на 5");
            int i;
            for (i = 10; i <= 99; i ++)
            {
                if (((i / 10) + (i % 10)) % 5 == 0) Console.WriteLine(i);
            }
        }
    }
}
