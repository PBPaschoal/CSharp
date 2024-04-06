namespace JogoForca
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
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnTentar = new System.Windows.Forms.Button();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(516, 295);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(100, 20);
            this.txtLetra.TabIndex = 0;
            this.txtLetra.TextChanged += new System.EventHandler(this.txtLetra_TextChanged);
            // 
            // btnTentar
            // 
            this.btnTentar.Location = new System.Drawing.Point(540, 143);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(75, 23);
            this.btnTentar.TabIndex = 1;
            this.btnTentar.Text = "button1";
            this.btnTentar.UseVisualStyleBackColor = true;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(351, 199);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(35, 13);
            this.lblPalavra.TabIndex = 2;
            this.lblPalavra.Text = "label1";
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Location = new System.Drawing.Point(247, 342);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(35, 13);
            this.lblTentativas.TabIndex = 3;
            this.lblTentativas.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.btnTentar);
            this.Controls.Add(this.txtLetra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnTentar;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label lblTentativas;
    }
}

