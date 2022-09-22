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

        public void MenuCadastro(Mocks mock)
        {
            Int32 opcao = 0;

            do
            {
                Console.WriteLine("----- Cadastro de Pacientes -----");
                Console.WriteLine("----- 1- Lista de Pacientes -----");
                Console.WriteLine("----- 2- Cadastro de Pacientes -----");
                Console.WriteLine("----- 3- Alterar Pacientes -----");
                Console.WriteLine("------ 0 - Sair ------\n");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
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

        public void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"Cpf: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("----------------------------------------\n");

            }
        }
        public void CadastrarPaciente()
        {

        }
        public void AlterarPaciente()
        {

        }
        public void ExcluirPaciente()
        {

        }
    }
}
