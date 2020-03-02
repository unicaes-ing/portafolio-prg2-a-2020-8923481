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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double exa1, exa2, exa3;
            exa1 = Convert.ToDouble(txtExa1.Text);
            exa2 = Convert.ToDouble(txtExa2.Text);
            exa3 = Convert.ToDouble(txtExa3.Text);
            txtPromedio.Text = ((exa1 + exa2 + exa3) / 3.0).ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExa1.Clear();
            txtExa2.Clear();
            txtExa3.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
