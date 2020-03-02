using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cant = 0;
                double precio, descuento = 0, sub, total = 0;
                cant = Convert.ToInt32(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);

                if (rdoDescuento1.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.0;
                    total = sub - descuento;
                }
                else if (rdoDescuento2.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.05;
                    total = sub - descuento;
                }
                else if (rdoDescuento3.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.10;
                    total = sub - descuento;
                }
                else if (rdoDescuento4.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.15;
                    total = sub - descuento;
                }
                else if (rdoDescuento5.Checked)
                {
                    sub = (cant * precio);
                    descuento = sub * 0.20;
                    total = sub - descuento;
                }
                txtDescuento.Text = string.Format("{0:C2}", descuento);
                txtTotal.Text = string.Format("{0:C2}", total);
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrecto");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtDescuento.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }
    }
}
