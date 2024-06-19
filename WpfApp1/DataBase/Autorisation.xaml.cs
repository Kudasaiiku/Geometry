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
using System.Data;
using WpfApp1.DataBase;



namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Autorisation : Window
    {

        public Autorisation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsAllTextBoxesFilled())
            {
                var password = textBox1_Copy.Text;
                using (var db = new testEntities())
                {
                    var currentUser = db.register.FirstOrDefault(u => u.userLogin == textBox1.Text || u.userEmail == textBox1.Text && u.userPassword == password);
                    if (currentUser != null)
                    {
                        if (currentUser != null)
                        {
                            GlobalData.UserId = currentUser.userID;
                            MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Menu menu = new Menu();
                            menu.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
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
            Registration registration = new Registration();
            registration.Show();
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
