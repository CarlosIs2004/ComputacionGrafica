using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class CTrapezoide : Poligono
    {

       
        Point point;
        private List<Point> points; 


        public CTrapezoide()
        {
            points = new List<Point>();
        }
        public override void ReadData(TextBox[] textBoxNames)
        {
            try
            {
                if (validateInput(textBoxNames))
                {
                    int x;
                    int y;
                    points.Clear();
                    for (int i = 0; i < textBoxNames.Length; i+=2) {
                        x = int.Parse(textBoxNames[i].Text);
                        y = int.Parse(textBoxNames[i + 1].Text); 
                        point = new Point(x,y);
                        points.Add(point);
                    }
                    Area();
                    Perimeter();
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no valido....", "Mensaje de error");
            }

        }

        public override void Area()
        {
            for (int i = 0; i < points.Count; i++)
            {
                Point p1 = points[i];
                Point p2 = points[(i + 1) % points.Count];
                mArea += (p1.X * p2.Y) - (p2.X * p1.Y);
            }
            mArea = (float)(Math.Abs(mArea) / 2.0);
            

        }
        private float Distance(Point a, Point b)
        {
            return (float)(Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));
        }

        public override void Perimeter()
        {
            for (int i = 0; i < points.Count; i++)
            {
                Point p1 = points[i];
                Point p2 = points[(i + 1) % points.Count];
                mPerimeter += Distance(p1, p2);
            }
        }

        

        public override void PlotShape(PictureBox picCanvas)
        {
            
        }
    }
}
