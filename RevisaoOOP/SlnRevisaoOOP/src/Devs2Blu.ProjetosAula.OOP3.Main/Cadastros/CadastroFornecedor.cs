using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }

        private void ListarFornecedor()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Cpf: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo de Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void CadastrarFornecedor(Fornecedor novoFornecedor)
        {
            Program.Mock.ListaFornecedores.Add(novoFornecedor);
        }
        private void AlterarFornecedor(Fornecedor fornecedor)
        {
            var forn = Program.Mock.ListaFornecedores.Find(f => f.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(forn);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }
        private void ExcluirFornecedor()
        {

        }
        private void ListarFornecedoresByCodeAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"| {fornecedor.CodigoFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }

        #region FACADE
        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o Fornecedor que Deseja Alterar:\n");
            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}/{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Setor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Tipo do Fornecedor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Tipo:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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

        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Informe o nome do Fornecedor: ");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Fornecedor: ");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Setor do Fornecedor: ");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.CodigoFornecedor = Int32.Parse($"{fornecedor.Codigo}{rd.Next(100, 999)}");

            CadastrarFornecedor(fornecedor);
        }

        public void Excluir()
        {
            Console.Clear();
            Fornecedor fornecedor;

            int codigoFornecedor;
            ListarFornecedoresByCodeAndName();

            Console.WriteLine("Informe o Fornecedor que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);


            if (Program.Mock.ListaFornecedores.Remove(fornecedor))
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

        public void Listar()
        {
            ListarFornecedor();
        }

        public Int32 MenuCadastro()
        {
            Int32 opcao = 0;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Fornecedores -----");
            Console.WriteLine("----- 1- Lista de Fornecedores -----");
            Console.WriteLine("----- 2- Cadastro de Fornecedores -----");
            Console.WriteLine("----- 3- Alterar Fornecedores -----");
            Console.WriteLine("------ 0 - Sair ------\n");
            Int32.TryParse(Console.ReadLine(), out opcao);

            return opcao;
        }

        #endregion
    }
}
