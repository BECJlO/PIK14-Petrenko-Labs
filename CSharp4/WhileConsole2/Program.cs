                            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input p: ");
            int p = int.Parse(Console.ReadLine()), k = 0;
            double dpd = 10, d = 10;
            while (d <= 200) {
                dpd *= p/100;
                d += dpd;
                k++;
            }
            Console.WriteLine("S = " + d);
            Console.WriteLine("K = " + k);
        }
    }
}
