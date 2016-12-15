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
        Button[] btns;
        string btmNameStr = "";
        byte buttonIndex;
        int formWidth = 270;
        byte buttonNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
            Form.Width = formWidth;
            btns = new Button[] {
                WeekEncriptionButton,
                MounthEncriptionButton,
                NumericOperationButton
            };
            answerLabel.Foreground = Brushes.Red;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoolButton(sender);
            buttonNumber = 1;
            Form.Width = formWidth + 160;
            inputOneLabel.Content = "Введите число :";
            doButton.Content = "Расшифровка";
            inputOneTextBox.Text = "";
            answerLabel.Content = "";
            answerLabel.Width = 150;
        }
        private void MounthEncriptionButton_Click(object sender, RoutedEventArgs e)
        {
            BoolButton(sender);
            buttonNumber = 2;
            Form.Width = formWidth + 160;
            inputOneLabel.Content = "Введите число :";
            doButton.Content = "Расшифровка";
            inputOneTextBox.Text = "";
            answerLabel.Content = "";
            answerLabel.Width = 150;
        }
        private void NumericOperationButton_Click(object sender, RoutedEventArgs e)
        {
            BoolButton(sender);
            buttonNumber = 3;
            Form.Width = formWidth + 315;
            inputOneLabel.Content = "Операнд 1 :";
            inputTwoLabel.Content = "Операнд 2 :";
            doButton.Content = "Решить";
            inputOneTextBox.Text = "";
            inputTwoTextBox.Text = "";
            answerLabel.Content = "";
            answerLabel.Width = 350;
        }
        private void doButton_Click(object sender, RoutedEventArgs e)
        {
            int choice = 0;
            double x1 = 0, x2 = 0;
            char ch = ' ';
            try 
	        {
                switch (buttonNumber)
                {
                    case 1: case 2:
                        choice = int.Parse(inputOneTextBox.Text);
                        break;
                    case 3:
                        x1 = double.Parse(inputOneTextBox.Text);
                        x2 = double.Parse(inputTwoTextBox.Text);
                        ch = char.Parse(operationTextBox.Text);
                        break;
                }
	        }
	        catch
	        {
                ClearControls();
                MessageBox.Show("Ошибка ввода!");
                return;
	        }
            switch (buttonNumber)
            {
                case 1:
                    WeekEncription(choice);
                    break;
                case 2:
                    MounthEncription(choice);
                    break;
                case 3:
                    NumericOperation(x1, x2, ch);
                    break;
            }
        }
        void WeekEncription(int choice)
        {
            switch (choice)
            {
                case 1:
                    answerLabel.Content = (choice.ToString() + " - это понедельник!").ToUpper();
                    break;
                case 2:
                    answerLabel.Content = (choice.ToString() + " - это вторник!").ToUpper();
                    break;
                case 3:
                    answerLabel.Content = (choice.ToString() + " - это среда!").ToUpper();
                    break;
                case 4:
                    answerLabel.Content = (choice.ToString() + " - это четверг!").ToUpper();
                    break;
                case 5:
                    answerLabel.Content = (choice.ToString() + " -это пятница!").ToUpper();
                    break;
                case 6:
                    answerLabel.Content = (choice.ToString() + " - это суббота!").ToUpper();
                    break;
                case 7:
                    answerLabel.Content = (choice.ToString() + " - это воскресенье!").ToUpper();
                    break;
                default:
                    ClearControls();
                    MessageBox.Show("Ошибка ввода!");
                    return;
            }
        }
        void MounthEncription(int choice)
        {
            switch (choice)
            {
                case 1:
                    answerLabel.Content = (choice.ToString() + " - это Январь!").ToUpper();
                    break;
                case 2:
                    answerLabel.Content = (choice.ToString() + " - это Февраль!").ToUpper();
                    break;
                case 3:
                    answerLabel.Content = (choice.ToString() + " - это Март!").ToUpper();
                    break;
                case 4:
                    answerLabel.Content = (choice.ToString() + " - это Апрель!").ToUpper();
                    break;
                case 5:
                    answerLabel.Content = (choice.ToString() + " -это Май!").ToUpper();
                    break;
                case 6:
                    answerLabel.Content = (choice.ToString() + " - это Июнь!").ToUpper();
                    break;
                case 7:
                    answerLabel.Content = (choice.ToString() + " - это Июль!").ToUpper();
                    break;
                case 8:
                    answerLabel.Content = (choice.ToString() + " - это Август!").ToUpper();
                    break;
                case 9:
                    answerLabel.Content = (choice.ToString() + " - это Сентябрь!").ToUpper();
                    break;
                case 10:
                    answerLabel.Content = (choice.ToString() + " - это Октябрь!").ToUpper();
                    break;
                case 11:
                    answerLabel.Content = (choice.ToString() + " -это Ноябрь!").ToUpper();
                    break;
                case 12:
                    answerLabel.Content = (choice.ToString() + " - это Декабрь!").ToUpper();
                    break;
                default:
                    ClearControls();
                    MessageBox.Show("Ошибка ввода!");
                    return;
            }
        }
        void NumericOperation(double x1, double x2, char ch)
        {
            switch (ch)
            {
                case '+':
                    answerLabel.Content = (String.Format("{0} + {1} = {2}", x1, x2, x1+x2)).ToUpper();
                    break;
                case '*':
                    answerLabel.Content = (String.Format("{0} * {1} = {2}", x1, x2, x1*x2)).ToUpper();
                    break;
                case '-':
                    answerLabel.Content = (String.Format("{0} - {1} = {2}", x1, x2, x1-x2)).ToUpper();
                    break;
                case '/':
                    answerLabel.Content = (String.Format("{0} / {1} = {2}", x1, x2, x1/x2)).ToUpper();
                    break;
                default:
                    ClearControls();
                    MessageBox.Show("Ошибка ввода!");
                    return;
            }
        }
        void BoolButton(object obj)
        {
            Button btn = (Button)obj;
            if(buttonNumber != 0)
                btns[buttonIndex].Content = btmNameStr;
            for (byte i = 0; i < btns.Length; i++)
            {
                if (btns[i] == btn)
                    buttonIndex = i;
                btns[i].FontWeight = FontWeights.Normal;
                btns[i].Background = new SolidColorBrush(Color.FromRgb(188, 199, 212));
            }
            btn.FontWeight = FontWeights.Bold;
            btmNameStr = btn.Content.ToString();
            btn.Content = ">" + btn.Content + "<";
            btn.Background = new SolidColorBrush(Color.FromRgb(224, 188, 65));
        }
        void ClearControls()
        {
            answerLabel.Content = "";
            inputOneTextBox.Text = "";
            inputTwoTextBox.Text = "";
            operationTextBox.Text = "";
            operationLabel.Content = "";
        }
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

