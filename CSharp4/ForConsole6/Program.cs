using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            float n = float.Parse(Console.ReadLine());
            double sum = 0;
            for (float i = 0; i < n; i++) {
                sum += Math.Pow(i + 1, n - i);
            }
            Console.WriteLine("F = " + sum);
        }
    }
}
