using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Dal.Entities;
using System.Data.SqlClient;
using Projeto.Dal.Entities.Types;

namespace Projeto.Dal.Persistence
{
    /// <summary>
    /// Classe de CRUD (Entidade Cliente)
    /// </summary>
    public class ClienteDal : Conexao
    {
        /// <summary>
        /// Metodo para inserir Cliente
        /// </summary>
        /// <param name="c">Cliente</param>
        public void Insert(Cliente c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("insert into Cliente(Nome, Email, DataNasc, Sexo, EstadoCivil) values(@v1, @v2, @v3, @v4, @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", c.Nome);
                Cmd.Parameters.AddWithValue("@v2", c.Email);
                Cmd.Parameters.AddWithValue("@v3", c.DataNasc);
                Cmd.Parameters.AddWithValue("@v4", c.Sexo.ToString());
                Cmd.Parameters.AddWithValue("@v5", c.EstadoCivil.ToString());
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o Cliente: " + ex.Message);
            }

            finally
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// Metodo para atualiar a tabela Cliente
        /// </summary>
        /// <param name="c">Cliente</param>
        public void Update(Cliente c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("update Cliente set Nome=@v1, Email=@v2, DataNasc=@v3, Sexo=@v4, EstadoCivil=@v5 where IdCliente=@v6", Con);
                Cmd.Parameters.AddWithValue("@v1", c.Nome);
                Cmd.Parameters.AddWithValue("@v2", c.Email);
                Cmd.Parameters.AddWithValue("@v3", c.DataNasc);
                Cmd.Parameters.AddWithValue("@v4", c.Sexo.ToString());
                Cmd.Parameters.AddWithValue("@v5", c.EstadoCivil.ToString());
                Cmd.Parameters.AddWithValue("@v6", c.IdCliente);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Cliente: " + ex.Message);
            }

            finally 
            {
                CloseConnection();
            }
        }
        /// <summary>
        /// Metodo para excluir Cliente 
        /// </summary>
        /// <param name="IdCliente"></param>
        public void Delete(int IdCliente)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("delete from Cliente where IdCliente = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", IdCliente);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar Cliente: " + ex.Message);
            }

            finally 
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// Metodo para encontrar um registro unico
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <returns>Um Cliente</returns>
        public Cliente FindById(int IdCliente)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select * from Cliente where IdCliente = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", IdCliente);
                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IdCliente = (Int32)Dr["IdCliente"];
                    cli.Nome = (String)Dr["Nome"];
                    cli.Email = (String)Dr["Email"];
                    cli.DataNasc = (DateTime)Dr["DataNasc"];
                    cli.Sexo = (Sexo)Enum.Parse(typeof(Sexo), Dr["Sexo"].ToString());
                    cli.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), Dr["EstadoCivil"].ToString());

                    return cli;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter Cliente: " + ex.Message);
            }

            finally 
            {
                CloseConnection();
            }

        }

        /// <summary>
        /// Metodo para Listar todo os Clientes
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public List<Cliente> FindAll()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("select * from cliente", Con);
                Dr = Cmd.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();

                while (Dr.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IdCliente = (Int32)Dr["IdCliente"];
                    cli.Nome = (String)Dr["Nome"];
                    cli.Email = (String)Dr["Email"];
                    cli.DataNasc = (DateTime)Dr["DataNasc"];
                    cli.Sexo = (Sexo)Enum.Parse(typeof(Sexo), Dr["Sexo"].ToString());
                    cli.EstadoCivil = (EstadoCivil) Enum.Parse(typeof(EstadoCivil), Dr["EstadoCivil"].ToString());

                    lista.Add(cli);
                }

                return lista;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao listar Clientes: " + ex.Message);
            }

            finally
            {
                CloseConnection();
            }
        }
    }
}
