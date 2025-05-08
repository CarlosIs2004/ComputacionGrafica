using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Figuras
{
    internal class CTrapecio : Poligono
    {
        float baseMayor;
        float baseMenor;
        float altura;
        public CTrapecio()
        {
            baseMayor = 0.0f; baseMenor = 0.0f; altura = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public override void ReadData(TextBox[] textBoxNames)
        {
            try
            {
                if (validateInput(textBoxNames) && validarDatosTrapecio(textBoxNames))
                {
                    baseMayor = float.Parse(textBoxNames[0].Text);
                    baseMenor = float.Parse(textBoxNames[1].Text);
                    altura = float.Parse(textBoxNames[2].Text);
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
            float catetoBase = (baseMayor - baseMenor)/2 ;
            float lado = (float)( Math.Sqrt( Math.Pow(catetoBase, 2) + Math.Pow(altura,2) ) );
            mPerimeter = baseMayor + baseMenor + (2 * lado);
        }
        public override void Area()
        {
            mArea = ((baseMayor + baseMenor)*altura)/2;
        }
        //Función que grafica un rectángulo.
        public override void PlotShape(PictureBox picCanvas)
        {
        

        }

        public bool validarDatosTrapecio(TextBox[] textBoxNames) {
            if (float.Parse(textBoxNames[0].Text) <= float.Parse(textBoxNames[1].Text)) {
                MessageBox.Show("El valor de la base mayor debe diferente y mas grande que la base menor");
                return false;
            }

            return true;
        
        }
    }
}
