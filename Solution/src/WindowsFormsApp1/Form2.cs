using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Exemplo3 : Form
    {
        public Exemplo3()
        {
            InitializeComponent();
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            int idade;
            bool permissao;
            string nome;

            nome = textBoxNome.Text;

            string inputIdade = textBoxIdade.Text; 
            Int32.TryParse(inputIdade, out idade);

            permissao = (idade >= 18) ? true : false;

           
            if (permissao)
            {
                MessageBox.Show($"Seja bem-vindo(a), {nome}! (+18)");
            }
            else
            {
                MessageBox.Show("Você não pode entrar. Idade menor de 18 anos.");
            }
        }
    }
}
