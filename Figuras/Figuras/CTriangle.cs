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
    public class CTriangle : Poligono
    {
        private float lado;
        private float mitad_base;
        PointF[] puntos = new PointF[3];
        public CTriangle()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public override void Perimeter()
        {
            mitad_base = mWidth / 2;
            lado = (float)(Math.Sqrt(mitad_base * mitad_base + mHeight * mHeight));

            mPerimeter = mWidth + (2 * lado);
        }
        public override void Area()
        {
            mArea = (mWidth * mHeight) / 2;
        }
        //Función que grafica un rectángulo.
        public override void PlotShape(PictureBox picCanvas)
        {
            float widthScale = mWidth * SF;
            float heightScale = mHeight * SF ;
            float medWhidthScale = (mWidth/2) * SF ;

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            puntos[0] = new PointF(medWhidthScale, 0);   // vértice superior
            puntos[1] = new PointF(0 ,heightScale );   // inferior izquierdo
            puntos[2] = new PointF(widthScale, heightScale);  // inferior derecho
            mGraph.DrawPolygon(mPen, puntos);
        }
        // Manejamos acada entrada del usuario como un arreglo, para que en este caso se tenga la fexibilidad de poner cuentas entradas´podamos
        public override void ReadData(TextBox[] textBoxNames)
        {
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


    }
}
