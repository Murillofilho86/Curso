using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Dal.Entities;
using Projeto.Dal.Entities.Types;
using Projeto.Dal.Persistence;

namespace Projeto.Web.Admin
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( ! IsPostBack)
            {
                rblSexo.DataSource = Enum.GetNames(typeof(Sexo));
                rblSexo.DataBind();

                ddlEstadoCivil.DataSource = Enum.GetNames(typeof(EstadoCivil));
                ddlEstadoCivil.DataBind();

                ddlEstadoCivil.Items.Insert(0, new ListItem("-- Escolha um Opção --", string.Empty));
                int IdCliente = Int32.Parse(Request.QueryString["id"]);

                try
                {
                    ClienteDal cd = new ClienteDal();
                    Cliente cli = cd.FindById(IdCliente);

                    hfIdCliente.Value = cli.IdCliente.ToString();
                    txtNome.Text = cli.Nome;
                    txtEmail.Text = cli.Email;
                    txtDataNasc.Text = cli.DataNasc.ToString("dd/MM/yyyy");
                    rblSexo.SelectedValue = cli.Sexo.ToString();
                    ddlEstadoCivil.SelectedValue = cli.EstadoCivil.ToString();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                    
                }
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.IdCliente = Int32.Parse(hfIdCliente.Value);
                cli.Nome = txtNome.Text;
                cli.Email = txtEmail.Text;
                cli.DataNasc = DateTime.Parse(txtDataNasc.Text);
                cli.Sexo = (Sexo)Enum.Parse(typeof(Sexo), rblSexo.SelectedValue);
                cli.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), ddlEstadoCivil.SelectedValue);

                ClienteDal cd = new ClienteDal();

                cd.Update(cli);
                Response.Redirect("/Admin/ListagemClientes.aspx");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
     
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int IdCliente = Int32.Parse(hfIdCliente.Value);

            ClienteDal cd = new ClienteDal();
            cd.Delete(IdCliente);

            lblMensagem.Text = "Cliente Excluido Com Sucesso!";
            Response.Redirect("/Admin/ListagemClientes.aspx");
        }
    }
}