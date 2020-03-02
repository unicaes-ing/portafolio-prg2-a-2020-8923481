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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int cont = 0;
            lstTabla.Items.Clear();
            for (int i = 1; i < 5000; i++)
            {
                int num = r.Next(1, 7);
                if (num == 6) cont++;
            }
            MessageBox.Show("Se obtuvo " + cont + " veces el 6");
        }
    
    }
}
