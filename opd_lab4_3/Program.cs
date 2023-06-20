/*
Функция Y=f(x), x1<=x<=x2, шаг - x3. Определить количество значений функции, 
превышающих среднее арифметическое чётных положительных значений.
С помощью оператора "do-while":
*/
using System;

namespace opd_lab4_3
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

            double x = x1;

            do
            {
                double y = x * x - 9;
                if (y % 2 == 0 && y > 0)
                {
                    sum += y;
                    evenPositiveCount++;
                }

                x += x3;
            } while (x <= x2);

            if (evenPositiveCount == 0)
            {
                Console.WriteLine("Нет значений :(");
            }
            else
            {
                double average = sum / evenPositiveCount;

                x = x1;

                do
                {
                    double y = x * x - 9;
                    if (y > average)
                    {
                        count++;
                    }

                    x += x3;
                } while (x <= x2);

                Console.WriteLine("Количество значений функции, превышающих среднее арифметическое чётных положительных значений: " + count);
            }
        }
    }
}