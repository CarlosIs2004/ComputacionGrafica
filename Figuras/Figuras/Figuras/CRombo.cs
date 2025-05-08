using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class CRombo : Poligono
    {
        public CRombo()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }


        public override void Area()
        {
            mArea = (mWidth * mHeight) / 2;
        }

        public override void Perimeter()
        {
            double mitadMayor = mHeight / 2.0;
            double mitadMenor = mWidth / 2.0;
            double lado = Math.Sqrt(mitadMayor * mitadMayor + mitadMenor * mitadMenor);
            mPerimeter = (float)(lado * 4);
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
