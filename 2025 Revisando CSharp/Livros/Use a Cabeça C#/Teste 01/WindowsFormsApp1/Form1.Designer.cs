namespace WindowsFormsApp1
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
            this.caixadeimagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.caixadeimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // caixadeimagem
            // 
            this.caixadeimagem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.caixadeimagem.Location = new System.Drawing.Point(182, 100);
            this.caixadeimagem.Name = "caixadeimagem";
            this.caixadeimagem.Size = new System.Drawing.Size(300, 100);
            this.caixadeimagem.TabIndex = 0;
            this.caixadeimagem.TabStop = false;
            this.caixadeimagem.Click += new System.EventHandler(this.caixadeimagem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caixadeimagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.caixadeimagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox caixadeimagem;
    }
}

