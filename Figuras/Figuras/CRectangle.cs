using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public class CRectangle : Poligono
    {

        //Métodos
        public CRectangle() {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public override void ReadData(TextBox[] textBoxNames) {
            try
            {
                if (validateInput(textBoxNames)) {
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
        public override void Perimeter() {
            mPerimeter = 2 * mWidth + 2 * mHeight;
        }
        public override void Area() {
            mArea = mWidth * mHeight;
        }
        //Función que grafica un rectángulo.
        public override void PlotShape(PictureBox picCanvas) {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectángulo.
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }

        //Función que cierra un formulario.
        
    }
}
