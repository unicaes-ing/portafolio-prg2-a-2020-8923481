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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, fibo;
            num = Convert.ToInt32(txtNumero.Text);
            fibo = Fibonacci(num);
            txtFibonacci.Text = string.Format("{0}", fibo);
        }

        public static int Fibonacci(int num)
        {
            int a, b, c, tem;
            tem = num;
            a = 0;
            b = 1;
            for (int i = 0; i < tem; i++)
            {
                c = a;
                a = b;
                b = c + a;
            }
            return a;
        }
    }
}
