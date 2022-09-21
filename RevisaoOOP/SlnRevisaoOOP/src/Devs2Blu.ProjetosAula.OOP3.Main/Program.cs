﻿using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
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
            Mock = new Mocks();
            ViewListPacientes();
        }

        public static void ViewListPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Mock.ListaPacientes)
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"Cpf: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("----------------------------------------\n");
            }
            Console.ReadLine();

        }
    }
}