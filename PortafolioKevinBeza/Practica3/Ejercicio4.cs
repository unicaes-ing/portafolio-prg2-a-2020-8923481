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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            dataGridView.Size = new Size(210, 220);
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.ColumnCount = 10;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dataGridView.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dataGridView.Rows[f].Cells[c].Value = r.Next(10, 100);
                }
            }
            dataGridView.ClearSelection();
        }
    }
}
