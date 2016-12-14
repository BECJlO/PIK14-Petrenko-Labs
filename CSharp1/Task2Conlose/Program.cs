using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Conlose
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, m;
            Console.Write("Введ1ть число:\n n = ");
            n =float.Parse( Console.ReadLine());            
            Console.Write("\n m = ");
            m = float.Parse(Console.ReadLine());
            double res = (((n - 1) * Math.Sqrt(m))- ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m,3) * n) +  m * n  + m * m - m);
            double res1 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.Write("Z1 = {0}\n Z2 = {1}\n", res, res1);            
        }
    }
}
