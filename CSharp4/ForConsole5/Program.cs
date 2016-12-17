using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nCondition N > 0" + "\nInput N:  ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += Factorial(i);
                }
                Console.WriteLine("Sum=" + sum);
            }
            else  {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: N <= 0");
                Console.ResetColor();
            }
        }
        static float Factorial(int n) {
            float fact = 1;
            for (float i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }
    }
}
