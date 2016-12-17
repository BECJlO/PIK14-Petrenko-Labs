using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input B: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                    sum += i * i;
                Console.WriteLine("Suma = " + sum);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: A >= B");
                Console.ResetColor();
            }
            
        }
    }
}
