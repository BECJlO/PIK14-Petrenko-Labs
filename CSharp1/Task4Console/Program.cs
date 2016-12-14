using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            float y, z, x;
            Console.Write("Введ1ть число:\n y = ");
            y = float.Parse(Console.ReadLine());
            Console.Write("\n x = ");
            x = float.Parse(Console.ReadLine());
            Console.Write("\n z = ");
            z = float.Parse(Console.ReadLine());
            double res = (Math.Pow(y + Math.Pow(x - 1,1/3), 1/4))/Math.Abs(x - y) * ( Math.Pow(Math.Sin(z),2) + Math.Tan(z));
            Console.Write(" F = {0}\n", res);
        }
    }
}
