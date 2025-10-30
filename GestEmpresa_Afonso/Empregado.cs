using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestEmpresa_Afonso
{
    public class Empregado
    {
        //Pretendemos uma numeração automatica no id do empregado
        //inicialmente é atribuido o valor zero
        //apenas o empregado tem acesso
        private static int AutoID { get; set; }

        //ID do empregado
        //protected: APENAS o programador e o analista tem acesso
        protected int ID { get; set; }

        //Campos da DataGridView
        //propriedades do empregado que vão surgir no datagridview

        /// <summary>
        /// 1º campo: ID Indetica o empregado a lista - valor unico
        /// </summary>
        public int ValorID
        {
            get { return ID; }
        }

        /// <summary>
        /// 2ºcampo: Nome Abreviado
        /// </summary>
        public string NomeAbreviado
        {
            get { return GetNomeAbreviado(nome); }
        }

        /// <summary>
        /// 3º campo: Localidade
        /// </summary>
        public string localidade
        {
            get { return morada_atual.Localidade; }
        }

        /// <summary>
        /// 4º campo: Cargo
        /// </summary>
        public string cargo
        {
            get { return GetCargo(); }
        }

        //Propriedades
        private string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public Morada morada_atual { get; set; }
        private string email { get; set; }
        private string telefone { get; set; }

        /// <summary>
        /// Construtor para criar um empregado com todas as propriedades do ojeto
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="data_nascimento"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="morada"></param>
        protected Empregado(string nome, DateTime data_nascimento, string email, string telefone, Morada morada)
        {
            ID = ++AutoID;
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.morada_atual = morada_atual;
            this.email = email;
            this.telefone = telefone;
        }

        /// <summary>
        /// Construtor para criar um empregado com apenas o nome 
        /// </summary>
        /// <param name="nome">Nome do empregado</param>
        public Empregado(string nome): this(nome, new DateTime(),"","",new Morada())
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public Empregado(): this("Sem nome")
        {

        }

        /// <summary>
        /// Devolve o nome com o formato APELIDO: Nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static string GetNomeAbreviado(string nome)
        {
            string nome_abreviado = "";

            return nome_abreviado;
        }

        /// <summary>
        /// Devolve o cargo do empregado
        /// </summary>
        /// <returns>Designação do cargo</returns>
        public virtual string GetCargo()
        {
            return "Empregado";
        }
    }
}
