using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double inv1, inv2, inv3, tot;
            inv1 = Convert.ToDouble(txtInve1.Text);
            inv2 = Convert.ToDouble(txtInve2.Text);
            inv3 = Convert.ToDouble(txtInve3.Text);
            tot = (inv1 + inv2 + inv3);
            txtTotal.Text = String.Format("{0:N2}", tot);
            txtPorc1.Text = ((inv1 / tot) * 100.0).ToString("N2") + "%";
            txtPorc2.Text = ((inv2 / tot) * 100.0).ToString("N2") + "%";
            txtPorc3.Text = ((inv3 / tot) * 100.0).ToString("N2") + "%";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInve1.Clear();
            txtInve2.Clear();
            txtInve3.Clear();
            txtPorc1.Clear();
            txtPorc2.Clear();
            txtPorc3.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
