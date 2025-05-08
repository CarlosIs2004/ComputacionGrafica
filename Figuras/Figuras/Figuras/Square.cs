using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras
{
    public partial class frmSquare : Form
    {
        public Poligono ObjSquare = new CSquare();

        public frmSquare()
        {
            InitializeComponent();
        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
