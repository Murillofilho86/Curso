using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Dal.Entities;
using Projeto.Dal.Persistence;
using Projeto.Util.Security;
using System.Web.Security;

namespace Projeto.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDal ud = new UsuarioDal();
                Usuario user = ud.Find(txtLogin.Text, Criptografia.EcriptarMD5(txtSenha.Text));
                
                //Se usuario existe no banco, entra no IF
                if (user != null)
                {
                    
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(user.Login, chkManterConectado.Checked, 5);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));

                    Response.Cookies.Add(cookie);
                    Response.Redirect("/Admin/ListagemClientes.aspx");
 

                }
                else
                {
                    lblMensagem.Text = "Usuario Não Encontrado.";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}