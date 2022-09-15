namespace Devs2Blu.ProjetosAula.Aula6Jogo21
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
            this.groupBoxTabuleiro = new System.Windows.Forms.GroupBox();
            this.textBoxTabuleiro = new System.Windows.Forms.TextBox();
            this.groupBoxPlayer1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlayer1Entrada = new System.Windows.Forms.TextBox();
            this.buttonPlayer1Ok = new System.Windows.Forms.Button();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.groupBoxPlayer2 = new System.Windows.Forms.GroupBox();
            this.textBoxPlayer2Entrada = new System.Windows.Forms.TextBox();
            this.buttonPlayer2Ok = new System.Windows.Forms.Button();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.buttonTabuleiroIniciar = new System.Windows.Forms.Button();
            this.buttonTabuleiroNovoJogo = new System.Windows.Forms.Button();
            this.groupBoxTabuleiro.SuspendLayout();
            this.groupBoxPlayer1.SuspendLayout();
            this.groupBoxPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTabuleiro
            // 
            this.groupBoxTabuleiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBoxTabuleiro.Controls.Add(this.textBoxTabuleiro);
            this.groupBoxTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTabuleiro.ForeColor = System.Drawing.Color.White;
            this.groupBoxTabuleiro.Location = new System.Drawing.Point(101, 34);
            this.groupBoxTabuleiro.Name = "groupBoxTabuleiro";
            this.groupBoxTabuleiro.Size = new System.Drawing.Size(603, 166);
            this.groupBoxTabuleiro.TabIndex = 0;
            this.groupBoxTabuleiro.TabStop = false;
            this.groupBoxTabuleiro.Text = "Jogo 21 - Tabuleiro";
            // 
            // textBoxTabuleiro
            // 
            this.textBoxTabuleiro.Enabled = false;
            this.textBoxTabuleiro.Location = new System.Drawing.Point(47, 34);
            this.textBoxTabuleiro.Multiline = true;
            this.textBoxTabuleiro.Name = "textBoxTabuleiro";
            this.textBoxTabuleiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTabuleiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTabuleiro.Size = new System.Drawing.Size(508, 106);
            this.textBoxTabuleiro.TabIndex = 0;
            this.textBoxTabuleiro.TextChanged += new System.EventHandler(this.textBoxTabuleiro_TextChanged);
            // 
            // groupBoxPlayer1
            // 
            this.groupBoxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBoxPlayer1.Controls.Add(this.textBoxPlayer1Entrada);
            this.groupBoxPlayer1.Controls.Add(this.buttonPlayer1Ok);
            this.groupBoxPlayer1.Controls.Add(this.textBoxPlayer1);
            this.groupBoxPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayer1.ForeColor = System.Drawing.Color.White;
            this.groupBoxPlayer1.Location = new System.Drawing.Point(32, 280);
            this.groupBoxPlayer1.Name = "groupBoxPlayer1";
            this.groupBoxPlayer1.Size = new System.Drawing.Size(257, 145);
            this.groupBoxPlayer1.TabIndex = 1;
            this.groupBoxPlayer1.TabStop = false;
            this.groupBoxPlayer1.Text = "Player 1";
            // 
            // textBoxPlayer1Entrada
            // 
            this.textBoxPlayer1Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPlayer1Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1Entrada.ForeColor = System.Drawing.Color.White;
            this.textBoxPlayer1Entrada.Location = new System.Drawing.Point(157, 109);
            this.textBoxPlayer1Entrada.Name = "textBoxPlayer1Entrada";
            this.textBoxPlayer1Entrada.Size = new System.Drawing.Size(77, 26);
            this.textBoxPlayer1Entrada.TabIndex = 2;
            this.textBoxPlayer1Entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPlayer1Ok
            // 
            this.buttonPlayer1Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlayer1Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer1Ok.Location = new System.Drawing.Point(21, 109);
            this.buttonPlayer1Ok.Name = "buttonPlayer1Ok";
            this.buttonPlayer1Ok.Size = new System.Drawing.Size(75, 30);
            this.buttonPlayer1Ok.TabIndex = 1;
            this.buttonPlayer1Ok.Text = "Ok";
            this.buttonPlayer1Ok.UseVisualStyleBackColor = false;
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Enabled = false;
            this.textBoxPlayer1.Location = new System.Drawing.Point(21, 19);
            this.textBoxPlayer1.Multiline = true;
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlayer1.Size = new System.Drawing.Size(214, 83);
            this.textBoxPlayer1.TabIndex = 0;
            // 
            // groupBoxPlayer2
            // 
            this.groupBoxPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBoxPlayer2.Controls.Add(this.textBoxPlayer2Entrada);
            this.groupBoxPlayer2.Controls.Add(this.buttonPlayer2Ok);
            this.groupBoxPlayer2.Controls.Add(this.textBoxPlayer2);
            this.groupBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayer2.ForeColor = System.Drawing.Color.White;
            this.groupBoxPlayer2.Location = new System.Drawing.Point(510, 280);
            this.groupBoxPlayer2.Name = "groupBoxPlayer2";
            this.groupBoxPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxPlayer2.Size = new System.Drawing.Size(257, 145);
            this.groupBoxPlayer2.TabIndex = 2;
            this.groupBoxPlayer2.TabStop = false;
            this.groupBoxPlayer2.Text = "Player 2(PC)";
            // 
            // textBoxPlayer2Entrada
            // 
            this.textBoxPlayer2Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPlayer2Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2Entrada.ForeColor = System.Drawing.Color.White;
            this.textBoxPlayer2Entrada.Location = new System.Drawing.Point(21, 111);
            this.textBoxPlayer2Entrada.Name = "textBoxPlayer2Entrada";
            this.textBoxPlayer2Entrada.Size = new System.Drawing.Size(79, 26);
            this.textBoxPlayer2Entrada.TabIndex = 2;
            this.textBoxPlayer2Entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPlayer2Ok
            // 
            this.buttonPlayer2Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlayer2Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayer2Ok.Location = new System.Drawing.Point(160, 109);
            this.buttonPlayer2Ok.Name = "buttonPlayer2Ok";
            this.buttonPlayer2Ok.Size = new System.Drawing.Size(75, 30);
            this.buttonPlayer2Ok.TabIndex = 1;
            this.buttonPlayer2Ok.Text = "Ok";
            this.buttonPlayer2Ok.UseVisualStyleBackColor = false;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(21, 19);
            this.textBoxPlayer2.Multiline = true;
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlayer2.Size = new System.Drawing.Size(215, 83);
            this.textBoxPlayer2.TabIndex = 0;
            // 
            // buttonTabuleiroIniciar
            // 
            this.buttonTabuleiroIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabuleiroIniciar.Location = new System.Drawing.Point(356, 280);
            this.buttonTabuleiroIniciar.Name = "buttonTabuleiroIniciar";
            this.buttonTabuleiroIniciar.Size = new System.Drawing.Size(87, 23);
            this.buttonTabuleiroIniciar.TabIndex = 3;
            this.buttonTabuleiroIniciar.Text = "Iniciar";
            this.buttonTabuleiroIniciar.UseVisualStyleBackColor = true;
            this.buttonTabuleiroIniciar.Click += new System.EventHandler(this.buttonTabuleiroIniciar_Click);
            // 
            // buttonTabuleiroNovoJogo
            // 
            this.buttonTabuleiroNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabuleiroNovoJogo.Location = new System.Drawing.Point(356, 330);
            this.buttonTabuleiroNovoJogo.Name = "buttonTabuleiroNovoJogo";
            this.buttonTabuleiroNovoJogo.Size = new System.Drawing.Size(87, 27);
            this.buttonTabuleiroNovoJogo.TabIndex = 4;
            this.buttonTabuleiroNovoJogo.Text = "Novo Jogo";
            this.buttonTabuleiroNovoJogo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTabuleiroNovoJogo);
            this.Controls.Add(this.buttonTabuleiroIniciar);
            this.Controls.Add(this.groupBoxPlayer2);
            this.Controls.Add(this.groupBoxPlayer1);
            this.Controls.Add(this.groupBoxTabuleiro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Projeto Aula Devs2Blu Jogo 21 ";
            this.groupBoxTabuleiro.ResumeLayout(false);
            this.groupBoxTabuleiro.PerformLayout();
            this.groupBoxPlayer1.ResumeLayout(false);
            this.groupBoxPlayer1.PerformLayout();
            this.groupBoxPlayer2.ResumeLayout(false);
            this.groupBoxPlayer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTabuleiro;
        private System.Windows.Forms.GroupBox groupBoxPlayer1;
        private System.Windows.Forms.GroupBox groupBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxTabuleiro;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Button buttonTabuleiroIniciar;
        private System.Windows.Forms.Button buttonTabuleiroNovoJogo;
        private System.Windows.Forms.TextBox textBoxPlayer1Entrada;
        private System.Windows.Forms.Button buttonPlayer1Ok;
        private System.Windows.Forms.TextBox textBoxPlayer2Entrada;
        private System.Windows.Forms.Button buttonPlayer2Ok;
    }
}

