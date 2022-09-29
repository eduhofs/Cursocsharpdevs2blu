using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
        }
        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i+2}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            String[] especialidade = { "Clínico", "Neurologista", "Ginicologista", "Pediatra"};
            for (int i = 0; i < 4; i++)
            {
                Medico medico = new Medico(i+33, $"Médico {i+rd.Next(0, 5)}", $"{i}35{i}65{i}198{i}", rd.Next(123456, 987987), especialidade[rd.Next(0, 3)]);
                ListaMedicos.Add(medico);
            }
            
        }

        public void CargaRecepcionistas()
        {
            Random rd = new Random();
            String[] setor = { "Ala Clínica", "Neurologia", "Ginicologia", "Pediatria" };
            for (int i = 0; i < 4; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i + 33, $"Recepcionista {i + rd.Next(0, 5)}", $"{i}35{i}65{i}198{i}", setor[rd.Next(0, 3)]);
                ListaRecepcionistas.Add(recepcionista);
            }

        }

    }
}
