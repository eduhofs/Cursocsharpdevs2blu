using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio7();

        }
      
        static void Exercicio6()
        {
            Console.Clear();
            const string SENHA = "1234";

            Console.Write("Digite sua senha: ");
            string usuarioSenha = Console.ReadLine();

            Console.WriteLine((usuarioSenha.Equals(SENHA)) ? "Acesso Permitido" : "Acesso negado");
            Console.ReadLine();
        }
        static void Exercicio5()
        {
            int anoDeNascimento;
            string permicao;

            Console.WriteLine("Digite o ano que você nasceu: ");
            string anoSTR = Console.ReadLine();
            Int32.TryParse(anoSTR, out anoDeNascimento);

            permicao = (DateTime.Now.Year - anoDeNascimento > 16) ? "pode" : "não pode";

            Console.WriteLine($"Você {permicao} votar");

            Console.ReadLine();

        }

        static void Exercicio3()
        {
            int n;

            Random r = new Random();    
            n = r.Next();

            if (n - n / 2 * 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
            
        }

        static void Exercicio4()
        {
            int prod;

            Console.WriteLine("Digite o codigo do produto desejado: ");

            prod = Int32.Parse(Console.ReadLine());

            if (prod == 001)
            {
                Console.WriteLine("Arroz");
            }
            else if (prod == 002)
            {
                Console.WriteLine("Feijão");
            }
            else if (prod == 003)
            {
                Console.WriteLine("Farrinha");
            }
            else
            {
                Console.WriteLine("Diversos");
            }
        }

        static void Exercicio4Resolucao()
        {
            string codigoProduto;
            Console.WriteLine("Escolha um produto");
            Console.WriteLine("001 - Arroz");
            Console.WriteLine("002 - Feijão");
            Console.WriteLine("003 - Farinha");

            codigoProduto = Console.ReadLine();

            if(codigoProduto == "001")
            {
                Console.WriteLine("Produto escolhido foi Arroz");
            }
            else if (codigoProduto == "002")
            {
                Console.WriteLine("Produto escolhido foi Feijão");
            }
            else if (codigoProduto == "003")
            {
                Console.WriteLine("Produto escolhido foi Farinha");
            }
            else
            {
                Console.WriteLine("Diversos");
            }
        }

        static void Exercicio7()
        {
            int qtdLados;
            double mddLado;
            double areaPoligono;

            Console.Write("Informe a quantidade de lados: ");
            qtdLados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a medida dos lados: ");
            mddLado = Convert.ToDouble(Console.ReadLine());

            if (qtdLados.Equals(3))
            {
                Console.Write("Informe a altura do Triângulo: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                areaPoligono = (alturaTriangulo * mddLado) /2;
                Console.WriteLine($"TRIÂNGULO com area de {String.Format("{0:#.#,##}", areaPoligono)}cm");
            }
            else if(qtdLados.Equals(4))
            {
                Console.WriteLine($"QUADRADO com area de {String.Format("{0:#.#,##}", mddLado * 2)}cm");
            }
            else if (qtdLados.Equals(5))
            {

            }
            else if (qtdLados < 3)
            {
                Console.WriteLine("NÃO É UM POLÍGONO.");
            }
            else if (qtdLados > 5)
            {
                Console.WriteLine("POLÍGONO NÃO IDENTIFICADO.");
            }
            Console.ReadLine();

        }
    }
}
