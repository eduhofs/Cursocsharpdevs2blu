using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
        }

        static void Exercicio1()
        {
            int a, b;
           

            Console.Write("Insira o primeiro valor: ");
            string aSTR =  Console.ReadLine();

            Int32.TryParse(aSTR, out a);

            Console.Write("Insira o segundo valor: ");
            string bSTR = Console.ReadLine();

            Int32.TryParse(bSTR, out b);    

            if (a > b)
            {
                Console.WriteLine($"O primeiro numero é maior -> {a}");
            }
            else if (b > a)
            {
                Console.WriteLine($"O primeiro numero é maior -> {b}");
            }
            else
            {
                Console.WriteLine("Os dois são iguais!");
            }
        }

        static void Exercicio2()
        {
            int a, b, c, d;

            Console.WriteLine("Programa que verifica o menor dentre quatro\n");

            Console.WriteLine("Digite o primeiro valor: ");
            string aSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out a);

            Console.WriteLine("Digite o segundo valor: ");
            string bSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out b);

            Console.WriteLine("Digite o terceiro valor: ");
            string cSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out c);

            Console.WriteLine("Digite o quarto valor: ");
            string dSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out d);

            if (a < b && a < c && a < d)
            {
                Console.WriteLine($"O primeiro valor {a} é menor");
            }
            else if (b < c && b < d)
            {
                Console.WriteLine($"O segundo valor {b} é menor");
            }
            else if (c < d)
            {
                Console.WriteLine($"O terceiro valor {c} é menor");
            }
            else
            {
                Console.WriteLine($"O quarto valor {d} é menor");
            }
        }

        static void Exercicio2e2()
        {
            int a, b, c, d;
            int menorValor = 999999999;

            Console.WriteLine("Programa que verifica o menor dentre quatro\n");

            Console.WriteLine("Digite o primeiro valor: ");
            string aSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out a);

            Console.WriteLine("Digite o segundo valor: ");
            string bSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out b);

            Console.WriteLine("Digite o terceiro valor: ");
            string cSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out c);

            Console.WriteLine("Digite o quarto valor: ");
            string dSTR = Console.ReadLine();
            Int32.TryParse(aSTR, out d);

            if (a < menorValor)
            {
                menorValor = a;
            }

            if (b < menorValor)
            {
                menorValor = b;
            }

            if (c < menorValor)
            {
                menorValor = c;
            }

            if (d < menorValor)
            {
                menorValor = d;
            }

            Console.WriteLine($"O menor valor é {menorValor}");

        }

        static void Exemplo1()
        {
            string textoSaida;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("ModaFoca Software");

            Console.WriteLine("Informe o nome do truta: ");
            nomeCandidato = Console.ReadLine();



            Console.WriteLine("Informe a idade do truta: ");
            string idadeSTR = Console.ReadLine();

            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para idade!");
                return;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeSTR);
            }



            Console.WriteLine("Informe a nota do truta: ");
            string notaSTR = Console.ReadLine();

            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para nota!");
                return;
            }
            else
            {
                notaCandidato = Int16.Parse(notaSTR);
            }

            textoSaida = $"Candidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idadeCandidato}";


            if (idadeCandidato < 18)
            {
                textoSaida += "(Menor de idade)\n";
            }
            else
            {
                textoSaida += "(Maior de idade)\n";
            }

            textoSaida += $"Nota Final: {notaCandidato}\n";

            if (notaCandidato > 5)
            {
                textoSaida += @"*******************
*** APROVADO!!! ***
*******************";
            }
            else
            {
                textoSaida += "| REPROVADO! :( / |";
            }

            Console.WriteLine(textoSaida);
            Console.ReadLine();

        }

        static void Exemplo4()
        {
            int num;

            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            


            
        }
    }
}
