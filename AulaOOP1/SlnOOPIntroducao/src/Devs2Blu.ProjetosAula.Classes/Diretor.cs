using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Diretor : Pessoa
    {
        public double Prolabore { get; set; }

        public Diretor() { }

        public Diretor(string nome, string sobreNome, double prolabore)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Prolabore = prolabore;

        }

        public string VerificaStatus()
        {
            return "Hospital Ok";
        }
    }
}
