using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestEmpresa_Afonso
{
    public class Morada
    {
        /// <summary>
        /// Criar constante para codigo posal por defeito
        /// </summary>
        public const string default_cd = "0000-000";
        /// <summary>
        /// Rua da morada
        /// </summary>
        public string rua { get; set; }
        /// <summary>
        /// campo priivado da localidade
        /// </summary>
        private string localidade;
        /// <summary>
        /// campo privado codigo postal
        /// </summary>
        private string codigo_postal;
        /// <summary>
        /// a localidade é atualizada sempre com letras maiusculas
        /// </summary>
        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }
        /// <summary>
        /// Codigo postal com o formato 0000-000
        /// </summary>
        public string Codigo_postal
        {
            get { return codigo_postal; }
            set { if (IsValidoCD(value))
                    codigo_postal = value;
                else
                    codigo_postal = default_cd; }
        }
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="rua"></param>
        /// <param name="localidade"></param>
        /// <param name="codigo_postal"></param>
        protected Morada(string rua, string localidade, string codigo_postal)
        {
            this.rua = rua;
            this.localidade = localidade;
            this.codigo_postal = codigo_postal;
        }
        /// <summary>
        /// Construtor com os parametros essenciais na criação do objeto
        /// </summary>
        /// <param name="codigo_postal"></param>
        public Morada(string codigo_postal): this("","", default_cd)
        {
        }
        /// <summary>
        /// Construtor com parametros por omissão
        /// </summary>
        public Morada():this("","","0000-000")
        { 
        }
        public static bool IsValidoCD(string codigo_postal)
            {//https://regex101.com/
             //https://regexr.com/
             //https://regexstorm.net/

            string pattern = @"^\d{4}-\d{3}$";

            return Regex.IsMatch(codigo_postal, pattern);
        }
    }
}
