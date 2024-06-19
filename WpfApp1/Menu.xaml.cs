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



namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

       class Autorisation : Menu
            {

            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ex1 ex1 = new ex1();
            ex1.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ex2 ex2 = new ex2();
            ex2.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ex3 ex3 = new ex3();
            ex3.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ex4 ex4 = new ex4();
            ex4.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ex5 ex5 = new ex5();
            ex5.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Creator creator = new Creator();
            creator.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
            this.Close();
        }
    }
}