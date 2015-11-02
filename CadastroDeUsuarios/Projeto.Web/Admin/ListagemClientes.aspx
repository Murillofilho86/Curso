<%@ Page Title="Listagem de Clientes" Language="C#" MasterPageFile="~/Template/Layout.Master" AutoEventWireup="true" CodeBehind="ListagemClientes.aspx.cs" Inherits="Projeto.Web.Admin.ListagemClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
    <asp:Label ID="lblMensagem" runat="server" />
    <a href="/Admin/CadastroCliente.aspx" 
        class="btn btn-success">Incluir Cliente</a> 
       

      <h3 style="text-align: center">Listagem de Clientes</h3>

    <asp:GridView ID="gvClientes" runat="server"
        CssClass="table table-hover" GridLines="None"
        AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField 
                HeaderText="Código"
                DataField="IdCliente"
                />

            <asp:BoundField
                HeaderText="Nome"
                DataField="Nome"
               />

            <asp:BoundField
                HeaderText="Email"
                DataField="Email" 
                />
            <asp:BoundField 
                HeaderText="Data de Nascimento"
                DataField="DataNasc"
                DataFormatString="{0:dd/MM/yyyy}"
                />
            <asp:BoundField 
                HeaderText="Sexo"
                DataField="Sexo"
                />
            <asp:BoundField 
                HeaderText="Estado Civil"
                DataField="EstadoCivil"
                />
            <asp:HyperLinkField 
                HeaderText="Operações"
                Text="Editar"
                DataNavigateUrlFields="IdCliente"
                DataNavigateUrlFormatString="/Admin/EditarCliente.aspx?id={0}"/>
        </Columns>
    </asp:GridView>
      
</asp:Content>
