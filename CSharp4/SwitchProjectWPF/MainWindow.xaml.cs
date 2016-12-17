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

namespace SwitchProjectWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            day dayWindow = new day();
            dayWindow.Show();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            month monthWindow = new month();
            monthWindow.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            calc calcWindow = new calc();
            calcWindow.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
