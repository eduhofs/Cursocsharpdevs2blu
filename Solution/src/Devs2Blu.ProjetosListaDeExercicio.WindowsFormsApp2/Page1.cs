using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosListaDeExercicio.WindowsFormsApp2
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void textBoxNumeroDeMacas_Click(object sender, EventArgs e)
        {
            textBoxNumeroDeMacas.Text = "";
        }

        private void labelExercicio4_Click(object sender, EventArgs e)
        {
            textBoxNumeroDeMacas.Visible = true;
            buttonCalcular.Visible = true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int qtdMaca;
            double valorUnidadeMaca;
            double valorDaCompra;

            string qtdMacaSTR = textBoxNumeroDeMacas.Text;
            Int32.TryParse(qtdMacaSTR, out qtdMaca);

            valorUnidadeMaca = (qtdMaca < 11) ? 0.30 : 0.25;

            valorDaCompra = qtdMaca * valorUnidadeMaca;

            labelPreco.Visible = true;
            labelPreco.Text = valorDaCompra.ToString();
        }

        private void labelExercicio6_Click(object sender, EventArgs e)
        {
            comboBoxSexo.Visible = true;
            textBoxAltura.Visible = true;
            buttonChecar.Visible = true;
            labelPesoIdeal.Visible = true;
        }

        private void buttonChecar_Click(object sender, EventArgs e)
        {
            string sexo;
            double altura;
            double pesoIdeal;

            sexo = comboBoxSexo.Text;
            string alturaSTR = textBoxAltura.Text;
            double.TryParse(alturaSTR, out altura);

            if(sexo.Equals("Masculino"))
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }

            labelPesoIdeal.Text = $"{String.Format("{0:#.#,##}", pesoIdeal.ToString())}Kg";
        }

        private void labelPesoIdeal_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAltura_Click(object sender, EventArgs e)
        {
            textBoxAltura.Text = "";
        }

        private void labelExercicio7_Click(object sender, EventArgs e)
        {
            comboBoxLados.Visible = true;
            textBoxMedida.Visible = true;
            buttonCalcularPoligono.Visible = true;
            labelResultadoPoligono.Visible = true;
        }

        private void textBoxMedida_Click(object sender, EventArgs e)
        {
            textBoxMedida.Text = "";
        }

        private void buttonCalcularPoligono_Click(object sender, EventArgs e)
        {
            labelResultadoPoligono.Text = "";
            
            string qtdLado = comboBoxLados.Text;
            double medidaLado = Convert.ToDouble(textBoxMedida.Text);

            if (qtdLado.Equals("3 Lados"))
            {

            }
            else if (qtdLado.Equals("4 Lados"))
            {
                Console.WriteLine($"QUADRADO com area de{String.Format("{0:#.#,##}", medidaLado * 2)}cm");
            }
            else if (qtdLado.Equals("5 Lados"))
            {

            }
          
            
        }
    }
}
