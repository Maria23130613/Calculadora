using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenamiento ordenamientos = new Ordenamiento();
            int[] ordenado = new int[dgvDesardenado.RowCount];
            for (int i = 0; i < dgvDesardenado.RowCount; i++)
            {
                ordenado[i] = Convert.ToInt32(dgvDesardenado.Rows[i].Cells[0].Value);
            }
            ordenado = ordenamientos.burbuja(ordenado);
            dgvOrdenado.DataSource = ordenado;
            for(int i=0;i<ordenado.Length;i++)
            {
                dgvOrdenado.Rows[i].Cells[0].Value = ordenado[i];
            }
        }
    }
}
