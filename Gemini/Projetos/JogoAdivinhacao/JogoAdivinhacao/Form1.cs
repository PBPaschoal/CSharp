using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoAdivinhacao
{
    public partial class Form1 : Form
    {
        int numeroSecreto = new Random().Next(1, 101);
        int tentativas = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTentar_Click(object sender, EventArgs e)
        {
            int palpite = int.Parse(txtPalpite.Text);

            if (tentativas > 0)
            {
                if (palpite == numeroSecreto)
                {
                    lblMensagem.Text = "Parabéns, você adivinhou o número secreto!";
                    btnTentar.Enabled = false;
                }
                else if (palpite < numeroSecreto)
                {
                    lblMensagem.Text = "O número secreto é maior que o seu palpite.";
                }
                else
                {
                    lblMensagem.Text = "O número secreto é menor que o seu palpite.";
                }

                tentativas--;
                lblTentativas.Text = "Tentativas Restantes: " + tentativas.ToString();

                if (tentativas == 0)
                {
                    lblMensagem.Text = "Você perdeu! O número secreto era " + numeroSecreto.ToString();
                    btnTentar.Enabled = false;
                }
            }

        }
    }
}
