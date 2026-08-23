namespace JogoForca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLetra = new TextBox();
            btnTentar = new Button();
            lblPalavra = new Label();
            lblTentativas = new Label();
            SuspendLayout();
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(141, 59);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(100, 23);
            txtLetra.TabIndex = 0;
            // 
            // btnTentar
            // 
            btnTentar.Location = new Point(270, 59);
            btnTentar.Name = "btnTentar";
            btnTentar.Size = new Size(75, 23);
            btnTentar.TabIndex = 1;
            btnTentar.Text = "Conferir";
            btnTentar.UseVisualStyleBackColor = true;
            btnTentar.Click += btnTentar_Click;
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Location = new Point(141, 85);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(38, 15);
            lblPalavra.TabIndex = 2;
            lblPalavra.Text = "label1";
            // 
            // lblTentativas
            // 
            lblTentativas.AutoSize = true;
            lblTentativas.Location = new Point(26, 18);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(38, 15);
            lblTentativas.TabIndex = 3;
            lblTentativas.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 154);
            Controls.Add(lblTentativas);
            Controls.Add(lblPalavra);
            Controls.Add(btnTentar);
            Controls.Add(txtLetra);
            Name = "Form1";
            Text = "Jogo da Forca: PBPaschoal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLetra;
        private Button btnTentar;
        private Label lblPalavra;
        private Label lblTentativas;
    }
}
