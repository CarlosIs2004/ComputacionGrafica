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
        private List<PointF> points;
        private PointF point;

        private PointF point1;

        private PointF point2;

        private PointF point3;
        public CDeltoide()

        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            points = new List<PointF>();
        }

        public override void Area()
        {
            mArea = (mWidth * mHeight) / 2;
        }

        public override void Perimeter()
        {
            double lado1 = Distancia(point, point1); // inferior a derecha
            double lado2 = Distancia(point1, point2); // derecha a superior
            double lado3 = Distancia(point2, point3); // superior a izquierda
            double lado4 = Distancia(point3, point); // izquierda a inferior
            

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

                    point = new PointF((mWidth / 2),mHeight);
                    point1 = new PointF(mWidth,(mHeight / 3));
                    point2 = new PointF((mWidth / 2), 0);
                    point3 = new PointF(0, (mHeight / 3));
                    points.Clear();
                    points.Add(point);
                    points.Add(point1);
                    points.Add(point2);
                    points.Add(point3);
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
            List<PointF> puntosGraficados = new List<PointF>(); 

            foreach (PointF p in points) {
                PointF newPoint = new PointF(p.X * SF, p.Y * SF);
                puntosGraficados.Add(newPoint);
            }
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawPolygon(mPen, puntosGraficados.ToArray());
                
        }

        private double Distancia(PointF p1, PointF p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }
    }
}
