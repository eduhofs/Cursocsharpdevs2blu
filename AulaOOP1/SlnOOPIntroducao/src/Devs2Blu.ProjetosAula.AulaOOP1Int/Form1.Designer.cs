namespace Devs2Blu.ProjetosAula.AulaOOP1Int
{
    partial class FormAulaOOP1
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
            this.groupBoxCadastroDeFuncionario = new System.Windows.Forms.GroupBox();
            this.groupBoxTipoDeFuncionario = new System.Windows.Forms.GroupBox();
            this.radioButtonDiretor = new System.Windows.Forms.RadioButton();
            this.radioButtonRecepcionista = new System.Windows.Forms.RadioButton();
            this.labelAnos = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxNascimento = new System.Windows.Forms.TextBox();
            this.textBoxSobreNome = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxControles = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxStatusCadastroFuncionarios = new System.Windows.Forms.GroupBox();
            this.textBoxCadastroFuncionario = new System.Windows.Forms.TextBox();
            this.groupBoxCadastroDeFuncionario.SuspendLayout();
            this.groupBoxTipoDeFuncionario.SuspendLayout();
            this.groupBoxControles.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxStatusCadastroFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadastroDeFuncionario
            // 
            this.groupBoxCadastroDeFuncionario.BackColor = System.Drawing.Color.White;
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.groupBoxTipoDeFuncionario);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.labelAnos);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.textBoxEndereco);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.textBox4);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.textBoxNascimento);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.textBoxSobreNome);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.textBoxNome);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.labelEndereco);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.labelNascimento);
            this.groupBoxCadastroDeFuncionario.Controls.Add(this.labelNome);
            this.groupBoxCadastroDeFuncionario.Location = new System.Drawing.Point(26, 12);
            this.groupBoxCadastroDeFuncionario.Name = "groupBoxCadastroDeFuncionario";
            this.groupBoxCadastroDeFuncionario.Size = new System.Drawing.Size(492, 375);
            this.groupBoxCadastroDeFuncionario.TabIndex = 0;
            this.groupBoxCadastroDeFuncionario.TabStop = false;
            this.groupBoxCadastroDeFuncionario.Text = "Cadastro De Funcionarios";
            // 
            // groupBoxTipoDeFuncionario
            // 
            this.groupBoxTipoDeFuncionario.BackColor = System.Drawing.Color.Gray;
            this.groupBoxTipoDeFuncionario.Controls.Add(this.radioButtonDiretor);
            this.groupBoxTipoDeFuncionario.Controls.Add(this.radioButtonRecepcionista);
            this.groupBoxTipoDeFuncionario.ForeColor = System.Drawing.Color.White;
            this.groupBoxTipoDeFuncionario.Location = new System.Drawing.Point(22, 188);
            this.groupBoxTipoDeFuncionario.Name = "groupBoxTipoDeFuncionario";
            this.groupBoxTipoDeFuncionario.Size = new System.Drawing.Size(449, 160);
            this.groupBoxTipoDeFuncionario.TabIndex = 9;
            this.groupBoxTipoDeFuncionario.TabStop = false;
            this.groupBoxTipoDeFuncionario.Text = "Tipo de Funcionário";
            // 
            // radioButtonDiretor
            // 
            this.radioButtonDiretor.AutoSize = true;
            this.radioButtonDiretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDiretor.Location = new System.Drawing.Point(182, 39);
            this.radioButtonDiretor.Name = "radioButtonDiretor";
            this.radioButtonDiretor.Size = new System.Drawing.Size(63, 17);
            this.radioButtonDiretor.TabIndex = 3;
            this.radioButtonDiretor.TabStop = true;
            this.radioButtonDiretor.Text = "Diretor";
            this.radioButtonDiretor.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecepcionista
            // 
            this.radioButtonRecepcionista.AutoSize = true;
            this.radioButtonRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRecepcionista.Location = new System.Drawing.Point(17, 39);
            this.radioButtonRecepcionista.Name = "radioButtonRecepcionista";
            this.radioButtonRecepcionista.Size = new System.Drawing.Size(106, 17);
            this.radioButtonRecepcionista.TabIndex = 2;
            this.radioButtonRecepcionista.TabStop = true;
            this.radioButtonRecepcionista.Text = "Recepcionista";
            this.radioButtonRecepcionista.UseVisualStyleBackColor = true;
            // 
            // labelAnos
            // 
            this.labelAnos.AutoSize = true;
            this.labelAnos.Location = new System.Drawing.Point(290, 77);
            this.labelAnos.Name = "labelAnos";
            this.labelAnos.Size = new System.Drawing.Size(30, 13);
            this.labelAnos.TabIndex = 8;
            this.labelAnos.Text = "anos";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(103, 116);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(383, 20);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(242, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBoxNascimento
            // 
            this.textBoxNascimento.Location = new System.Drawing.Point(118, 73);
            this.textBoxNascimento.Name = "textBoxNascimento";
            this.textBoxNascimento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNascimento.TabIndex = 5;
            // 
            // textBoxSobreNome
            // 
            this.textBoxSobreNome.Location = new System.Drawing.Point(273, 32);
            this.textBoxSobreNome.Name = "textBoxSobreNome";
            this.textBoxSobreNome.Size = new System.Drawing.Size(213, 20);
            this.textBoxSobreNome.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(77, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(190, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(19, 117);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(78, 16);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNascimento.Location = new System.Drawing.Point(19, 74);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(93, 16);
            this.labelNascimento.TabIndex = 1;
            this.labelNascimento.Text = "Nascimento:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(19, 32);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(52, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // groupBoxControles
            // 
            this.groupBoxControles.BackColor = System.Drawing.Color.Gray;
            this.groupBoxControles.Controls.Add(this.buttonLimpar);
            this.groupBoxControles.Controls.Add(this.buttonSalvar);
            this.groupBoxControles.ForeColor = System.Drawing.Color.White;
            this.groupBoxControles.Location = new System.Drawing.Point(550, 239);
            this.groupBoxControles.Name = "groupBoxControles";
            this.groupBoxControles.Size = new System.Drawing.Size(228, 148);
            this.groupBoxControles.TabIndex = 1;
            this.groupBoxControles.TabStop = false;
            this.groupBoxControles.Text = "Controles";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(21, 84);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(192, 37);
            this.buttonLimpar.TabIndex = 1;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(21, 33);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(192, 36);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.Color.White;
            this.groupBoxStatus.Controls.Add(this.groupBoxStatusCadastroFuncionarios);
            this.groupBoxStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBoxStatus.Location = new System.Drawing.Point(550, 12);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(228, 221);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // groupBoxStatusCadastroFuncionarios
            // 
            this.groupBoxStatusCadastroFuncionarios.BackColor = System.Drawing.Color.Black;
            this.groupBoxStatusCadastroFuncionarios.Controls.Add(this.textBoxCadastroFuncionario);
            this.groupBoxStatusCadastroFuncionarios.ForeColor = System.Drawing.Color.White;
            this.groupBoxStatusCadastroFuncionarios.Location = new System.Drawing.Point(6, 19);
            this.groupBoxStatusCadastroFuncionarios.Name = "groupBoxStatusCadastroFuncionarios";
            this.groupBoxStatusCadastroFuncionarios.Size = new System.Drawing.Size(216, 196);
            this.groupBoxStatusCadastroFuncionarios.TabIndex = 0;
            this.groupBoxStatusCadastroFuncionarios.TabStop = false;
            this.groupBoxStatusCadastroFuncionarios.Text = "Cadastro de Funcionarios";
            // 
            // textBoxCadastroFuncionario
            // 
            this.textBoxCadastroFuncionario.BackColor = System.Drawing.Color.Black;
            this.textBoxCadastroFuncionario.Enabled = false;
            this.textBoxCadastroFuncionario.ForeColor = System.Drawing.Color.White;
            this.textBoxCadastroFuncionario.Location = new System.Drawing.Point(6, 19);
            this.textBoxCadastroFuncionario.Multiline = true;
            this.textBoxCadastroFuncionario.Name = "textBoxCadastroFuncionario";
            this.textBoxCadastroFuncionario.Size = new System.Drawing.Size(201, 171);
            this.textBoxCadastroFuncionario.TabIndex = 0;
            // 
            // FormAulaOOP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(804, 406);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxControles);
            this.Controls.Add(this.groupBoxCadastroDeFuncionario);
            this.Name = "FormAulaOOP1";
            this.Text = "Aula OOP 1 - Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCadastroDeFuncionario.ResumeLayout(false);
            this.groupBoxCadastroDeFuncionario.PerformLayout();
            this.groupBoxTipoDeFuncionario.ResumeLayout(false);
            this.groupBoxTipoDeFuncionario.PerformLayout();
            this.groupBoxControles.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatusCadastroFuncionarios.ResumeLayout(false);
            this.groupBoxStatusCadastroFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastroDeFuncionario;
        private System.Windows.Forms.GroupBox groupBoxControles;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBoxStatusCadastroFuncionarios;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox groupBoxTipoDeFuncionario;
        private System.Windows.Forms.Label labelAnos;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxNascimento;
        private System.Windows.Forms.TextBox textBoxSobreNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.RadioButton radioButtonDiretor;
        private System.Windows.Forms.RadioButton radioButtonRecepcionista;
        private System.Windows.Forms.TextBox textBoxCadastroFuncionario;
    }
}

