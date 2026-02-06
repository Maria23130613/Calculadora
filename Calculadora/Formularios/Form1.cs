using System;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 0;
                int resultado = 0;
                a = Convert.ToInt32(txtVariableA.Text);
                b = int.Parse(txtVariableB.Text);
                if (rdbSuma.Checked)
                    resultado = a + b;
                if (rdbResta.Checked)
                    resultado = a - b;
                if (rdbMultiplcacion.Checked)
                    resultado = a * b;
                if (rdbDivision.Checked)
                    resultado = a / b;

               // resultado = a + b;

                MessageBox.Show("El resultado es " + resultado.ToString(), "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();
        }
    }
}
