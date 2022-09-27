using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public CadastroPaciente() { }

        public void MenuCadastro()
        {
            Int32 opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----- Cadastro de Pacientes -----");
                Console.WriteLine("----- 1- Lista de Pacientes -----");
                Console.WriteLine("----- 2- Cadastro de Pacientes -----");
                Console.WriteLine("----- 3- Alterar Pacientes -----");
                Console.WriteLine("------ 0 - Sair ------\n");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        MenuListarPacientes();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarPaciente();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarPaciente();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirPaciente();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
        #region Eventos
        public void MenuListarPacientes()
        {
            Int32 opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----- 11- Listar Todos-----");
                Console.WriteLine("----- 12- Listar Por Nome-----");
                Console.WriteLine("----- 13- Listar Por CPF-----");
                Console.WriteLine("------ 0 - Sair ------\n");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.TODOS:
                        ListarPacientes();
                        break;
                    case (int)MenuEnums.POR_NOME:
                        ListarPorNome();
                        break;
                    case (int)MenuEnums.POR_CPF:
                        ListarPorCPF();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
           
        }
        public void ListarPacientes()
        {
            Console.Clear();
            
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
               MostrarPaciente(paciente);
            }
            Console.ReadLine();
        }
        public void CadastrarPaciente()
        {
            Paciente paciente = new Paciente();
            Paciente pacienteSTR = Program.Mock.ListaPacientes.Last();
            paciente.CodigoPaciente = pacienteSTR.CodigoPaciente + 1;

            CapturarPaciente(paciente);
            Program.Mock.ListaPacientes.Add(paciente);

            Console.WriteLine("Paciente Cadastrado Com Sucesso!");
            Console.ReadLine();
        }
        public void AlterarPaciente()
        {
            Console.WriteLine("Informe o Código do Paciente: ");
            Int32.TryParse(Console.ReadLine(), out int codigoSearch);

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.CodigoPaciente.Equals(codigoSearch))
                {
                    Console.Clear();
                    MostrarPaciente(paciente);
                    Console.WriteLine("Deseja continuar: S/n");

                    string opcao = Console.ReadLine();
                    if (opcao.ToUpper().Equals("S"))
                    {
                        CapturarPaciente(paciente);

                        Console.WriteLine("Paciente Atualizado Com Sucesso!");
                        Console.ReadLine();
                    }
                    else if (opcao.ToUpper().Equals("N"))
                    {
                        Console.WriteLine("Operação Cancelada!");
                        Console.ReadLine();
                    }
                }
             
            }
            
        }
        public void ExcluirPaciente()
        {

        }

        #endregion

        #region Metodos

        public void MostrarPaciente(Paciente paciente)
        {
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
            Console.WriteLine($"Nome: {paciente.Nome}");
            Console.WriteLine($"Cpf: {paciente.CGCCPF}");
            Console.WriteLine($"Convenio: {paciente.Convenio}");
            Console.WriteLine("----------------------------------------\n");
        }

        public void CapturarPaciente(Paciente paciente)
        {
            Console.WriteLine("Informe o Nome do paciente: ");
            paciente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do paciente: ");
            paciente.CGCCPF = Console.ReadLine();
            Console.WriteLine("Informe o Plano de Saúde do paciente: ");
            paciente.Convenio = Console.ReadLine();
        }

        public void ListarPorNome()
        {
            Console.Clear();
            Console.WriteLine("Informe O Nome Do Paciete: ");
            string nomePaciente = Console.ReadLine();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.Nome.Contains(nomePaciente))
                {
                    MostrarPaciente(paciente);
                }
            }
            Console.ReadLine();
        }

        public void ListarPorCPF()
        {
            Console.Clear();
            Console.WriteLine("Informe O CPF Do Paciete: ");
            string cpfPaciente = Console.ReadLine();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                if (paciente.CGCCPF.Equals(cpfPaciente))
                {
                    MostrarPaciente(paciente);
                }
            }
            Console.ReadLine();
        }

        #endregion
    }
}
