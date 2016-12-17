using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole2
{
    class Program
    {
        public void Main(string[] args)
        {
            String[] menu = { "1. Расшифровка дня недели", "2. Расшифровка месяца", "3. Выполнение операций над числами", "4. Выход" };
            foreach (String i in menu)
            {
                System.Console.WriteLine("{0}", i);
            }
            int ch = int.Parse(Console.ReadLine());
            do
            {
                switch (ch)
                {
                    case 1:
                        {
                            Console.Write("Input the number of the day: ");
                            int day = int.Parse(Console.ReadLine());
                            Console.Write("Selected day - ");
                            switch (day)
                            {
                                case 1: Console.WriteLine("Monday"); break;
                                case 2: Console.WriteLine("Tuesday"); break;
                                case 3: Console.WriteLine("Wednesday"); break;
                                case 4: Console.WriteLine("Thursday"); break;
                                case 5: Console.WriteLine("Friday"); break;
                                case 6: Console.WriteLine("Saturday"); break;
                                case 7: Console.WriteLine("Sunday"); break;
                                default: Console.WriteLine("doesn't exist!!!"); break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Input the number of the month: ");
                            int month = int.Parse(Console.ReadLine());
                            Console.Write("Selected month - ");
                            switch (month)
                            {
                                case 1: Console.WriteLine("January"); break;
                                case 2: Console.WriteLine("February"); break;
                                case 3: Console.WriteLine("March"); break;
                                case 4: Console.WriteLine("April"); break;
                                case 5: Console.WriteLine("May"); break;
                                case 6: Console.WriteLine("June"); break;
                                case 7: Console.WriteLine("July"); break;
                                case 8: Console.WriteLine("August"); break;
                                case 9: Console.WriteLine("September"); break;
                                case 10: Console.WriteLine("October"); break;
                                case 11: Console.WriteLine("November"); break;
                                case 12: Console.WriteLine("December"); break;
                                default: Console.WriteLine("doesn't exist!!!"); break;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Input A: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Input B: ");
                            float b = float.Parse(Console.ReadLine());
                            String[] calcOperations = { "1. Сложение", "2. Умножение", "3. Вычитание", "4. Деление", };
                            foreach (String i in calcOperations)
                            {
                                System.Console.WriteLine("{0}", i);
                            }
                            int ch2 = int.Parse(Console.ReadLine());
                            float result;
                            switch (ch2)
                            {
                                case 1:
                                    {
                                        result = a + b;
                                        Console.WriteLine("Result= " + result);
                                        break;
                                    }
                                case 2:
                                    {
                                        result = a * b;
                                        Console.WriteLine("Result= " + result);
                                        break;
                                    }
                                case 3:
                                    {
                                        result = a - b;
                                        Console.WriteLine("Result= " + result);
                                        break;
                                    }
                                case 4:
                                    {
                                        result = a / b;
                                        Console.WriteLine("Result= " + result);
                                        break;
                                    }
                                default:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("ERROR: Selected unexisted operation!");
                                        Console.ResetColor();
                                        break;

                                    }                                   
                            }
                            break;
                        }
                    case 4: ch = 4; break;
                }
            } while (ch != 4);
        }
    }
}
