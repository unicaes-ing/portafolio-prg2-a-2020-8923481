using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                lstTabla.Items.Add(numero);
                txtNumero.Clear();
                txtNumero.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show(" Porfavor ingrese un número");
                txtNumero.SelectAll();
                txtNumero.Focus();
            }
        }
        public static int Buscar(int numbuscar, ListBox lista)
        {
            int cont = 0;
            foreach (int n in lista.Items)
            {
                if (n == numbuscar) cont++;
            }
            return cont;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtBuscar.Text);
                int cant = Buscar(num, lstTabla);
                MessageBox.Show("Se encuentra " + cant + " veces ");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                txtBuscar.SelectAll();
                txtBuscar.Focus();
            }
        }
    }
}
