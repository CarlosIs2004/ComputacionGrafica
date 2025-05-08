using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    
    public abstract class Poligono
    {
        protected float mWidth;
        protected float mHeight;
        protected float mPerimeter;
        protected float mArea;
        protected Graphics mGraph;
        protected const float SF = 20;
        protected Pen mPen;

        public abstract void ReadData(TextBox []txtNames);
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text =  Math.Round(mPerimeter,3).ToString();
            txtArea.Text = Math.Round(mArea,3).ToString();
        }
        public abstract void PlotShape(PictureBox picCanvas);
        public abstract void Perimeter();
        public abstract void Area();
        // Validación de las entradas en cada petición válida entradas en
        // blancon , con espacios, sean números, no admite numeros negativos,  
        public bool validateInput(TextBox []textBoxNames) {

            foreach (TextBox textBoxName in textBoxNames) {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    MessageBox.Show("Algun dato está vacio, revisa tus campos de entrada");
                    return false;
                }
                
                if (!float.TryParse(textBoxName.Text, out float number))
                {
                    MessageBox.Show($"El valor {textBoxName.Text} no es un numero, revisa tus campos de entrada");
                    return false;
                }

                if (float.TryParse(textBoxName.Text, out float number1)) { 
                    if(number1 <=0)
                    {
                        MessageBox.Show("No se permite numeros negativos o cero");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
