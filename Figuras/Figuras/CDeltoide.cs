using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class CDeltoide : Poligono
    {
        private List<Point> points;
        Point point;

        Point point1;

        Point point2;

        Point point3;
        public CDeltoide()

        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            points = new List<Point>();
        }

        public override void Area()
        {
            mArea = (mWidth * mHeight) / 2;
        }

        public override void Perimeter()
        {
            point = new Point((int)((mWidth/2)*SF) ,(int)(mHeight*SF));
            point1 = new Point((int)(mWidth*SF), (int)((mHeight / 3)*SF));
            point2 = new Point((int)((mWidth / 2)*SF), (int)(0));
            point3 = new Point((int)(0), (int)((mHeight / 3)*SF));

            // Calcula la distancia entre los puntos (lados del deltoide)
            double lado1 = Distancia(point, point1); // inferior a derecha
            double lado2 = Distancia(point1, point2); // derecha a superior
            double lado3 = Distancia(point2, point3); // superior a izquierda
            double lado4 = Distancia(point3, point); // izquierda a inferior
            points.Clear();
            points.Add(point);
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);

            mPerimeter = (float)(lado1 + lado2 + lado3 + lado4);
        }

        public override void ReadData(TextBox[] textBoxNames)
        {

            try
            {
                if (validateInput(textBoxNames))
                {
                    mWidth = float.Parse(textBoxNames[0].Text);
                    mHeight = float.Parse(textBoxNames[1].Text);
                    Area();
                    Perimeter();
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no valido....", "Mensaje de error");
            }
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawPolygon(mPen, points.ToArray());
                
        }

        private double Distancia(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}
