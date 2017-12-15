using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                fcuadro.Visible = false;
            frectangulo.Visible = false;
        }

        private void btncalcualr_Click(object sender, EventArgs e)
        {
            int l1, l2, a;
            l1 = Convert.ToInt16(tb1.Text);
            l2 = Convert.ToInt16(tb2.Text);
            a = l1 * l2;
            tba.Text = Convert.ToString(a);
            if (l1 == l2)
            {
                fcuadro.Visible = true;
                frectangulo.Visible = false;
            }
            else
            {
                fcuadro.Visible = false;
                frectangulo.Visible = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tba.Text = "";
            fcuadro.Visible = false;
            frectangulo.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea salir del programa                                                            Hecho Por:Starlin R. De La Cruz 15-SIST-1-087", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Close();
            }
        }
    }
}

