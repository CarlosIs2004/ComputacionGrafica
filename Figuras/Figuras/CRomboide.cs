using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class CRomboide : Poligono
    {
        public CRomboide()
        {

        }

        public override void Area()
        {
            mArea = mWidth * mHeight;
        }

        public override void Perimeter()
        {
            float lado = (float)(Math.Sqrt( Math.Pow(2,2) + Math.Pow(mHeight,2) ));
            mPerimeter = 2 * (mWidth + lado);
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
        }
    }
}
