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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для line.xaml
    /// </summary>
    public partial class line : Window
    {
        public line()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox1.PreviewTextInput += new TextCompositionEventHandler(X_PreviewTextInput);
            textBox2.PreviewTextInput += new TextCompositionEventHandler(textBox2_PreviewTextInput);
            textBox3.PreviewTextInput += new TextCompositionEventHandler(textBox3_PreviewTextInput);
            textBox4.PreviewTextInput += new TextCompositionEventHandler(textBox4_PreviewTextInput);
        }
        // Проверка ввода данных координат.
        Regex inputRegex = new Regex(@"^[0-9]$");
        // Ограничение вводимых значений до трёх.
        private void X_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputRegex.Match(e.Text);
            if ((sender as TextBox).Text.Length >= 3 || !match.Success)
            {
                e.Handled = true;
            }
        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputRegex.Match(e.Text);
            if ((sender as TextBox).Text.Length >= 3 || !match.Success)
            {
                e.Handled = true;
            }
        }

        private void textBox3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputRegex.Match(e.Text);
            if ((sender as TextBox).Text.Length >= 3 || !match.Success)
            {
                e.Handled = true;
            }
        }

        private void textBox4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputRegex.Match(e.Text);
            if ((sender as TextBox).Text.Length >= 3 || !match.Success)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsAllTextBoxesFilled())
            {
                Coordinates.X = Convert.ToInt32(textBox1.Text);
                Coordinates.Y = Convert.ToInt32(textBox2.Text);
                Coordinates.X1 = Convert.ToInt32(textBox3.Text);
                Coordinates.Y1 = Convert.ToInt32(textBox4.Text);
                if (Coordinates.X > 650 || Coordinates.Y > 350 || Coordinates.X1 > 650 || Coordinates.Y1 > 350)
                {
                    Coordinates.X = 0;
                    Coordinates.Y = 0;
                    Coordinates.X1 = 0;
                    Coordinates.Y1 = 0;
                    ErrorLine errorLine = new ErrorLine();
                    errorLine.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите значения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Проверка на заполненность всех TextBox.
        private bool IsAllTextBoxesFilled()
        {
            foreach (var element in grid.Children)
            {
                if (element is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    return false;
                }
            }
            return true;
        }
    }
}