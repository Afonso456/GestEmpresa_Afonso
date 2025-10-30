using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Afonso
{
    public class Programador:Empregado
    {
        public string especialidade { get; set; }

    public Programador(string nome, DateTime data_nascimento, string email, string telefone, Morada morada, string especialidade)
            :base(nome, data_nascimento, email, telefone, morada)
        {
            this.especialidade = especialidade;
        }
    public Programador(string nome):this(nome, new DateTime(), "", "", new Morada(), "Sem especialidade")
        {
        }
        public Programador(): this("Sem nome")
        {
        }
    }
}
