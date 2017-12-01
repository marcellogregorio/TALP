<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="Projato.Web.Views.Produto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    Categoria:
    <asp:DropDownList ID="ddlCategoria" runat="server" DataTextField="DescricaoCategoria" DataValueField="IdCategoria"></asp:DropDownList>
    <br />
    Descricao Produto:
    <asp:TextBox ID="txtProduto" runat="server"></asp:TextBox>
    <br />

    Preço Produto:
    <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Salvar" />
    <br />
    <asp:GridView ID="gdvProduto" runat="server"></asp:GridView>
</asp:Content> 
