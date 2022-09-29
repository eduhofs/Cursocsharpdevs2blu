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
    public partial class ProgramaLocao : Form
    {
        public ProgramaLocao()
        {
            InitializeComponent();
        }

        private void buttonExemplo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este Programa Gerar Dois Números Aleatórios De 1 A 100 E Mostra O Maior Deles");

            int numero1, numero2;

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);

            MessageBox.Show($"Número 1 = {numero1}.");
            MessageBox.Show($"Número 2 = {numero2}.");

            if (numero1 < numero2)
            {
                MessageBox.Show($"Número Um é o maior. Número Um = {numero1}");
            }
            else if (numero2 < numero1)
            {
                MessageBox.Show($"Número Dois é o maior. Número Dois = {numero2}");
            }
            else
            {
                MessageBox.Show($"Os números são iguais! Números = {numero1} e {numero2}");
            }
            
        }

        private void buttonExemplo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa gera três números aleatórios e os exibe em ordem crescente");

            int numero1, numero2, numero3;
            string formataSaida = "";

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);
            numero3 = rd.Next(1, 100);

            if (numero1 < numero2 &&
                numero1 < numero3)
            {
                formataSaida += $"{numero1}, ";
                if (numero2 < numero3)
                {
                    formataSaida += $"{numero2}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero2}";
                }
            }
            else if (numero2 < numero1 &&
                   numero2 < numero3)
            {
                formataSaida += $"{numero2}, ";
                if (numero1 < numero3)
                {
                    formataSaida += $"{numero1}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero1}";
                }
            }
            else
            {
                formataSaida += $"{numero3}, ";
                if (numero1 < numero2)
                {
                    formataSaida += $"{numero1}, {numero2}";
                }
                else
                {
                    formataSaida += $"{numero2}, {numero1}";
                }
            }

            MessageBox.Show($"Ordem crescente: {formataSaida}");
        }

        private void buttonQuestao3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa gera um número e mostra se é par ou impar");

            int numero;
            Random rd = new Random();

            numero = rd.Next(1, 100);

            if (!(numero - numero / 2 * 2 == 0))
            {
                MessageBox.Show($"O Número Gerado {numero} é ÍMPAR!");
            }
            else
            {
                MessageBox.Show($"O Número Gerado {numero} é PAR!");
            }

        }

        private void buttonExemplo3_Click(object sender, EventArgs e)
        {
            Exemplo3 tela = new Exemplo3();
            tela.Show();
        }

        private void buttonExemplo4_Click(object sender, EventArgs e)
        {
            int idade, tempoTrabalho;

            Random rd = new Random();

            idade = rd.Next(50, 80);
            tempoTrabalho = rd.Next(15, 40);

            MessageBox.Show($"Idade: {idade}");
            MessageBox.Show($"Tempo de Trabalho: {tempoTrabalho}");

            if ((idade == 65) ||
                (tempoTrabalho > 25))
            {
                MessageBox.Show("Pessoa pode se aposentar!");
            }
            else
            {
                MessageBox.Show("Lamentamos, mas ainda não pode se aposentar.");
            }
        }

        private void buttonQuestao4_Click(object sender, EventArgs e)
        {
            FormQuestao4 tela = new FormQuestao4();
            tela.Show();
        }

        private void buttonQuestao5_Click(object sender, EventArgs e)
        {
            int idade, anoNascimento;
            Random rd = new Random();

            anoNascimento = rd.Next(1900, 2022);
            MessageBox.Show($"A ano gerado foi -> {anoNascimento}");

            idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 16)
            {
                MessageBox.Show("Pode Votar!");
            }
            else
            {
                MessageBox.Show("Não pode votar!");
            }
        }

        private void buttonQuestao6_Click(object sender, EventArgs e)
        {
            Questao6 tela = new Questao6();
            tela.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
