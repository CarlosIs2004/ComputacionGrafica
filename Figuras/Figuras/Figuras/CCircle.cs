using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras 
{
    public class CCircle : Poligono
    {
        public float radius;
        public CCircle() {
            radius = 0.0f;
        }

        public override void ReadData(TextBox[] textBoxNames)
        {
            try
            {
                if (validateInput(textBoxNames)) { 
                    radius = float.Parse(textBoxNames[0].Text);
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
            mArea = (float)(Math.PI * Math.Pow(radius,2));
        }
        public override void Perimeter()
        {
            mPerimeter = (float) (2* Math.PI * radius) ;
        }

        public override void PlotShape(PictureBox picCanvas) {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawEllipse(mPen, SF, SF, radius*SF,radius*SF );
        }
    }
}
