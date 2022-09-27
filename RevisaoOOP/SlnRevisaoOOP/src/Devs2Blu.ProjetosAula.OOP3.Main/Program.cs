using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    public class Program
    {

        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            int opcao;
            Mock = new Mocks();
            do
            {
                Console.Clear();
                Console.WriteLine("----- Sistema de Gerenciamento de Clinícas -----");
                Console.WriteLine("----- 10-Cadastro de Pacientes -----");
                Console.WriteLine("----- 20-Cadastro de Médicos -----");
                Console.WriteLine("----- 30-Cadastro de Recepcionistas -----");
                Console.WriteLine("----- 40-Cadastro de Fornecedores -----");
                Console.WriteLine("----- 50-Agenda -----");
                Console.WriteLine("----- 60-Prontuário -----");
                Console.WriteLine("----- 70-Finaceiro -----");
                Console.WriteLine("---------------------------");
                Console.WriteLine("------ 0 - Sair ------\n");
                Int32.TryParse(Console.ReadLine(), out opcao);


                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        CadastroPaciente ModuloCadastroPacientes = new CadastroPaciente();
                        ModuloCadastroPacientes.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedico ModuloCadastroMedicos = new CadastroMedico();
                        ModuloCadastroMedicos.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionista ModuloCadastroRecepcionistas = new CadastroRecepcionista();
                        ModuloCadastroRecepcionistas.MenuCadastro();
                        break;

                    default:
                        break;
                }

            } while (!opcao.Equals((int)MenuEnums.SAIR));
            
        }

    }
}
