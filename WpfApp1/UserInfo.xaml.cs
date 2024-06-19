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
    /// Логика взаимодействия для UserInfo.xaml
    /// </summary>
    public partial class UserInfo : Window
    {

        private Stack<Page> pageHistory = new Stack<Page>();

        public UserInfo()
        {
            InitializeComponent();

            frame.Navigate(new Info1());
        }


        private void Button_Back(object sender, RoutedEventArgs e)
        {
            if (pageHistory.Count > 0)
            {
                Page lastPage = pageHistory.Pop();
                frame.Navigate(lastPage);
            }
        }

        private void Button_Go(object sender, RoutedEventArgs e)
        {
            Page nextPage = null;

            if (frame.Content is Info1)
            {
                nextPage = new Info2();
            }
            else if (frame.Content is Info2)
            {
                nextPage = new Info3();
            }

            if (nextPage != null)
            {
                pageHistory.Push(frame.Content as Page);
                frame.Navigate(nextPage);
            }
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
