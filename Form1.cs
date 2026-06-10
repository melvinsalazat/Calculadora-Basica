using System;
using System.Windows.Forms;

namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private bool verificar_Contenido()
        {
            bool valido = true;

            ErrorEncontrado.Clear();

            if (string.IsNullOrWhiteSpace(txtnum1.Text))
            {
                ErrorEncontrado.SetError(txtnum1, "Ingrese el primer número.");
                valido = false;
            }
            else if (!double.TryParse(txtnum1.Text, out _))
            {
                ErrorEncontrado.SetError(txtnum1, "Debe ingresar un valor numérico.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtnum2.Text))
            {
                ErrorEncontrado.SetError(txtnum2, "Ingrese el segundo número.");
                valido = false;
            }
            else if (!double.TryParse(txtnum2.Text, out _))
            {
                ErrorEncontrado.SetError(txtnum2, "Debe ingresar un valor numérico.");
                valido = false;
            }

            return valido;
        }

        // Evento para el botón SUMAR
        private void btnSumar_Click_1(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 + num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para el botón RESTAR
        private void btnRestar_Click_1(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 - num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para el botón MULTIPLICAR
        private void btnMultiplicar_Click_1(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 * num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento para el botón DIVIDIR
        private void btnDividir_Click_1(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = num1 / num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void txtnum1_TextChanged(object sender, EventArgs e) { }

        private void txtnum2_TextChanged(object sender, EventArgs e) { }
    }
}