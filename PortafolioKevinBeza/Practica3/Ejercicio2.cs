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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstTabla.ForeColor = Color.Blue;
            lstTabla.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic);
            lstTabla.Items.Clear();
            for (char letras = 'A'; letras <= 'Z'; letras++)
            {
                lstTabla.Items.Add(letras);
            }
            lstTabla.Items.Insert(14, 'Ñ');
        }
    }

}
