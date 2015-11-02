using Projeto.Dal.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dal.Entities
{
    /// <summary>
    /// Classe de Entidade (Cliente)
    /// </summary>
    public class Cliente
    {
        #region Atributos

        private int idCliente;
        private string nome;
        private string email;
        private DateTime dataNasc;
        private Sexo sexo;
        private EstadoCivil estadoCivil;

        #endregion

        #region Construtores (Overload)

        public Cliente()
        {

        }

        public Cliente(int idCliente, string nome, string email, DateTime dataNasc, Sexo sexo, EstadoCivil estadoCivil)
        {
            this.idCliente = idCliente;
            this.nome = nome;
            this.email = email;
            this.dataNasc = dataNasc;
            this.sexo = sexo;
            this.estadoCivil = estadoCivil;

        }
        #endregion

        #region Encapsulamento

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public EstadoCivil EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        #endregion

        #region Sobrecarga de Metodos (override)

        public override string ToString()
        {
            return idCliente + ", " + nome + ", " + email + ", " + dataNasc  + ", " + sexo + ", " + estadoCivil;
        }

        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente c = (Cliente)obj;
                return this.idCliente == c.IdCliente;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.idCliente;
        }
        #endregion
    }
}
