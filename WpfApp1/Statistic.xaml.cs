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
using System.Collections.ObjectModel;
using Microsoft.CognitiveServices.Speech.Transcription;
using WpfApp1.DataBase;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Statistic : Window
    {
        int userId = GlobalData.UserId;

        public Statistic()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var context = new testEntities())
            {
                var user = context.userData.FirstOrDefault(u => u.userID == userId);

                if (user != null)
                {
                    string userProgress = user.userProgress;
                    progressLabel.Content = $"Прогресс пользователя: {userProgress}%";
                }
                else
                {
                    progressLabel.Content = "Ошибка: пользователь не найден.";
                }
            }
        }
    }
}