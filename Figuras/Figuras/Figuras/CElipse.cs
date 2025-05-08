using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public class CElipse : Poligono
    {

        private float a;
        private float b;
        public CElipse() {
            mWidth = 0.0f;
            mHeight = 0.0f;
            a = 0.0f;
            b = 0.0f;
        }
        public override void ReadData(TextBox[] textBoxesNames)
        {
            try
            {
                if (validateInput(textBoxesNames)) {
                    mWidth = float.Parse(textBoxesNames[0].Text);
                    mHeight = float.Parse(textBoxesNames[1].Text);
                    a = mHeight / 2;
                    b = mWidth / 2;
                    Area();
                    Perimeter();
                }
            }
            catch 
            {
                MessageBox.Show("Ingreso no valido....", "Mensaje de error");
            }
        }

        public override void Perimeter()
        {
            mPerimeter = (float)(2*Math.PI*Math.Sqrt((Math.Pow(a,2)+Math.Pow(b,2))/2));
        }
        public override void Area(){
            mArea = (float)(Math.PI * a * b);
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawEllipse(mPen, 0, 0, a * SF, b * SF);
        }

    }
}
