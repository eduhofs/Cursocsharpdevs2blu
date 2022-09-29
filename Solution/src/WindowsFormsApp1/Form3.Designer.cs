namespace WindowsFormsApp1
{
    partial class FormQuestao4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEscolha = new System.Windows.Forms.Label();
            this.labelArroz = new System.Windows.Forms.Label();
            this.labelFeijao = new System.Windows.Forms.Label();
            this.labelFarinha = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEscolha
            // 
            this.labelEscolha.AutoSize = true;
            this.labelEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscolha.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEscolha.Location = new System.Drawing.Point(111, 38);
            this.labelEscolha.Name = "labelEscolha";
            this.labelEscolha.Size = new System.Drawing.Size(151, 20);
            this.labelEscolha.TabIndex = 0;
            this.labelEscolha.Text = "Escolha um produto";
            // 
            // labelArroz
            // 
            this.labelArroz.AutoSize = true;
            this.labelArroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArroz.ForeColor = System.Drawing.Color.DarkRed;
            this.labelArroz.Location = new System.Drawing.Point(117, 78);
            this.labelArroz.Name = "labelArroz";
            this.labelArroz.Size = new System.Drawing.Size(58, 13);
            this.labelArroz.TabIndex = 1;
            this.labelArroz.Text = "001 - Arroz";
            // 
            // labelFeijao
            // 
            this.labelFeijao.AutoSize = true;
            this.labelFeijao.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFeijao.Location = new System.Drawing.Point(117, 103);
            this.labelFeijao.Name = "labelFeijao";
            this.labelFeijao.Size = new System.Drawing.Size(62, 13);
            this.labelFeijao.TabIndex = 2;
            this.labelFeijao.Text = "002 - Feijão";
            // 
            // labelFarinha
            // 
            this.labelFarinha.AutoSize = true;
            this.labelFarinha.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFarinha.Location = new System.Drawing.Point(117, 126);
            this.labelFarinha.Name = "labelFarinha";
            this.labelFarinha.Size = new System.Drawing.Size(69, 13);
            this.labelFarinha.TabIndex = 3;
            this.labelFarinha.Text = "003 - Farinha";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(228, 398);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 4;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCodigo.Location = new System.Drawing.Point(112, 402);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(100, 16);
            this.labelCodigo.TabIndex = 5;
            this.labelCodigo.Text = "Digite o Codigo";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonBuscar.Location = new System.Drawing.Point(364, 396);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // FormQuestao4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelFarinha);
            this.Controls.Add(this.labelFeijao);
            this.Controls.Add(this.labelArroz);
            this.Controls.Add(this.labelEscolha);
            this.Name = "FormQuestao4";
            this.Text = "Questão 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEscolha;
        private System.Windows.Forms.Label labelArroz;
        private System.Windows.Forms.Label labelFeijao;
        private System.Windows.Forms.Label labelFarinha;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonBuscar;
    }
}