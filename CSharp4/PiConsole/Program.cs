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
            Console.Write("Введите количество итераций: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Формула Франсуа Виета -  {0} ",  Viet_Method(n));
            Console.Write("\nФормула Джона Уоллиса -  " + John_Method(n));
            Console.Write("\nФормула лорда Брункера - " + Brouncker_Method(n));
            Console.Write("\nФормула Г. Лейбница -    " + Leibniz_Method(n) + "\n");
        }
        //............ Формула Франсуа Виета ...............// 
        public static double Viet_Method(int n)
        {
            double pi = Math.Pow(1 / 2.0, 0.5);
            double tmp = pi;
            for (int i = 2; i <= n; i++)
            {
                tmp = Math.Pow(((1 / 2.0) + tmp * (1 / 2.0)), 0.5);
                pi *= tmp;
            }
            return Math.Round(2.0 / pi, 10);
        }
        //............ Формула Джона Уоллиса ...............//        
        public static double John_Method(int n)
        {
            double pi = (1.0 * 3.0) / (Math.Pow(2, 2.0));
            double counter = 4.0;
            for (int i = 1; i <= n; i++)
            {
                pi *= ((counter - 1.0) * (counter + 1.0)) / (Math.Pow(counter, 2.0));
                counter += 2.0;
            }
            return Math.Round(2.0 / pi, 10);
        }
        //............ Формула Lord Brouncker  ...............//
        public static double Brouncker_Method(int n)
        {
            int p = 1;
            for (int i = 2; i <= n; i++)
                p += 2;
            double pi = 2 + (Math.Pow(p, 2) / 1);
            p -= 2;
            for (int i = n - 1; i >= 1; i--)
            {
                if (i == 1)
                {
                    pi = 1 + Math.Pow(p, 2) / pi;
                    break;
                }
                pi = 2 + Math.Pow(p, 2) / pi;
                p -= 2;
            }
            return Math.Round(4.0 / pi, 10);
        }
        //............ Формула Г. Лейбница ...............//
        public static double Leibniz_Method(int n)
        {
            double pi = 1.0;
            double counter = 3.0;
            int tmp = 2;
            for (int i = 1; i <= n; i++)
            {
                if (tmp % 2 == 0)
                    pi -= (1.0 / counter);
                else
                    pi += (1.0 / counter);
                counter += 2;
                tmp++;
            }
            return Math.Round(4.0 * pi, 10);
        }
       

    }

}
