using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of iteration: ");
            int n = int.Parse(Console.ReadLine());
            /*//1
            double fpi = Math.Sqrt(1.00/2.00), pi = fpi;
            for (int i = 0; i < n; i++)
            {
                pi = fpi * Math.Sqrt(1.00 / 2.00 + 1.00 / 2.00 * pi);
            }
            Console.WriteLine("PI= " + 2/pi);*/

        }
    }
}
