﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Layout.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="Projeto.Web.Admin.EditarCliente" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <a href="ListagemClientes.aspx" class="btn well">Voltar</a>
     
     <asp:HiddenField ID="hfIdCliente" runat="server" />
    <asp:Label ID="lblMensagem" runat="server" CssClass="alert-info" />
    <div class="panel panel-success" style="width: 500px; height: 600px">
        <div class="panel-heading">
            <h2 class="text-center">Cadastro de Clientes</h2>
        </div>
        <div class="panel-body">
            <label>Nome: </label>
            <asp:TextBox ID="txtNome" runat="server"
                CssClass="form-control"/><br />
            <asp:RequiredFieldValidator ID="rfvNome"
                runat="server" ControlToValidate="txtNome"
                ErrorMessage="Informe o Nome do Cliente." 
                ForeColor="SkyBlue" Display="Dynamic"/>

            <label>Email: </label>
            <asp:TextBox ID="txtEmail" runat="server"
                CssClass="form-control" /><br />
            <asp:RequiredFieldValidator ID="rfvEmail"
                runat="server" ControlToValidate="txtEmail"
                ErrorMessage="Informe o Email do Cliente."
                ForeColor="SkyBlue" Display="Dynamic" />

            <label>Data de Nascimento: </label>
            <asp:TextBox ID="txtDataNasc" runat="server"
                CssClass="form-control" /><br />
            <asp:RequiredFieldValidator ID="rfvDataNasc"
                runat="server" ForeColor="SkyBlue"
                Display="Dynamic" ControlToValidate="txtDataNasc"
                ErrorMessage="Informe a Data de Nascimento."
                />

            <label>Selecione o Sexo:</label>
            <asp:RadioButtonList ID="rblSexo" runat="server" 
              /><br />
            <asp:RequiredFieldValidator ID="rfvSexo"
                runat="server" ControlToValidate="rblSexo"
                ErrorMessage="Informe o Sexo."
                ForeColor="SkyBlue" Display="Dynamic"
                />

            <label>Selecione o Estado Civil:</label>
            <asp:DropDownList ID="ddlEstadoCivil" runat="server"
                CssClass="form-control" /><br />
            <asp:RequiredFieldValidator ID="rfvEstadoCivil"
                runat="server" ControlToValidate="ddlEstadoCivil"
                ErrorMessage="Informe o Estado Civil"
                ForeColor="SkyBlue" Display="Dynamic"
                />

            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar"
                 CssClass="btn btn-success btn-block" OnClick="btnAtualizar_Click"/>

            <asp:Button ID="btnExcluir" runat="server" Text="Excluir"
                CssClass="btn btn-primary btn-block" OnClick="btnExcluir_Click" />
        </div>
    </div>
</asp:Content>
