using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dal.Entities
{
    /// <summary>
    /// Classe de Entidade (Usuario)
    /// </summary>
    public class Usuario
    {
        #region Atributos

        private int idUsuario;
        private string nome;
        private string login;
        private string senha;
        private string email;
        private DateTime dataCadastro;

        #endregion

        #region Construtores (Overload)

        public Usuario()
        {

        }

        public Usuario(int idUsuario, string nome, string login, string senha, string email, DateTime dataCadastro)
        {
            this.idUsuario = idUsuario;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.email = email;
            this.dataCadastro = dataCadastro;
        } 
        #endregion

        #region Encapsulamento 
        
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        #endregion

        #region Sobrecarga de Metodos (Override)

        public override string ToString()
        {
            return idUsuario + ", " + nome + ", " + login + ", " + senha + ", " + email + ", " + dataCadastro;
        }

        public override bool Equals(object obj)
        {
            if (obj is Usuario)
            {
                Usuario u = (Usuario)obj;
                return this.idUsuario == u.IdUsuario;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.idUsuario;
        }
        #endregion
    }
}
