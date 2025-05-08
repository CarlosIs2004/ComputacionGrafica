using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras 
{
    internal class CEstrella : Poligono
    {
        // Atributos
        private float sRadiusOuter; // Radio de las puntas
        private float sRadiusInner; // Radio entre puntas
        public CEstrella() {
            mArea = 0.0f;
            mPerimeter = 0.0f;
            sRadiusInner = 0.0f;
            sRadiusOuter = 0.0f;

        }

        // Métodos
        public override void ReadData(TextBox[] textBoxesNames)
        {
            try
            {
                if (validateInput(textBoxesNames)) {
                    sRadiusOuter = float.Parse(textBoxesNames[0].Text);
                    sRadiusInner = float.Parse(textBoxesNames[1].Text);
                    Perimeter();
                    Area();
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public override void Perimeter()
        {
            int n = 5; // 5 puntas
            double angle = Math.PI / n;
            mPerimeter = (float)(2 * n * Math.Sqrt(
                sRadiusOuter * sRadiusOuter +
                sRadiusInner * sRadiusInner -
                2 * sRadiusOuter * sRadiusInner * Math.Cos(angle)
            ));
        }

        public override void Area()
        {
            int n = 5; // 5 puntas
            double angle = 2 * Math.PI / n;
            mArea = (float)((n / 2.0) * sRadiusOuter * sRadiusInner * Math.Sin(angle));
        }


        public override void PlotShape(PictureBox picCanvas)
        {
            // Validar que los radios sean mayores a 0
            if (sRadiusOuter <= 0 || sRadiusInner <= 0)
            {
                MessageBox.Show("Los radios deben ser mayores a 0.", "Error");
                return;
            }

            Graphics eGraph = picCanvas.CreateGraphics();
            Pen ePen = new Pen(Color.Blue, 3);

            // Centro del PictureBox
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;


            // Array para almacenar los 10 puntos de la estrella
            PointF[] starPoints = new PointF[10];

            // Ángulo inicial
            double angle = -Math.PI / 2; // Apunta hacia arriba

            for (int i = 0; i < 10; i++)
            {
                // Cada vértice alterna entre radio mayor y menor
                float radius = (i % 2 == 0) ? sRadiusOuter * SF : sRadiusInner * SF;

                // Calcular coordenadas usando seno y coseno
                float x = centerX + (float)(radius * Math.Cos(angle));
                float y = centerY + (float)(radius * Math.Sin(angle));

                starPoints[i] = new PointF(x, y);

                // Avanzar ángulo 36° (π/5 radianes)
                angle += Math.PI / 5;
            }

            // Dibujar la estrella conectando los puntos
            eGraph.DrawPolygon(ePen, starPoints);
        }

    }
}
