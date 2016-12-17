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
    /// Логика взаимодействия для day.xaml
    /// </summary>
    public partial class day : Window
    {
        public day()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Selected day - ";
            switch (number.Text) {
                case "1": {
                        message += "Monday";
                        break;
                    }
                case "2":
                    {
                        message += "Tuesday";
                        break;
                    }
                case "3":
                    {
                        message += "Wednesday";
                        break;
                    }
                case "4":
                    {
                        message += "Thursday";
                        break;
                    }
                case "5":
                    {
                        message += "Friday";
                        break;
                    }
                case "6":
                    {
                        message += "Saturday";
                        break;
                    }
                case "7":
                    {
                        message += "Sunday";
                        break;
                    }
                default:
                    {
                        message += "doesn't exist!!!";
                        break;
                    }
                   
            }
            MessageBox.Show(message, "Results");
        }
    }
}
