using System;

namespace opd_lab4_2
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

            while (x <= x2)
            {
                if (x % 2 == 0 && x > 0)
                {
                    sum += x;
                    evenPositiveCount++;
                }

                x += x3;
            }

            double average = sum / evenPositiveCount;

            x = x1;

            while (x <= x2)
            {
                if (x > average)
                {
                    count++;
                }

                x += x3;
            }

            Console.WriteLine("Количество значений функции, превышающих среднее арифметическое чётных положительных значений: " + count);

        }
    }
}