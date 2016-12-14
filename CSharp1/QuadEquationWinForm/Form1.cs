using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("Введ1ть a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введ1ть b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введ1ть c = ");
            int c = int.Parse(Console.ReadLine());
            float D = b * b - 4 * a * c;
            Console.Write("\nДискриминант = {0}", D);
            if (D > 0 || D == 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                if (x1 == x2)
                {
                    Console.WriteLine("\nx1= {0}", x1);
                }
                else
                {
                    Console.WriteLine("\nx1= {0}\n x2= {1}", x1, x2);
                    Console.ReadKey();
                }
            }


            else
            {
                Console.WriteLine("\n  Д1йсних корен1в не мае");
                Console.ReadKey();
            }
        }
    }
}
