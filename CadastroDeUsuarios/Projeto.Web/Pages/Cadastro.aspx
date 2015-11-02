<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Layout.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto.Web.Cadastro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <div class="panel-success" style="width: 400px; height: 400px">
        <div class="panel-heading">
            <h3 style="text-align:center">Criar uma Conta</h3>
            <div class="panel-body">
                
                <label>Nome: </label>
                <asp:TextBox ID="txtNome" runat="server"
                    CssClass="form-control" placeholder="Ex.: Emanuel Mattos..."/>
                <asp:RequiredFieldValidator ID="rfvNome" runat="server" 
                    ControlToValidate="txtNome" ErrorMessage="Informe o Nome."
                    ForeColor="SkyBlue" Display="Dynamic" />
                <br />

                <label>Login: </label>
                <asp:TextBox ID="txtLogin" runat="server" 
                    CssClass="form-control" placeholder="Ex.: Emattos..."/>
                <asp:RequiredFieldValidator ID="rfvLogin" runat="server"
                    ControlToValidate="txtLogin" ErrorMessage="Informe o Login."
                    ForeColor="SkyBlue" Display="Dynamic" />
                <br />

                <label>Email: </label>
                <asp:TextBox ID="txtEmail" runat="server"
                    CssClass="form-control" placeholder="Ex.: emanuel@exemplo.com..." />
                 <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                    ControlToValidate="txtEmail" ErrorMessage="Informe o Email."
                    ForeColor="SkyBlue" Display="Dynamic" />
                <br />

                <label>Senha: </label>
                <asp:TextBox ID="txtSenha" runat="server"
                    CssClass="form-control" TextMode="Password" placeholder="Crie uma senha..."/>
                <asp:RequiredFieldValidator ID="rfvSenha" runat="server"
                    ControlToValidate="txtSenha" ErrorMessage="Informe a Senha."
                    ForeColor="SkyBlue" Display="Dynamic" />
                <br />

                <label>Confirme a Senha: </label>
                <asp:TextBox ID="txtConfSenha" runat="server"
                    CssClass="form-control" TextMode="Password" placeholder="Repita a Senha..." />
               <asp:RequiredFieldValidator ID="rfvConfSenha" runat="server"
                    ControlToValidate="txtConfSenha" ErrorMessage="Confirme a Senha."
                    ForeColor="SkyBlue" Display="Dynamic" />

                <asp:CompareValidator ID="cvConfSenha" runat="server"
                    ControlToValidate="txtConfSenha" ControlToCompare="txtSenha"
                    ErrorMessage="Senhas não conferem!"
                    ForeColor="SkyBlue" Display="Dynamic"/>
                <br />

                <asp:Button ID="btnCadastrar" runat="server" 
                    CssClass="btn btn-success btn-block" Text="Cadastar" OnClick="btnCadastrar_Click"/>&nbsp;
               
                <a href="/Default.aspx" class="btn btn-primary btn-block">Voltar</a>
                <asp:Label ID="lblMessagem" runat="server" CssClass="alert-info"/>
            </div>
        </div>
    </div>
</asp:Content>
