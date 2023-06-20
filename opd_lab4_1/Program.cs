/*
Функция Y=f(x), x1<=x<=x2, шаг - x3. Определить количество значений функции, 
превышающих среднее арифметическое чётных положительных значений.
С помощью оператора "for":
*/
using System;

namespace opd_lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("X2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("X3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            double sum = 0.0;
            int count = 0;
            int evenPositiveCount = 0;

            for (double x = x1; x <= x2; x += x3)
            {
                double y = x * x - 9;
                if (y % 2 == 0 && y > 0)
                {
                    sum += y;
                    evenPositiveCount++;
                }
            }

            if (evenPositiveCount == 0)
            {
                Console.WriteLine("Нет значений :(");
            }
            else
            {
                double average = sum / evenPositiveCount;

                for (double x = x1; x <= x2; x += x3)
                {
                    double y = x * x - 9;
                    if (y > average)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Количество значений функции, превышающих среднее арифметическое чётных положительных значений: " + count);
            }
        }
    }
}