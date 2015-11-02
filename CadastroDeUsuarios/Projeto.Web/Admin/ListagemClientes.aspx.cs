using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Dal.Persistence;
using Projeto.Dal.Entities;

namespace Projeto.Web.Admin
{
    public partial class ListagemClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( ! IsPostBack)
            {
                try
                {
                    ClienteDal cd = new ClienteDal();
                    gvClientes.DataSource = cd.FindAll();
                    gvClientes.DataBind();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }

        }
    }
}