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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtBin.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 2);
            txtOct.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 8);
            txtHexa.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 16);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Clear();
            txtBin.Clear();
            txtOct.Clear();
            txtHexa.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
