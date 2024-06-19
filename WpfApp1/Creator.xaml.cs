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
    /// Логика взаимодействия для Creator.xaml
    /// </summary>
    public partial class Creator : Window
    {
        public Creator()
        {
            InitializeComponent();
        }

        class Draw: DrawBase
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            point point = new point();
            point.ShowDialog();
            Draw.point(Coordinates.X, Coordinates.Y, Canvas);
            Coordinates.X = 0;
            Coordinates.Y = 0;
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs g)
        {
            if (Checkboxx.IsChecked == true)
            {
                if (g.MouseDevice.LeftButton == MouseButtonState.Pressed)
                {
                    Canvas.Children.Add(new Line
                    {
                        X1 = g.GetPosition(Canvas).X,
                        Y1 = g.GetPosition(Canvas).Y,
                        X2 = g.GetPosition(Canvas).X,
                        Y2 = g.GetPosition(Canvas).Y,
                        StrokeStartLineCap = PenLineCap.Square,
                        StrokeEndLineCap = PenLineCap.Square,
                        StrokeThickness = 2,
                        Stroke = Brushes.Black
                    });
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Canvas.Children.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            line line = new line();
            line.ShowDialog();
            Draw.line(Coordinates.X, Coordinates.Y, Coordinates.X1, Coordinates.Y1, Canvas);
            Coordinates.X = 0;
            Coordinates.Y = 0;
            Coordinates.X1 = 0;
            Coordinates.Y1 = 0;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            round round = new round();
            round.ShowDialog();
            Draw.circle(Coordinates.X, Coordinates.Y, Coordinates.R, Canvas);
            Coordinates.X = 0;
            Coordinates.Y = 0;
            Coordinates.R = 0;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
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
            catch (Exception exc)
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
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            if (op == "+")
            {
                tb.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                tb.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text += "=" + (op1 * op2);
            }
            else
            {
                tb.Text += "=" + (op1 / op2);
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}