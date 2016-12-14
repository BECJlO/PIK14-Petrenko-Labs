using System;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Введ1ть число:\n n = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("\n m = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("\n x = ");
            x = float.Parse(Console.ReadLine());
            double res = 2.4 * Math.Abs((x*x + b) / a ) + ((a + b) * Math.Pow(Math.Sin(a - b),2) + Math.Pow(10,-2) * (x -b));
            Console.Write(" Y = {0}\n", res);
        }
    }
}
