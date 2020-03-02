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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = 0, cant = 0, subt, imp, total;
            try
            {
                precio = Convert.ToDouble(txtPrecio.Text);
                cant = Convert.ToDouble(txtCantidad.Text);
                subt = precio * cant;
                imp = subt * 0.13;
                total = subt + imp;
                txtSub.Text = string.Format("{0:C2}", subt);
                txtImpuesto.Text = string.Format("{0:C2}", imp);
                txtTotal.Text = string.Format("{0:C2}", total);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

            txtPrecio.Clear();
            txtCantidad.Clear();
            txtImpuesto.Clear();
            txtSub.Clear();
            txtTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
