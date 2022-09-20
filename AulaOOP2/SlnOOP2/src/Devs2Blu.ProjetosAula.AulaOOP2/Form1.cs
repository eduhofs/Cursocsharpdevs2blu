using Devs2Blu.ProjetosAula.AulaOOP2Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        public Contato Contato { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        #region Eventos

        private void Form1_Load(object sender, EventArgs e)
        {
            Contato  = new Contato();
        }
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos!", "Erro - Formulário de contato",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            BindClass();

            String textoMsg = $"Contato {textBoxNome.Text} enviado com sucesso!";
            MessageBox.Show(this, textoMsg, "Formulário de contato");
           
            showDatas();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void textBoxCep_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCep.Text.Length == 8)
            {
                textBoxRua.Text = "Sete de Setembro";
                textBoxBairro.Text = "Centro";
                textBoxCidade.Text = "Blumenau";
                textBoxEstado.Text = "SC";
            }
            else
            {
                textBoxRua.Clear();
                textBoxBairro.Clear();
                textBoxCidade.Clear();
                textBoxEstado.Clear();
            }
        }

       
        #endregion

        #region Metodos
        public void BindClass()
        {
            Contato.Nome = textBoxNome.Text;
            Contato.TelCel = textBoxTelCel.Text;
            Contato.Email = textBoxEmail.Text;
            Contato.Cep = textBoxCep.Text;
            Contato.Rua = textBoxRua.Text;
            Int32.TryParse(textBoxNumero.Text, out Int32 numeroSTR);
            Contato.Numero = numeroSTR;
            Contato.Bairro = textBoxBairro.Text;
            Contato.Cidade = textBoxCidade.Text;
            Contato.Estado = textBoxEstado.Text;
        }

        private void LimpaForm()
        {
            textBoxNome.Clear();
            textBoxTelCel.Clear();
            textBoxEmail.Clear();
            textBoxCep.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxEstado.Clear();
        }

        public bool ValidaForm()
        {
            if (textBoxNome.Text.Equals("")) return false;
            if (textBoxTelCel.Text.Equals("")) return false;
            if (textBoxEmail.Text.Equals("")) return false;
            if (textBoxCep.Text.Equals("")) return false;
            if (textBoxRua.Text.Equals("")) return false;
            if (textBoxNumero.Text.Equals("")) return false;
            if (textBoxBairro.Text.Equals("")) return false;
            if (textBoxCidade.Text.Equals("")) return false;
            if (textBoxEstado.Text.Equals("")) return false;

            return true;
        }

        private void showDatas()
        {
            textBoxStatus.Text = $"{textBoxNome.Text}\r\n{textBoxTelCel.Text}\r\n{textBoxEmail.Text}\r\n" +
                $"{textBoxCep.Text}\r\n{textBoxRua.Text}\r\n{textBoxNumero.Text}\r\n{textBoxBairro.Text}\r\n{textBoxCidade.Text}\r\n" +
                $"{textBoxEstado.Text}\r\n";
        }


        #endregion

        
    }
}
