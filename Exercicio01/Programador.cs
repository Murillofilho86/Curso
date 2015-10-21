
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Entity;

namespace Exercicio01
{
    /// <summary>
    /// Classe de Enditades
    /// </summary>
    public class Programador : Funcionario
    {
        #region Atributos

        private string tipo;

        #endregion

        #region Contrutores

        public Programador()
        {

        }

        public Programador(int idFucionario, string nome, decimal salario, string tipo)
            : base(idFucionario, nome, salario)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Encapsuladores

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        #endregion
    }
}
