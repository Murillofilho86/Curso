using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto.Dal.Persistence
{
    /// <summary>
    /// Classe de conexão com o banco de dados (Persistencia)
    /// </summary>
    public class Conexao
    {
        #region Atributos
        
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        #endregion

        #region Metodos de Conexão (Abrir e Fechar)

        protected void OpenConnection()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["CadastroDeClientes"].ConnectionString);
                
            Con.Open();
        }

        protected void CloseConnection()
        {
            Con.Close();
        }
        #endregion
    }
}
