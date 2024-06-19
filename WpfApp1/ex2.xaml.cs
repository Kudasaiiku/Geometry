using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ex1.xaml
    /// </summary>
    public partial class ex2 : Window
    {
        public ex2()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox1.PreviewTextInput += new TextCompositionEventHandler(textBox1_PreviewTextInput);
            Draw.lineCanvas(50, 0, 50, 350, Canvas);
            Draw.lineCanvas(100, 0, 100, 350, Canvas);
            Draw.lineCanvas(150, 0, 150, 350, Canvas);
            Draw.lineCanvas(200, 0, 200, 350, Canvas);
            Draw.lineCanvas(250, 0, 250, 350, Canvas);
            Draw.lineCanvas(300, 0, 300, 350, Canvas);
            Draw.lineCanvas(350, 0, 350, 350, Canvas);
            Draw.lineCanvas(400, 0, 400, 350, Canvas);
            Draw.lineCanvas(450, 0, 450, 350, Canvas);
            Draw.lineCanvas(500, 0, 500, 350, Canvas);
            Draw.lineCanvas(550, 0, 550, 350, Canvas);
            Draw.lineCanvas(600, 0, 600, 350, Canvas);

            Draw.lineCanvas(0, 50, 650, 50, Canvas);
            Draw.lineCanvas(0, 100, 650, 100, Canvas);
            Draw.lineCanvas(0, 150, 650, 150, Canvas);
            Draw.lineCanvas(0, 200, 650, 200, Canvas);
            Draw.lineCanvas(0, 250, 650, 250, Canvas);
            Draw.lineCanvas(0, 300, 650, 300, Canvas);
        }

        Regex inputRegex = new Regex(@"^[0-9,]*$");
        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputRegex.Match(e.Text);
            if ((sender as TextBox).Text.Length >= 4 || !match.Success)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        class Draw : DrawBase
        {
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            point point = new point();
            point.ShowDialog();
            Draw.point(Coordinates.X - 1, Coordinates.Y - 1, Canvas);
            Coordinates_Clearing();
        }
        // Метод рисования на канвасе.
        private void Canvas_MouseMove(object sender, MouseEventArgs g)
        {
            // Проверка на отметку чекбокса.
            if (Checkboxx.IsChecked == true)
            {
                // Проверка на зажатие ЛКМ на канвасе.
                if (g.MouseDevice.LeftButton == MouseButtonState.Pressed)
                {
                    // Присваивание позиций курсора.
                    double x = g.GetPosition(Canvas).X;
                    double y = g.GetPosition(Canvas).Y;
                    // Добваление линии на канвас.
                    Canvas.Children.Add(new Line
                    {
                        // Координаты линии равны позиции курсора мыши.
                        X1 = x,
                        Y1 = y,
                        X2 = x,
                        Y2 = g.GetPosition(Canvas).Y,
                        // Внешний вид конца и начала линии.
                        StrokeStartLineCap = PenLineCap.Square,
                        StrokeEndLineCap = PenLineCap.Square,
                        // Толщина линии.
                        StrokeThickness = 2,
                        // Цвет линии.
                        Stroke = Brushes.Black
                    });
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Canvas.Children.Clear();
            Draw.lineCanvas(50, 0, 50, 350, Canvas);
            Draw.lineCanvas(100, 0, 100, 350, Canvas);
            Draw.lineCanvas(150, 0, 150, 350, Canvas);
            Draw.lineCanvas(200, 0, 200, 350, Canvas);
            Draw.lineCanvas(250, 0, 250, 350, Canvas);
            Draw.lineCanvas(300, 0, 300, 350, Canvas);
            Draw.lineCanvas(350, 0, 350, 350, Canvas);
            Draw.lineCanvas(400, 0, 400, 350, Canvas);
            Draw.lineCanvas(450, 0, 450, 350, Canvas);
            Draw.lineCanvas(500, 0, 500, 350, Canvas);
            Draw.lineCanvas(550, 0, 550, 350, Canvas);
            Draw.lineCanvas(600, 0, 600, 350, Canvas);

            Draw.lineCanvas(0, 50, 650, 50, Canvas);
            Draw.lineCanvas(0, 100, 650, 100, Canvas);
            Draw.lineCanvas(0, 150, 650, 150, Canvas);
            Draw.lineCanvas(0, 200, 650, 200, Canvas);
            Draw.lineCanvas(0, 250, 650, 250, Canvas);
            Draw.lineCanvas(0, 300, 650, 300, Canvas);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            line line = new line();
            line.ShowDialog();
            Draw.line(Coordinates.X, Coordinates.Y, Coordinates.X1, Coordinates.Y1, Canvas);
            Coordinates_Clearing();
        }

        private static void Coordinates_Clearing()
        {
            Coordinates.X = 0;
            Coordinates.Y = 0;
            Coordinates.X1 = 0;
            Coordinates.Y1 = 0;
            Coordinates.R = 0;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            round round = new round();
            round.ShowDialog();
            Draw.circle(Coordinates.X, Coordinates.Y, Coordinates.R, Canvas);
            Coordinates_Clearing();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (IsAllTextBoxesFilled())
            {
                if (textBox1.Text == "30")
                    label1.Visibility = Visibility.Visible;
                else
                    label1.Visibility = Visibility.Hidden;

                if (textBox1.Text == "30")
                    label2.Visibility = Visibility.Hidden;
                else
                    label2.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Введите ответ!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OpenPages(object sender, RoutedEventArgs e)
        {
            // Отображении страниц по нажатию кнопки мыши.
            frame1.Visibility = Visibility.Visible;
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            frame1.Content = new Page11();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            frame1.Content = new Page12();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            frame1.Visibility = Visibility.Hidden;
            b1.Visibility = Visibility.Hidden;
            b2.Visibility = Visibility.Hidden;
        }

        private void Checkboxx_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tb.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception)
            {
                tb.Text = "";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = tb.Text.Substring(iOp, 1);
            double op1 = (double)Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = (double)Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            if (op == "+")
            {
                tb.Text = "";
                tb.Text = Convert.ToString(op1 + op2);
            }
            else if (op == "-")
            {
                tb.Text = "";
                tb.Text = Convert.ToString(op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text = "";
                tb.Text = Convert.ToString(op1 * op2);
            }
            else
            {
                tb.Text = "";
                tb.Text = Convert.ToString(op1 / op2);
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }
        // Удаление одного символа.
        private void R_Erase(object sender, RoutedEventArgs e)
        {
            // Проверка на даличие данных в строке.
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
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

        private void Button_Info(object sender, RoutedEventArgs e)
        {
            UserInfo usinginfo = new UserInfo();
            usinginfo.ShowDialog();
        }
    }
}