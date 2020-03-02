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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1, numero2, numero3, mayor;
                numero1 = Convert.ToDouble(txtNum1.Text);
                numero2 = Convert.ToDouble(txtNum2.Text);
                numero3 = Convert.ToDouble(txtNum3.Text);
                mayor = Mayor(numero1, numero2, numero3);
                lblMayor.Text = string.Format("{0}", mayor);
            }
            catch (Exception)
            {

                MessageBox.Show("Porfavor ingrese todos los números");
            }
        }

        public static double Mayor(double numero1, double numero2, double numero3)
        {
            double num1, num2, num3;
            num1 = numero1;
            num2 = numero2;
            num3 = numero3;
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
