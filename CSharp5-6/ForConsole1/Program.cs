using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input B: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 1;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                    sum *= i;
                Console.WriteLine("Proizvedenie=" + sum);
            }
            else Console.WriteLine("ERROR: A >= B");
        }
    }
}
