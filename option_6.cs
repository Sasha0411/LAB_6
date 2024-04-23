using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double x = 1.1;
            for (int n = 1; n <= 20; n++)
            {
                double term = 2 * (1 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1)));
                sum += term;
            }

            double E = 2.7182818284590451;
            double y1 = Math.Log(E, (x + 1) / (x - 1));



            // Виведення результатів
            Console.WriteLine($"Сума 20-ти членів степеневого ряду {sum}");
            Console.WriteLine($"Значення функції у точці x = 1.1: {y1}");
        }
    }
}
