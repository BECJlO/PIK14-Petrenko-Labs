using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("\nCondition N > 0" + "\nInput N:  ");
            int n = int.Parse(Console.ReadLine());
            float sum = 1;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                    sum *= a;
                Console.WriteLine("Proizvedenie=" + sum);
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
