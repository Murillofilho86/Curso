using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Dal.Entities;
using Projeto.Dal.Persistence;
using Projeto.Dal.Entities.Types;

namespace Projeto.Web.Admin
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteDal cd = new ClienteDal();

            if ( ! IsPostBack)
            {
                rblSexo.DataSource = Enum.GetNames(typeof(Sexo));
                rblSexo.DataBind();

                ddlEstadoCivil.DataSource = Enum.GetNames(typeof(EstadoCivil));
                ddlEstadoCivil.DataBind();

                ddlEstadoCivil.Items.Insert(0, new ListItem("-- Selecione um Opção --", string.Empty));
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();

                cli.Nome = txtNome.Text;
                cli.Email = txtEmail.Text;
                cli.DataNasc = DateTime.Parse(txtDataNasc.Text);
                cli.Sexo = (Sexo)Enum.Parse(typeof(Sexo), rblSexo.SelectedValue);
                cli.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), ddlEstadoCivil.SelectedValue);

                ClienteDal cd = new ClienteDal();
                cd.Insert(cli);
                lblMensagem.Text = "Cliente Gravado com Sucesso!";

                LimparCampos();

                Response.Redirect("/Admin/ListagemClientes.aspx");
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            rblSexo.SelectedIndex = 0;
            ddlEstadoCivil.SelectedIndex = 0;
        }
    }
}