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
    /// Логика взаимодействия для month.xaml
    /// </summary>
    public partial class month : Window
    {
        public month()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Selected month - ";
            switch (number.Text)
            {
                case "1":
                    {
                        message += "January";
                        break;
                    }
                case "2":
                    {
                        message += "February";
                        break;
                    }
                case "3":
                    {
                        message += "March";
                        break;
                    }
                case "4":
                    {
                        message += "April";
                        break;
                    }
                case "5":
                    {
                        message += "May";
                        break;
                    }
                case "6":
                    {
                        message += "June";
                        break;
                    }
                case "7":
                    {
                        message += "July";
                        break;
                    }
                case "8":
                    {
                        message += "August";
                        break;
                    }
                case "9":
                    {
                        message += "September";
                        break;
                    }
                case "10":
                    {
                        message += "October";
                        break;
                    }
                case "11":
                    {
                        message += "November";
                        break;
                    }
                case "12":
                    {
                        message += "December";
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
