using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entity
{
    /// <summary>
    ///Classe de Entidade
    /// </summary>
    public class Funcionario
    {
        #region Atributos

        private int idFuncionario;

        private string nome;

        private decimal salario;

        private Departamento departamento;

        #endregion

        #region Contrutores
        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario)
        {
            this.idFuncionario = idFuncionario;
            this.nome = nome;
            this.salario = salario;
        }

        public Funcionario(int idFuncionario, string nome, decimal salario, Departamento departamento)
            : this(idFuncionario, nome, salario)
        {
            this.departamento = departamento;
        }
        #endregion

        #region Encapsuladores
        public int IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Departamento Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        #endregion
    }
}
