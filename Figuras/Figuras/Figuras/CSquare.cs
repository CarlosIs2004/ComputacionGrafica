using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class CSquare : Poligono
    {
        //Atributos
        public float mSide;

        //Métodos
        public CSquare()
        {
            mSide = 0.0f;
        }
        public override void ReadData(TextBox[] textBoxNames) {
            try
            {
                if (validateInput(textBoxNames)) {
                    mSide = float.Parse(textBoxNames[0].Text);
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
            mPerimeter = 4 * mSide;
        }
        public override void Area()
        {
            mArea = mSide * mSide;
        }

        //Función que grafica un rectángulo.
        public override void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectángulo.
            mGraph.DrawRectangle(mPen, 0, 0, mSide * SF, mSide * SF);
            
        }
    }
}
