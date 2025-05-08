using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Menu : Form
    {
        Form fn;
        Poligono poligono ;
        TextBox[] txtNames;
        public Menu()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSquare());
            picCanvas.Refresh();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRectangle());
            picCanvas.Refresh();
        }

        private void semicirculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSemiCircle());
            picCanvas.Refresh();
        }
        
        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmElipse());
            picCanvas.Refresh();

        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Triangle());
            picCanvas.Refresh();

        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCircle());
            picCanvas.Refresh();

        }
        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTrapecio());
            picCanvas.Refresh();

        }
        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTrapezoide());
            picCanvas.Refresh();

        }
        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRombo());
            picCanvas.Refresh();
        }
        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRomboide());
            picCanvas.Refresh();
        }

        private void openChildForm(object childForm) {
            if (this.inputFigue.Controls.Count > 0)
                this.inputFigue.Controls.RemoveAt(0);
            fn = childForm as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.inputFigue.Controls.Add(fn);
            this.inputFigue.Tag = fn;
            fn.Show();
        
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (fn.Name == "frmSquare")
            {
                poligono = new CSquare();

                frmSquare square = Application.OpenForms.OfType<frmSquare>().FirstOrDefault();
                TextBox valor = square.Controls["txtSide"] as TextBox;
                txtNames = new TextBox[] { valor };
                //Llamada a la función ReadData
                poligono.ReadData(txtNames);


            }
            else if (fn.Name == "frmRectangle")
            {
                poligono = new CRectangle();
                frmRectangle square = Application.OpenForms.OfType<frmRectangle>().FirstOrDefault();
                TextBox txtWidthRectangle = square.Controls["txtWidth"] as TextBox;
                TextBox txtHeightRectangle = square.Controls["txtHeight"] as TextBox;
                txtNames = new TextBox[] { txtWidthRectangle, txtHeightRectangle };
                poligono.ReadData(txtNames);


            }
            else if (fn.Name == "Triangle")
            {

                poligono = new CTriangle();
                Triangle triangle = Application.OpenForms.OfType<Triangle>().FirstOrDefault();
                TextBox txtWidthTriangle = triangle.Controls["txtWidthTriangle"] as TextBox;
                TextBox txtHeightTriangle = triangle.Controls["txtHeightTriangle"] as TextBox;
                txtNames = new TextBox[] { txtWidthTriangle, txtHeightTriangle };
                poligono.ReadData(txtNames);

            }
            else if (fn.Name == "frmCircle")
            {
                poligono = new CCircle();
                frmCircle circle = Application.OpenForms.OfType<frmCircle>().FirstOrDefault();
                TextBox txtRadius = circle.Controls["txtRadius"] as TextBox;
                txtNames = new TextBox[] { txtRadius };
                poligono.ReadData(txtNames);

            }
            else if (fn.Name == "frmElipse")
            {
                poligono = new CElipse();
                frmElipse elipse = Application.OpenForms.OfType<frmElipse>().FirstOrDefault();
                TextBox bWidth = elipse.Controls["txtWidthElipse"] as TextBox;
                TextBox aHeight = elipse.Controls["txtHeightElipse"] as TextBox;
                txtNames = new TextBox[] { bWidth, aHeight };
                poligono.ReadData(txtNames);
            }
            else if (fn.Name == "frmSemiCircle")
            {
                poligono = new CSemiCircle();
                frmSemiCircle semiCircle = Application.OpenForms.OfType<frmSemiCircle>().FirstOrDefault();
                TextBox txtRadius = semiCircle.Controls["txtRadiusSemiCircle"] as TextBox;
                txtNames = new TextBox[] { txtRadius };
                poligono.ReadData(txtNames);

            }
            else if (fn.Name == "frmTrapecio")
            {
                poligono = new CTrapecio();
                frmTrapecio trapecio = Application.OpenForms.OfType<frmTrapecio>().FirstOrDefault();
                TextBox baseMayor = trapecio.Controls["txtBaseMayor"] as TextBox;
                TextBox baseMenor = trapecio.Controls["txtBaseMenor"] as TextBox;
                TextBox altura = trapecio.Controls["txtAltura"] as TextBox;
                txtNames = new TextBox[] { baseMayor, baseMenor, altura };
                poligono.ReadData(txtNames);
            }
            else if (fn.Name == "frmTrapezoide")
            {
                poligono = new CTrapezoide();
                frmTrapezoide trapezoide = Application.OpenForms.OfType<frmTrapezoide>().FirstOrDefault();
                TextBox p1x = trapezoide.Controls["p1x"] as TextBox;
                TextBox p1y = trapezoide.Controls["p1y"] as TextBox;
                TextBox p2x = trapezoide.Controls["p2x"] as TextBox;
                TextBox p2y = trapezoide.Controls["p2y"] as TextBox;
                TextBox p3x = trapezoide.Controls["p3x"] as TextBox;
                TextBox p3y = trapezoide.Controls["p3y"] as TextBox;
                TextBox p4x = trapezoide.Controls["p4x"] as TextBox;
                TextBox p4y = trapezoide.Controls["p4y"] as TextBox;
                txtNames = new TextBox[] { p1x, p1y, p2x, p2y, p3x, p3y, p4x, p4y };
                poligono.ReadData(txtNames);


            }
            else if (fn.Name == "frmRombo")
            {
                poligono = new CRombo();
                frmRombo rombo = Application.OpenForms.OfType<frmRombo>().FirstOrDefault();
                TextBox DMayor = rombo.Controls["txtDHeight"] as TextBox;
                TextBox DMenor = rombo.Controls["txtDWidth"] as TextBox;
                txtNames = new TextBox[] { DMenor, DMayor };
                poligono.ReadData(txtNames);
            }
            else if (fn.Name == "frmRomboide")
            {
                poligono = new CRomboide();
                frmRomboide romboide = Application.OpenForms.OfType<frmRomboide>().FirstOrDefault();
                TextBox mWidthRom = romboide.Controls["txtWidthRom"] as TextBox;
                TextBox mHeigthRom = romboide.Controls["txtHeightRom"] as TextBox;
                txtNames = new TextBox[] { mWidthRom, mHeigthRom };
                poligono.ReadData(txtNames);

            }
            else if (fn.Name == "frmDeltoide")
            {
                poligono = new CDeltoide();
                frmDeltoide deltoide = Application.OpenForms.OfType<frmDeltoide>().FirstOrDefault();
                TextBox mWidthDel = deltoide.Controls["txtDelWidth"] as TextBox;
                TextBox mHeigtDel = deltoide.Controls["txtDelHeight"] as TextBox;
                txtNames = new TextBox[] { mWidthDel, mHeigtDel };
                poligono.ReadData(txtNames);


            }
            else if (fn.Name == "frmEstrella") {
                poligono = new CEstrella();
                frmEstrella estrella = Application.OpenForms.OfType<frmEstrella>().FirstOrDefault();
                TextBox txtRadioMayor = estrella.Controls["txtRadioMayor"] as TextBox;
                TextBox txtRadioMenor = estrella.Controls["txtRadioMenor"] as TextBox;
                txtNames = new TextBox[] { txtRadioMayor, txtRadioMenor };
                poligono.ReadData(txtNames);

            
            }
            poligono.PrintData(txtPerimeter,txtArea);
            poligono.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDeltoide());
            picCanvas.Refresh();
        }

        private void estrellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEstrella());
            picCanvas.Refresh();
        }

      
    }
}
