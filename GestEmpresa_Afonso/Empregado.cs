using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Afonso
{
    public class Empregado
    {
        private static int AutoID { get; set; }
        protected int ID { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public Morada morada_atual { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        protected Empregado(string nome, DateTime data_nascimento, string email, string telefone, Morada morada)
        {
            ID = ++AutoID;
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.morada_atual = morada_atual;
            this.email = email;
            this.telefone = telefone;
        }
        public Empregado(string nome): this(nome, new DateTime(),"","",new Morada())
        {

        }
        public Empregado(): this("Sem nome")
        {

        }

    }
}
