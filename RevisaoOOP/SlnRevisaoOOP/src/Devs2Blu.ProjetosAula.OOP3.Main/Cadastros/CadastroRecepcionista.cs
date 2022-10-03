using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {
            
        }

        public void ListarRecepcionistas()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"Cpf: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("----------------------------------------\n");
            }
            Console.ReadLine();
        }
        public void CadastrarRecepcionistas(Recepcionista novoRecepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(novoRecepcionista);
        }
        public void AlterarRecepcionistas(Recepcionista recepcionista)
        {
            var rec = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(rec);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }
        public void ExcluirRecepcionistas()
        {

        }

        private void ListarRecepcionistasByCodeAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.Write($"| {recepcionista.CodigoRecepcionista} - {recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Recepcionistas -----");
            Console.WriteLine("----- 1- Lista de Recepcionistas -----");
            Console.WriteLine("----- 2- Cadastro de Recepcionistas -----");
            Console.WriteLine("----- 3- Alterar Recepcionistas -----");
            Console.WriteLine("------ 0 - Sair ------\n");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        public void Listar()
        {
            ListarRecepcionistas(); 
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();

            Console.WriteLine("Informe o nome do Recepcionista: ");
            recepcionista.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Recepcionista: ");
            recepcionista.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Setor do Recepcionista: ");
            recepcionista.Setor = Console.ReadLine();

            Random rd = new Random();
            recepcionista.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.CodigoRecepcionista = Int32.Parse($"{recepcionista.Codigo}{rd.Next(100, 999)}");

            CadastrarRecepcionistas(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe o Recepcionistas que Deseja Alterar:\n");
            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Paciente: {recepcionista.Codigo}/{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Setor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Convênio:");
                        recepcionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                }
            } while (alterar);
        }

        public void Excluir()
        {
            Console.Clear();
            Recepcionista recepcionista;

            int codigoRecepcionista;
            ListarRecepcionistasByCodeAndName();

            Console.WriteLine("Informe o Recepcionista que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);


            if (Program.Mock.ListaRecepcionistas.Remove(recepcionista))
            {
                Console.Clear();
                Console.WriteLine("Dado Excluido com Sucesso!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dado Não Excluido!");
                Console.ReadLine();
            }
        }

        #endregion
    }
}
