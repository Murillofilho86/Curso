using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Dal.Entities;
using Projeto.Dal.Persistence;
using Projeto.Util.Security;

namespace Projeto.Web
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDal ud = new UsuarioDal();

                if ( ! ud.hasLogin(txtLogin.Text))
                {
                    Usuario user = new Usuario();

                    user.Nome = txtNome.Text;
                    user.Email = txtEmail.Text;
                    user.Login = txtLogin.Text;
                    user.Senha = Criptografia.EcriptarMD5(txtSenha.Text);

                    ud.Insert(user);

                    lblMessagem.Text = "Usuario " + user.Nome + ", Cadastrado com Sucesso!";

                    txtNome.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtLogin.Text = string.Empty;
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }
    }
}