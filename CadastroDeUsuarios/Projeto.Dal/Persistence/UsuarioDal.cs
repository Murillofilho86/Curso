using Projeto.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dal.Persistence
{
    /// <summary>
    /// Classe de CRUD (Entidade Usuario)
    /// </summary>
    public class UsuarioDal : Conexao
    {
        /// <summary>
        /// Insero usuario no banco
        /// </summary>
        /// <param name="Usuario"></param>
        public void Insert(Usuario u)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("insert into Usuario(Nome, Email, Login, Senha, DataCadastro) values(@v1, @v2, @v3, @v4, GetDate())", Con);
                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2", u.Email);
                Cmd.Parameters.AddWithValue("@v3", u.Login);
                Cmd.Parameters.AddWithValue("@v4", u.Senha);
                Cmd.ExecuteNonQuery(); 

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Usuário: " + ex.Message);
            }

            finally
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// Busca um Usuario na base de dados
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Email"></param>
        /// <param name="Senha"></param>
        /// <returns>Usuario</returns>
        public Usuario Find(string Login, string Senha)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("Select * from Usuario where Login = @v1 and Senha = @v2", Con);
                Cmd.Parameters.AddWithValue("@v1", Login);
                Cmd.Parameters.AddWithValue("@v2", Senha);
                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Usuario user = new Usuario();
                    user.IdUsuario = (Int32)Dr["IdUsuario"];
                    user.Nome = (String)Dr["Nome"];
                    user.Email = (String)Dr["Email"];
                    user.Senha = (String)Dr["Senha"];
                    user.DataCadastro = (DateTime)Dr["DataCadastro"];

                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Usuário: " + ex.Message);
            }

            finally
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// Verifica se o login esta cadastrado na base dados
        /// </summary>
        /// <param name="Login"></param>
        /// <returns>Usuario cadastrado</returns>
        public bool hasLogin(string Login)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select count(*) from Usuario where Login = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Login);
                int qtd = (Int32)Cmd.ExecuteScalar();

                if (qtd > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar login: " + ex.Message);
            }

            finally 
            {
                CloseConnection();
            }
        }
    }
}
