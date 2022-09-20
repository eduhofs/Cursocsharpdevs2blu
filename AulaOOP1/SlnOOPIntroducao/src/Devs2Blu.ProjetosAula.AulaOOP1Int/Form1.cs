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

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxSobreNome.Text = "";
            textBoxNascimento.Text = "";
            textBoxEndereco.Text = "";
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
