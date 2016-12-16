using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Condition N > 0" + "\nInput N:  ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            if (n > 0)
            {
                for (double i = 1.00; i <= n; i++)
                {
                    sum += 1.00 / i;
                }
                Console.WriteLine("Suma = " + sum);
            }
            else
            {               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: N <= 0");
                Console.ResetColor();
            }
        }
    }
}
