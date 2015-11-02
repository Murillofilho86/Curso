<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-success" style="width: 300px; height: 300px">
        <div class="panel-heading">
            <h3 style="text-align:center">Dados do Usuario</h3>
        </div>
        <div class="panel-body">
            <div>
                <asp:TextBox ID="txtLogin" runat="server"
                    CssClass="form-control" placeholder="Login do Usuário..." 
                    />
                <asp:RequiredFieldValidator ID="rfvLoginEmail" runat="server"
                    ControlToValidate="txtLogin" ErrorMessage="Informe o Login."
                    ForeColor="SkyBlue" Display="Dynamic"
                    /><br />

                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"
                    CssClass="form-control" placeholder="Senha do Usuário..."
                    />
                <asp:RequiredFieldValidator ID="rfvSenha" runat="server"
                    
                    ControlToValidate="txtSenha" ErrorMessage="Informe a Senha."
                    ForeColor="SkyBlue" Display="Dynamic" /><br />

                <asp:CheckBox ID="chkManterConectado" runat="server" />
                    <label>Mantenha-me Conectado</label>
                <asp:Button ID="btnAcesso" runat="server"
                    Text="Entrar" CssClass="btn btn-success btn-block"
                    OnClick="btnAcesso_Click"/>
                <a href="/Pages/Cadastro.aspx" style="float: right">Criar uma Conta</a>
                <asp:Label ID="lblMensagem" runat="server"/>
            </div>
        </div>
    </div>
</asp:Content>