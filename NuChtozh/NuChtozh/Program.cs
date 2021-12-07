using System;

namespace NuChtozh
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            //Console.WriteLine("Начинаем?");
            //Console.ReadKey();
            //Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                a = A(a);
            }
            Console.ReadKey();
        }

        static double A(double a=1)
        {
            double b = 3, c = 4;
            a = (Math.Pow((b * c) / 2, c)* a * 10 - c)/b/2.03/1.4/1.02/3.2/2.11/5.223;
            Console.WriteLine("\n" + a);
            return a;
        }
    }
}