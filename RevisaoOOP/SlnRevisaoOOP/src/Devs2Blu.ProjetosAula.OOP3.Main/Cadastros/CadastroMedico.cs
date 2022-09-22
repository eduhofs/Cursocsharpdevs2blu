using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico
    {

        public CadastroMedico() { }

        public void MenuCadastro(Mocks mock)
        {
            Int32 opcao = 0;

            do
            {
                Console.WriteLine("----- Cadastro de Médico -----");
                Console.WriteLine("----- 1- Lista de Médico -----");
                Console.WriteLine("----- 2- Cadastro de Médico -----");
                Console.WriteLine("----- 3- Alterar Médico -----");
                Console.WriteLine("------ 0 - Sair ------\n");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarMedico();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarMedico();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirMedico();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }

        public void ListarMedicos()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine($"Médico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Cpf: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("----------------------------------------\n");

            }
        }
        public void CadastrarMedico()
        {

        }
        public void AlterarMedico()
        {

        }
        public void ExcluirMedico()
        {

        }
    }
}

