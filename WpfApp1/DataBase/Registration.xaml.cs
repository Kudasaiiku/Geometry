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
using System.Data.SqlClient;
using WpfApp1.DataBase;
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsAllTextBoxesFilled())
            {
                // Email
                Regex emailRegex = new Regex(@"^[-A-Za-z0-9!+?_]+(?:\.[-A-Za-z0-9!+?_~]+)*@(?:[a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(?:aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$");
                // Логин
                Regex login = new Regex(@"^[a-zA-Zа-яА-Я0-9]+$");
                // Имя
                Regex name = new Regex(@"^[а-яА-Я]+$");
                
                if (!emailRegex.IsMatch(textBox1_Copy2.Text))
                {
                    MessageBox.Show("Введите корректный email!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!login.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Введите логин, состоящий из букв и цифр!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!name.IsMatch(textBox1_Copy1.Text))
                {
                    MessageBox.Show("Введите имя на русском языке!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    register new_account = new register();
                    new_account.userLogin = textBox1.Text;
                    new_account.userPassword = textBox1_Copy.Text;
                    new_account.userEmail = textBox1_Copy2.Text;

                    userData userName = new userData();
                    userName.userName = textBox1_Copy1.Text;

                    string userInput = textBox1.Text;
                    var query = from r in AppData.db.register
                                where r.userLogin == userInput
                                select r;
                    if (query.Any())
                    {
                        MessageBox.Show("Такой логин уже зарегестрирован!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        AppData.db.userData.Add(userName);
                        AppData.db.register.Add(new_account);
                        AppData.db.SaveChanges();
                        MessageBox.Show("Вы успешно зарегестрированы!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                        Autorisation autorisation = new Autorisation();
                        autorisation.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            autorisation.Show();
            this.Close();
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
