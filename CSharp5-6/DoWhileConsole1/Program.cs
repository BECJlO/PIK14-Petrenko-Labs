using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum = 0;
            do {
                Console.Write("Input number: ");
                n = int.Parse(Console.ReadLine());
                sum += n;
            } while (n != 0);
            Console.WriteLine("Sum= " + sum);
        }
    }
}
