using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SwitchProjectWPF
{
    /// <summary>
    /// Логика взаимодействия для calc.xaml
    /// </summary>
    public partial class calc : Window
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A + B = " + (double.Parse(A.Text) + double.Parse(B.Text)).ToString(), "Results");
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if(double.Parse(B.Text) != 0) { 
                MessageBox.Show("A / B = " + (double.Parse(A.Text) / double.Parse(B.Text)).ToString(), "Results");
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A * B = " + (double.Parse(A.Text) * double.Parse(B.Text)).ToString(), "Results");
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A - B = " + (double.Parse(A.Text) - double.Parse(B.Text)).ToString(), "Results");
        }
    }
}
