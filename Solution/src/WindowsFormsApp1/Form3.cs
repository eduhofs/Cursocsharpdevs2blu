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
    public partial class FormQuestao4 : Form
    {
        public FormQuestao4()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string codigoProduto;

            codigoProduto = textBoxCodigo.Text;

            if (codigoProduto.Equals("001"))
            {
                MessageBox.Show("Produto escolhido foi Arroz");
            }
            else
            if (codigoProduto.Equals("002"))
            {
                MessageBox.Show("Produto escolhido foi Feijão");
            }
            else
            if (codigoProduto.Equals("003"))
            {
                MessageBox.Show("Produto escolhido foi Farinha");
            }
            else
            {
                MessageBox.Show("Produto Diverso.");
            }
        }
    }
}
