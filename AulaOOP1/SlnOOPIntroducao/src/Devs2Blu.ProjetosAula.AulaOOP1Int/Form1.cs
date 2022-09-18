using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AulaOOP1Int
{
    public partial class FormAulaOOP1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorList { get; set; }
        public FormAulaOOP1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretorList = new List<Diretor>();  
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButtonDiretor.Checked)
            {
                textBoxCadastroFuncionario.Text += "Tipo = Diretor\r\n";
                textBoxCadastroFuncionario.Text += $"Nome = {textBoxNome.Text} {textBoxSobreNome.Text}\r\n";
                textBoxCadastroFuncionario.Text += $"Nascido = {textBoxNascimento.Text}\r\n";
                textBoxCadastroFuncionario.Text += $"Endereço = {textBoxEndereco.Text}\r\n";
            }
            else if (radioButtonRecepcionista.Checked)
            {
                textBoxCadastroFuncionario.Text += "Tipo = Recepcionista\r\n";
                textBoxCadastroFuncionario.Text += $"Nome = {textBoxNome.Text} {textBoxSobreNome.Text}\r\n";
                textBoxCadastroFuncionario.Text += $"Nascido = {textBoxNascimento.Text}\r\n";
                textBoxCadastroFuncionario.Text += $"Endereço = {textBoxEndereco.Text}\r\n";
            }
           
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxSobreNome.Text = "";
            textBoxNascimento.Text = "";
            textBoxEndereco.Text = "";
            radioButtonPessoa.Checked = false;
            radioButtonDiretor.Checked = false;
            radioButtonRecepcionista.Checked = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
           if (radioButtonDiretor.Checked)
            {
                Diretor diretor = new Diretor();
                diretor.Nome = textBoxNome.Text;
                diretor.SobreNome = textBoxSobreNome.Text;
                DateTime dataDeNascimento;
                DateTime.TryParse(textBoxNascimento.Text, out dataDeNascimento);
                diretor.DataDeNascimento = dataDeNascimento;
                diretor.Endereco = textBoxEndereco.Text;
                DiretorList.Add(diretor);
            }
            else if (radioButtonRecepcionista.Checked)
            {
                Recepcionista recepcionista = new Recepcionista();
                recepcionista.Nome = textBoxNome.Text;
                recepcionista.SobreNome = textBoxSobreNome.Text;
                DateTime dataDeNascimento;
                DateTime.TryParse(textBoxNascimento.Text, out dataDeNascimento);
                recepcionista.DataDeNascimento = dataDeNascimento;
                recepcionista.Endereco = textBoxEndereco.Text;
                RecepcionistasList.Add(recepcionista);
            }
        }
    }
}
