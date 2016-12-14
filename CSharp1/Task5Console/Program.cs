using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            float y, z, x;
            Console.Write("Введ1ть число:\n y = ");
            y = float.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = float.Parse(Console.ReadLine());
            Console.Write("\n z = ");
            z = float.Parse(Console.ReadLine());
            double res = Math.Cos(x - Math.PI / 6 ) / (0.5 + Math.Pow(Math.Sin(y),2)) * (1 + z *z / (3 - z * z / 5));
            Console.Write(" t = {0}\n", res);
        }
    }
}
