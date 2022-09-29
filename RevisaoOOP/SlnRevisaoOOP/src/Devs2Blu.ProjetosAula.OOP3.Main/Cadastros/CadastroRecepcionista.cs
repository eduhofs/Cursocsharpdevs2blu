using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista
    {
        public void MenuCadastro()
        {
            Int32 opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----- Cadastro de Recepcionistas -----");
                Console.WriteLine("----- 1- Lista de Recepcionistas -----");
                Console.WriteLine("----- 2- Cadastro de Recepcionistas -----");
                Console.WriteLine("----- 3- Alterar Recepcionistas -----");
                Console.WriteLine("------ 0 - Sair ------\n");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionistas();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarRecepcionistas();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarRecepcionistas();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirRecepcionistas();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
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
        public void CadastrarRecepcionistas()
        {

        }
        public void AlterarRecepcionistas()
        {

        }
        public void ExcluirRecepcionistas()
        {

        }
    }
}
