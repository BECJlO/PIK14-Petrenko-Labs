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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuadEquationWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

             /*   private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxA.Text == String.Empty || TextBoxB.Text == String.Empty || TextBoxC.Text == String.Empty)
                Button_solve.IsEnabled = false;
            else
                Button_solve.IsEnabled = true;
        }
        */
        private void Button_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, d;
            try
            {
                a = double.Parse(TextBoxA.Text);
                b = double.Parse(TextBoxB.Text);
                c = double.Parse(TextBoxC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ОШИБКА: вводите только цифры!");
                return;
            }
            d = b * b - 4 * a * c;
            if (d > 0)
            {               
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                LabelX1.Content = "x1 = ";
                LabelX2.Content = "x2 = ";
                TextBoxX1.Text = x1.ToString();
                TextBoxX2.Text = x2.ToString();
                LabelX1.Visibility = Visibility.Visible;
                LabelX2.Visibility = Visibility.Visible;
                TextBoxX1.Visibility = Visibility.Visible;
                TextBoxX2.Visibility = Visibility.Visible;
                this.Height = 370;
            }
            if (d == 0)
            {               
                x1 = (-b) / (2 * a);
                LabelX1.Content = "x = ";
                TextBoxX1.Text = x1.ToString();
                LabelX1.Visibility = Visibility.Visible;
                TextBoxX1.Visibility = Visibility.Visible;
                TextBoxX2.Visibility = Visibility.Collapsed;
                LabelX2.Visibility = Visibility.Collapsed;               
            }
            if (d < 0)
            {                                              
                
                MessageBox.Show("Дискриминант отрицательный. Кореней нет!");
            }
        }

        private void Button_solve_Click(object sender, RoutedEventArgs e)
        {

        }
    }
} 

       
      

