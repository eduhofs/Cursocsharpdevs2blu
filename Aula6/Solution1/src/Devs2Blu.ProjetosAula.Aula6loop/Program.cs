using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula6loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;

            do
            {
              
                Console.WriteLine("Informe um dos códigos abaixo");
                Console.WriteLine("1 Exemplo1");
                Console.WriteLine("2 Exemplo2");
                Console.WriteLine("3 Exercício1");
                Console.WriteLine("4 Exercício2");
                Console.WriteLine("5 Exercício3");
                Console.WriteLine("6 Exercício4");
                Console.WriteLine("7 Exercício5");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case    1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break; 
                    case 3:
                        Exercicio1();
                        break; 
                    case 4:
                        Exercicio2();
                        break;
                    case 5:
                        Exercicio3();
                        break;
                    case 6:
                        Exercicio4();
                        break;
                    case 7:
                        Exercicio6();
                        break;
                    default:
                        break;

                }
            }while (controle > 0) ;
        }


        static void Exemplo1()
        {
            int controle = 1;
            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            } 
        }

        static void Exemplo2()
        {
            Console.WriteLine("Exemplo 2");
        }

        static void Exercicio1()
        {
            int num = 0;
            while (num <= 100)
            {
                if (num - num / 2 * 2 == 0)
                {
                    Console.Write(num + ", ");
                }
                num++;
            }
            Console.WriteLine("\n");
        }

        static void Exercicio2()
        {
            int num = 0;
            while (num <= 100)
            {
                if (!(num - num / 2 * 2 == 0))
                {
                    Console.Write(num + ", ");
                }
                num++;
            }
            Console.WriteLine("\n");
        }

        static void Exercicio3()
        {
            int numA = 1;
            int numB; 

            Console.Write("Informe um valor: ");
            Int32.TryParse(Console.ReadLine(), out numB);

            while (numA <= numB)
            {
                if (numA - numA / 2 * 2 == 0)
                {
                    Console.Write(numA + ", ");
                }
                else
                {

                }
                numA++;
            }

            Console.WriteLine("\n");

            numA = 1;
            while (numA <= numB)
            {
                if (!(numA - numA / 2 * 2 == 0))
                {
                    Console.Write(numA + ", ");
                }
                numA++;
            }
            Console.WriteLine("\n");


        }
        static void Exercicio4()
        {
            int alunos;
            int contador;
            double nota;
            double media =0;

            Console.WriteLine("Quantos alunos tem na sua sala?");
            Int32.TryParse(Console.ReadLine(), out alunos);

            contador = alunos;
            int i = 1;
            while (contador > 0)
            {
                Console.Write($"Digite a nota do {i}° aluno: ");
                double.TryParse(Console.ReadLine(), out nota);
                
                media += nota;
                contador--;
                i++;

            }
            Console.WriteLine($"A média da sala é {media / alunos}");

        }

        static void Exercicio6()
        {
            int num = 1000; 

            Console.WriteLine("Os números de 1000 até 1999 que se divididos por 11 tem o resto de 5 são ");

            while (num < 2000)
            {
                if (num % 11 == 5)
                {
                    Console.Write($"{num}, ");
                }
                num++;
            }
            Console.WriteLine("\n");
        }
    }
}
