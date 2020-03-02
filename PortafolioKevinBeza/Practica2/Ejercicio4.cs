using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            err.Clear();
            if (txtCorreo.TextLength < 0)
            {
                err.SetError(txtCorreo, "Ingrese un correo electronico");
                validado = false;
            }
            else
            {
                string patroncorreo = @"^([A-Z|a-z|0-9]{2,}[@]{1}[a-z]{2,}[.]{1,})";
                if (!Regex.IsMatch(txtCorreo.Text, patroncorreo))
                {
                    err.SetError(txtCorreo, "Ingrese un correo valido (Debe ingresar: \n @, una letra mayúscula, una minúscula y un número es obligatorio)");
                    validado = false;
                }
            }
            string patroncontraseña = @"^([A-Z]{1,}[a-z]{1,}[0-9]{1,})$";
            if (!Regex.IsMatch(txtContra.Text, patroncontraseña))
            {
                err.SetError(txtContra, "Debe contener al menos: \n Una letra mayúscula, una minúscula, un número");
                validado = false;
            }
            if (txtConfirm.Text != txtContra.Text)
            {
                err.SetError(txtConfirm, "Vuelva a ingresar la misma contraseña");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
