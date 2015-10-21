using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entity
{
    /// <summary>
    /// Classe de Entidade
    /// </summary>
    public class Departamento
    {
        #region Atributos

        private int idDepartamento;

        private string nome;

        #endregion

        #region Construtores

        public Departamento()
        {

        }

        public Departamento(int idDepartamento, string nome)
        {
            this.idDepartamento = idDepartamento;
            this.nome = nome;
        }

        #endregion

        #region Encapsuladores
        
        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion
    }
}
