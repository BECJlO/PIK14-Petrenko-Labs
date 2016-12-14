using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введ1ть сторони трикутника\n a = ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            Console.Write("\n b = ");
            string s1 = Console.ReadLine();
            int b = int.Parse(s1);
            int res = a + b;
            Console.Write("\nПериметер трикутника = {0}", res);
            int res1 = a * b;
            Console.Write("\nПлоща трикутника = {0}\n", res1);     
    
        }
    }
}
