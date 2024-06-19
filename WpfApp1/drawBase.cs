using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    public class DrawBase
    {

        public static void circle(double x, double y, int r, Canvas cv)
        {
            // Создание окружности.
            Ellipse circle = new Ellipse()
            {
                Width = r,
                Height = r,
                Stroke = Brushes.Black,
                StrokeThickness = 1.5
            };

            cv.Children.Add(circle);
            // Координаты расположения окружности и добавление ее на канвас.
            CircleValue(x, y, circle);
        }

        public static void line(double X1, double Y1, double X2, double Y2, Canvas cv)
        {
            // Создание линии.
            Line line = new Line()
            {
                X1 = X1,
                Y1 = Y1,
                X2 = X2,
                Y2 = Y2,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            // Координаты расположения линии и добавление ее на канвас.
            cv.Children.Add(line);
        }

        public static void lineCanvas(double X1, double Y1, double X2, double Y2, Canvas cv)
        {
            // Создание линии.
            Line lineCanvas = new Line()
            {
                X1 = X1,
                Y1 = Y1,
                X2 = X2,
                Y2 = Y2,
                Stroke = Brushes.MidnightBlue,
                StrokeThickness = 2,
                Opacity = 0.5
                
            };
            // Координаты расположения линии и добавление ее на канвас.
            cv.Children.Add(lineCanvas);
        }

        public static void point(double x, double y, Canvas cv)
        {
            // Создание окружности с размерами точки.
            Ellipse circle = new Ellipse()
            {
                Width = 3,
                Height = 3,
                Stroke = Brushes.Black,
                StrokeThickness = 3
            };
            // Добавление точки на канвас.
            cv.Children.Add(circle);
            // Координаты окружности с размерами точки.
            CircleValue(x, y, circle);
        }

        private static void CircleValue(double x, double y, Ellipse circle)
        {
            circle.SetValue(Canvas.LeftProperty, (double)x);
            circle.SetValue(Canvas.TopProperty, (double)y);
        }
    }
}