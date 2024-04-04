using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtPrimeiroNumero.Text);
            double segundoNumero = double.Parse(txtSegundoNumero.Text);
            double resultado = primeiroNumero + segundoNumero;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double primeiroNumero = double.Parse(txtPrimeiroNumero.Text);
            double segundoNumero = double.Parse(txtSegundoNumero.Text);
            double resultado = primeiroNumero - segundoNumero;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }
    }
}
