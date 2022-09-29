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
    public partial class Questao6 : Form
    {
        public Questao6()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            const string SENHA_SISTEMA = "1234";
            const string MSG_ACESSO_PERM = "Acesso Concedido!";
            const string MSG_ACESSO_NEG = "Acesso Negado!";
            string senhaUsuario;

            senhaUsuario = textBoxSenha.Text;

            if (senhaUsuario.Equals(SENHA_SISTEMA))
            {
                MessageBox.Show(MSG_ACESSO_PERM);
            }
            else
            {
                MessageBox.Show(MSG_ACESSO_NEG);
            }
        }
    }
}
