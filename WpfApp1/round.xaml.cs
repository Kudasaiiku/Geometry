﻿using System;
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
    /// Логика взаимодействия для round.xaml
    /// </summary>
    public partial class round : Window
    {
        public round()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox1.PreviewTextInput += new TextCompositionEventHandler(textBox1_PreviewTextInput);
            textBox2.PreviewTextInput += new TextCompositionEventHandler(textBox2_PreviewTextInput);
            textBox3.PreviewTextInput += new TextCompositionEventHandler(textBox3_PreviewTextInput);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsAllTextBoxesFilled())
            {
                Coordinates.X = Convert.ToInt32(textBox1.Text);
                Coordinates.Y = Convert.ToInt32(textBox2.Text);
                Coordinates.R = Convert.ToInt32(textBox3.Text);
                if (Coordinates.X > 400 || Coordinates.Y > 100 || Coordinates.R > 250)
                {
                    Coordinates.X = 0;
                    Coordinates.Y = 0;
                    Coordinates.R = 0;
                    ErrorRound error = new ErrorRound();
                    error.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите значения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        Regex inputRegex = new Regex(@"^[0-9]$");
        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
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