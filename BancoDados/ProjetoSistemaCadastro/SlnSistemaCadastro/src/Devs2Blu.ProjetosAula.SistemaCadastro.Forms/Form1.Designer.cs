
namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    partial class Form1
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
            this.groupBoxFormularioDeCadastro = new System.Windows.Forms.GroupBox();
            this.labelConvenio = new System.Windows.Forms.Label();
            this.comboBoxConvenio = new System.Windows.Forms.ComboBox();
            this.radioButtonTipoPessoaFisica = new System.Windows.Forms.RadioButton();
            this.radioButtonTipoPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.labelTipoPessoa = new System.Windows.Forms.Label();
            this.groupBoxTipoPessoa = new System.Windows.Forms.GroupBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCGCCPF = new System.Windows.Forms.Label();
            this.groupBoxFormularioDeCadastro.SuspendLayout();
            this.groupBoxTipoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormularioDeCadastro
            // 
            this.groupBoxFormularioDeCadastro.Controls.Add(this.labelCGCCPF);
            this.groupBoxFormularioDeCadastro.Controls.Add(this.labelNome);
            this.groupBoxFormularioDeCadastro.Controls.Add(this.groupBoxTipoPessoa);
            this.groupBoxFormularioDeCadastro.Controls.Add(this.labelTipoPessoa);
            this.groupBoxFormularioDeCadastro.Controls.Add(this.labelConvenio);
            this.groupBoxFormularioDeCadastro.Controls.Add(this.comboBoxConvenio);
            this.groupBoxFormularioDeCadastro.Location = new System.Drawing.Point(23, 23);
            this.groupBoxFormularioDeCadastro.Name = "groupBoxFormularioDeCadastro";
            this.groupBoxFormularioDeCadastro.Size = new System.Drawing.Size(423, 476);
            this.groupBoxFormularioDeCadastro.TabIndex = 2;
            this.groupBoxFormularioDeCadastro.TabStop = false;
            this.groupBoxFormularioDeCadastro.Text = "Formulário de Cadastro";
            // 
            // labelConvenio
            // 
            this.labelConvenio.AutoSize = true;
            this.labelConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvenio.Location = new System.Drawing.Point(23, 36);
            this.labelConvenio.Name = "labelConvenio";
            this.labelConvenio.Size = new System.Drawing.Size(83, 20);
            this.labelConvenio.TabIndex = 3;
            this.labelConvenio.Text = "Convênio";
            // 
            // comboBoxConvenio
            // 
            this.comboBoxConvenio.FormattingEnabled = true;
            this.comboBoxConvenio.Location = new System.Drawing.Point(124, 35);
            this.comboBoxConvenio.Name = "comboBoxConvenio";
            this.comboBoxConvenio.Size = new System.Drawing.Size(247, 21);
            this.comboBoxConvenio.TabIndex = 2;
            // 
            // radioButtonTipoPessoaFisica
            // 
            this.radioButtonTipoPessoaFisica.AutoSize = true;
            this.radioButtonTipoPessoaFisica.Location = new System.Drawing.Point(27, 19);
            this.radioButtonTipoPessoaFisica.Name = "radioButtonTipoPessoaFisica";
            this.radioButtonTipoPessoaFisica.Size = new System.Drawing.Size(54, 17);
            this.radioButtonTipoPessoaFisica.TabIndex = 4;
            this.radioButtonTipoPessoaFisica.TabStop = true;
            this.radioButtonTipoPessoaFisica.Text = "Física";
            this.radioButtonTipoPessoaFisica.UseVisualStyleBackColor = true;
            this.radioButtonTipoPessoaFisica.CheckedChanged += new System.EventHandler(this.radioButtonTipoPessoaFisica_CheckedChanged);
            // 
            // radioButtonTipoPessoaJuridica
            // 
            this.radioButtonTipoPessoaJuridica.AutoSize = true;
            this.radioButtonTipoPessoaJuridica.Location = new System.Drawing.Point(138, 19);
            this.radioButtonTipoPessoaJuridica.Name = "radioButtonTipoPessoaJuridica";
            this.radioButtonTipoPessoaJuridica.Size = new System.Drawing.Size(63, 17);
            this.radioButtonTipoPessoaJuridica.TabIndex = 5;
            this.radioButtonTipoPessoaJuridica.TabStop = true;
            this.radioButtonTipoPessoaJuridica.Text = "Jurídica";
            this.radioButtonTipoPessoaJuridica.UseVisualStyleBackColor = true;
            this.radioButtonTipoPessoaJuridica.CheckedChanged += new System.EventHandler(this.radioButtonTipoPessoaJuridica_CheckedChanged);
            // 
            // labelTipoPessoa
            // 
            this.labelTipoPessoa.AutoSize = true;
            this.labelTipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoPessoa.Location = new System.Drawing.Point(11, 89);
            this.labelTipoPessoa.Name = "labelTipoPessoa";
            this.labelTipoPessoa.Size = new System.Drawing.Size(107, 20);
            this.labelTipoPessoa.TabIndex = 6;
            this.labelTipoPessoa.Text = "Tipo Pessoa";
            // 
            // groupBoxTipoPessoa
            // 
            this.groupBoxTipoPessoa.Controls.Add(this.radioButtonTipoPessoaFisica);
            this.groupBoxTipoPessoa.Controls.Add(this.radioButtonTipoPessoaJuridica);
            this.groupBoxTipoPessoa.Location = new System.Drawing.Point(124, 73);
            this.groupBoxTipoPessoa.Name = "groupBoxTipoPessoa";
            this.groupBoxTipoPessoa.Size = new System.Drawing.Size(247, 46);
            this.groupBoxTipoPessoa.TabIndex = 7;
            this.groupBoxTipoPessoa.TabStop = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(27, 135);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            // 
            // labelCGCCPF
            // 
            this.labelCGCCPF.AutoSize = true;
            this.labelCGCCPF.Location = new System.Drawing.Point(30, 165);
            this.labelCGCCPF.Name = "labelCGCCPF";
            this.labelCGCCPF.Size = new System.Drawing.Size(49, 13);
            this.labelCGCCPF.TabIndex = 9;
            this.labelCGCCPF.Text = "CGCCPF";
            this.labelCGCCPF.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.groupBoxFormularioDeCadastro);
            this.Name = "Form1";
            this.Text = "+Devs2Blu - Sistema Cadastro Hospitalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFormularioDeCadastro.ResumeLayout(false);
            this.groupBoxFormularioDeCadastro.PerformLayout();
            this.groupBoxTipoPessoa.ResumeLayout(false);
            this.groupBoxTipoPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormularioDeCadastro;
        private System.Windows.Forms.Label labelConvenio;
        private System.Windows.Forms.ComboBox comboBoxConvenio;
        private System.Windows.Forms.RadioButton radioButtonTipoPessoaFisica;
        private System.Windows.Forms.RadioButton radioButtonTipoPessoaJuridica;
        private System.Windows.Forms.Label labelTipoPessoa;
        private System.Windows.Forms.GroupBox groupBoxTipoPessoa;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCGCCPF;
    }
}

