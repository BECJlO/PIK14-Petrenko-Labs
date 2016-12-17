using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            while (Math.Pow(3, k) <= n) {
                k++;
            }
            Console.WriteLine("Minimal K = " + k);
        }
    }
}
