using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class CSemiCircle : Poligono
    {
        private float radius;
        public CSemiCircle() {
            radius = 0.0f;

        }
        public override void Area()
        {
            mArea = (float)(Math.PI * Math.Pow(radius,2))/2;
        }
        public override void Perimeter()
        {
            mPerimeter = (float)(2 * Math.PI * radius)/ 2;
        }

        public override void PlotShape(PictureBox picCanvas) {
            if (radius <= 0) return;

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            float diameter = radius * 2;
            RectangleF rect = new RectangleF(
                picCanvas.Width / 2 - radius * SF,
                picCanvas.Height /2 - radius * SF,
                diameter * SF,diameter * SF
                );
            mGraph.DrawArc(mPen, rect, 0 , 180);

        }
        public override void ReadData(TextBox[] textBoxesNames)
        {
            
            try
            {
                if (validateInput(textBoxesNames)) {
                    radius = float.Parse(textBoxesNames[0].Text);
                    if (radius <= 0) {
                        MessageBox.Show("No se permiten valores negativos");
                        return ;
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
    } 
}
