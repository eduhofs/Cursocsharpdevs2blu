using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula6Jogo21
{
    public partial class FormProjetoAulaDevs2BluJogo21 : Form
    {

        public int PontuacaoPlayer1 { get; set; } = 0;
        public int PontuacaoPlayer2 { get; set; } = 0;
        public int Jogada { get; set; } = 0;

        public FormProjetoAulaDevs2BluJogo21()
        {
            InitializeComponent();
        }
        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTabuleiro.Text = "Bem Vindo!\r\n";
            textBoxTabuleiro.Text += "Player1 aperte Iniciar para começar\r\n";
        }

        private void buttonTabuleiroIniciar_Click(object sender, EventArgs e)
        {
            textBoxPlayer1.Text += "Faça sua aposta de 1 á 20 e de um Ok\r\n";
        }

        private void buttonPlayer1Ok_Click(object sender, EventArgs e)
        {
            Player1Jogando();
        }

        private void buttonTabuleiroNovoJogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        #endregion

        #region Metodos

        private void NovoJogo()
        {
            textBoxTabuleiro.Text = "";
            textBoxPlayer1.Text = "";
            textBoxPlayer2.Text = "";

            PontuacaoPlayer1 = 0;
            PontuacaoPlayer2 = 0;
            Jogada = 0;

            textBoxTabuleiro.Text += "Player1 aperte Iniciar para começar\r\n";
            textBoxPlayer1.Text += "Faça sua aposta de 1 á 20 e de um Ok\r\n";
        }

        private void Player1Jogando()
        {
            int.TryParse(textBoxPlayer1Entrada.Text, out int numAposta);
            int pontuacaoPlayer1 = ChecandoPontuacao(numAposta);
            PontuacaoPlayer1 += pontuacaoPlayer1;

            textBoxPlayer1.Text += $"Vc fez {pontuacaoPlayer1.ToString()} pts.\r\n";
            textBoxTabuleiro.Text += $"Player1 tem {PontuacaoPlayer1.ToString()} pontos.\r\n";
            Jogada += 1;
            ChecandoRodada();
            Player2Jogando();
        }

        private void Player2Jogando()
        {
            Thread.Sleep(2000);
            int numAposta = GerarNumAleatorio();
            int pontuacaoPlayer2 = ChecandoPontuacao(numAposta);
            PontuacaoPlayer2 += pontuacaoPlayer2;

            textBoxPlayer2.Text += $"Vc fez {pontuacaoPlayer2.ToString()}pts.\r\n";
            textBoxTabuleiro.Text += $"Player2 tem {PontuacaoPlayer2.ToString()} pontos.\r\n";
            Jogada += 1;
            ChecandoRodada();
        }

        private int GerarNumAleatorio()
        {
            int numAleatorio;
            Random rd = new Random();
            numAleatorio = rd.Next(1, 20);
            return numAleatorio;
        }

        private int ChecandoPontuacao(int num)
        {
            int numAleatorio = GerarNumAleatorio();
            int resultado = num + numAleatorio;
            int pontuacao = 0;

            if (resultado >= 1 && resultado <= 7)
            {
                pontuacao = 1;
                if (resultado == 7)
                {
                    pontuacao += 9;
                }
            }
            else if (resultado >= 8 && resultado <= 13)
            {
                pontuacao = 5;
                if (resultado == 14)
                {
                    pontuacao += 15;
                }
            }
            else if (resultado >= 15 && resultado <= 20)
            {
                pontuacao = 6;
                if (resultado == 21)
                {
                    pontuacao += 24;
                }
            }
            return pontuacao;
        }

        private void ChecandoRodada()
        {
            if (Jogada == 0)
            {
                textBoxTabuleiro.Text += "Primeira Rodada\r\n";
            }
            else if (Jogada == 2)
            {
                textBoxTabuleiro.Text += "Segunda Rodada\r\n";
            }
            else if (Jogada == 4)
            {
                textBoxTabuleiro.Text += "Terceira Rodada\r\n";
            }
            else if (Jogada == 6)
            {
                textBoxTabuleiro.Text += "Fim do Jogo\r\n";
                FimDoJogo();
            }
        }

        private void FimDoJogo()
        {
            if (PontuacaoPlayer1 > PontuacaoPlayer2)
            {
                textBoxPlayer1.Text += "Vc Venceu!\r\n";
                textBoxTabuleiro.Text += "Player1 Venceu!\r\n";
            }
            else
            {
                textBoxPlayer2.Text += "Vc Venceu!\r\n";
                textBoxTabuleiro.Text += "Player2 Venceu!\r\n";
            }
        }


        #endregion
    }
}
