namespace JogoAdivinhacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTentar = new System.Windows.Forms.Button();
            this.txtPalpite = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTentar
            // 
            this.btnTentar.Location = new System.Drawing.Point(205, 66);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(75, 23);
            this.btnTentar.TabIndex = 0;
            this.btnTentar.Text = "Tentar";
            this.btnTentar.UseVisualStyleBackColor = true;
            this.btnTentar.Click += new System.EventHandler(this.btnTentar_Click);
            // 
            // txtPalpite
            // 
            this.txtPalpite.Location = new System.Drawing.Point(25, 34);
            this.txtPalpite.Name = "txtPalpite";
            this.txtPalpite.Size = new System.Drawing.Size(100, 20);
            this.txtPalpite.TabIndex = 1;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(22, 11);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(154, 13);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Digite um palpite entre 1 e 100:";
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Location = new System.Drawing.Point(160, 37);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(126, 13);
            this.lblTentativas.TabIndex = 3;
            this.lblTentativas.Text = "Tentativas Restantes: 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 140);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtPalpite);
            this.Controls.Add(this.btnTentar);
            this.Name = "Form1";
            this.Text = "Jogo de Adivinhação: PBPaschoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTentar;
        private System.Windows.Forms.TextBox txtPalpite;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblTentativas;
    }
}

