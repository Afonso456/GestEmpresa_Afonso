using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Afonso
{
    public class Analista : Empregado
    {
        public string projeto { get; set; }

    public Analista(string nome, DateTime data_nascimento, string email, string telefone, Morada morada, string projeto)
            : base(nome, data_nascimento, email, telefone, morada)
        {
            this.projeto = projeto;
        }
        public Analista(string nome): this(nome, new DateTime(), "", "", new Morada(), "Sem projeto")
        {
        }
        public Analista(): this("Sem nome")
        {
        }
    }
}

