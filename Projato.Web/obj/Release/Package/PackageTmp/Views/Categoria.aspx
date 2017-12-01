<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="Projato.Web.Views.Produto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        Cadastrar Categoria
        <hr/>

        Descrição:
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>

        <br />
        <asp:Button ID="btnCadastrar" runat="server" Text="Salvar"  OnClick="btnCadastrar_Click"/>

        
    </div>
    <br />
    <div>
        <asp:GridView ID="gdvCategoria" runat="server"></asp:GridView>
    </div>
</asp:Content>
