using System;
using System.Text;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class Form1 : Form
    {
        // Array de palavras
        string[] palavras = { "banana", "maçã", "casa", "mesa", "livro" };

        // Variáveis do jogo
        string palavraSecreta;
        string palavraComLetras = "";
        int tentativas = 6;
        int erros = 0;

        public Form1()
        {
            InitializeComponent();

            // Gerar palavra secreta
            palavraSecreta = palavras[new Random().Next(palavras.Length)];

            // Inicializar palavra com letras escondidas
            palavraComLetras = new string('_', palavraSecreta.Length);

            // Atualizar labels
            lblPalavra.Text = palavraComLetras;
            lblTentativas.Text = "Tentativas Restantes: " + tentativas.ToString();
        }

        private void btnTentar_Click(object sender, EventArgs e)
        {
            // Obter letra digitada
            string letra = txtLetra.Text.ToLower();

            if (tentativas > 0)
            {
                if (palavraSecreta.Contains(letra))
                {
                    // Atualizar palavra com as letras acertadas
                    StringBuilder novaPalavra = new StringBuilder(palavraComLetras);
                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        if (palavraSecreta[i] == letra[0]) // Verifica se a letra está correta
                        {
                            novaPalavra[i] = letra[0]; // Atualiza a letra na posição correta
                        }
                    }

                    palavraComLetras = novaPalavra.ToString(); // Atualiza a palavraComLetras com a nova palavra construída

                    // Atualizar labels
                    lblPalavra.Text = palavraComLetras;

                    // Verificar se a palavra foi completada
                    if (palavraComLetras == palavraSecreta)
                    {
                        MessageBox.Show("Parabéns, você adivinhou a palavra!");
                        btnTentar.Enabled = false;
                    }
                }
                else
                {
                    // Aumentar o número de erros
                    erros++;

                    // Atualizar labels
                    lblTentativas.Text = "Tentativas Restantes: " + (tentativas - erros).ToString();

                    // Verificar se o jogador perdeu
                    if (erros == tentativas)
                    {
                        MessageBox.Show("Você perdeu! A palavra secreta era " + palavraSecreta);
                        btnTentar.Enabled = false;
                    }
                }

                // Limpar a caixa de texto
                txtLetra.Text = "";
            }
        }
    }
}
