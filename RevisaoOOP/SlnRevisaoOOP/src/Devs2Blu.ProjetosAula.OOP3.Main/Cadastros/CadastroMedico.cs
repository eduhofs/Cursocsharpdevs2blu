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
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
    {

    }

        private void ListarMedico()
        {
            Console.Clear();

            foreach (var medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        private void CadastrarMedico(Medico novoMedico)
        {
            Program.Mock.ListaMedicos.Add(novoMedico);
        }

        private void AlterarMedico(Medico medico)
        {
            var med = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(med);
            Program.Mock.ListaMedicos[index] = medico;
        }

        private void ListarMedicosByCodeAndName()
        {
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.Write($"| {medico.CodigoMedico} - {medico.Nome} ");
            }
            Console.WriteLine("\n");
        }

        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Medicos -----");
            Console.WriteLine("----- 1- Lista de Medicos -----");
            Console.WriteLine("----- 2- Cadastro de Medicos -----");
            Console.WriteLine("----- 3- Alterar Medicos -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }

        public void Listar()
        {
            ListarMedico();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();

            Console.WriteLine("Informe o nome do Médico: ");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Médico: ");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o CRM do Médico: ");
            Int32.TryParse(Console.ReadLine(), out int crmStr);
            medico.CRM = crmStr;

            Console.WriteLine("Informe a Especialidade do Médico: ");
            medico.Especialidade = Console.ReadLine();

            Random rd = new Random();
            medico.Codigo = rd.Next(1, 100) + DateTime.Now.Second;
            medico.CodigoMedico = Int32.Parse($"{medico.Codigo}{rd.Next(100, 999)}");

            CadastrarMedico(medico);
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o Médico que Deseja Alterar:\n");
            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Paciente: {medico.Codigo}/{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | CRM: {medico.CRM} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 CRM | 04 - Especialidade | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo Convênio:");
                        Int32.TryParse(Console.ReadLine(), out int crmStr);
                        medico.CRM = crmStr;
                        break;
                    case "04":
                        Console.WriteLine("Informe uma nova Especialidade:");
                        medico.Especialidade = Console.ReadLine();
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
            Medico medico;

            int codigoMedico;
            ListarMedicosByCodeAndName();

            Console.WriteLine("Informe o Médico que Deseja Excluir:\n");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);


            if (Program.Mock.ListaMedicos.Remove(medico))
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