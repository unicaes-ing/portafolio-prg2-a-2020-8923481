using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int horas;
                double valordehora, subtotal, impuesto, total;
                horas = Convert.ToInt32(txtValor.Text);
                valordehora = Convert.ToDouble(txtValor.Text);
                subtotal = horas * valordehora;
                impuesto = subtotal * 0.13;
                total = subtotal - impuesto;
                dataGridView1.Rows.Add(nombre, horas, valordehora, subtotal, impuesto, total);
                dataGridView1.ClearSelection();
                lblSub.Text = "Subtotal = $" + subtotal.ToString("N2");
                lblImpuesto.Tex = "Impuesto = $" + impuesto.ToString("N2");
                lblTotal.Text = "Total = $" + total.ToString("N2");
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE LOS DATOS, TODOS LOS CAMPOS SON OBLIGATORIOS");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtNombre.Clear();
            txtValor.Clear();
        }
    }
}
