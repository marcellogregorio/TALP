<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Venda.aspx.cs" Inherits="Projato.Web.Views.Venda" EnableSessionState="True" EnableViewState="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Venda</h2>
      <hr />
    Produto:
    <asp:DropDownList ID="ddlProduto" runat="server" DataTextField="NomeProduto" DataValueField="IdProduto" AutoPostBack="true" OnSelectedIndexChanged="ddlProduto_SelectedIndexChanged"></asp:DropDownList>
  

    
    <br />
    Preço: (R$) 
    <asp:Label ID="lblPreco" runat="server" Text="10,00"></asp:Label>
    <br />
    <asp:Label ID="lblQtde" runat="server" Text="Quantidade: "></asp:Label>
   <asp:TextBox ID="txtQtde" runat="server" MaxLength="6"></asp:TextBox>

    <asp:Label id="lblQtdeInvalida" ForeColor="Red" runat="server" Visible="false"></asp:Label>
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Cadastar Venda" OnClick="btnSalvar_Click"/>
    <asp:Button ID="btnLimpar" runat="server" Text="Limpar"  OnClick="btnLimpar_Click"/>


    <hr />
    <hr />
    <asp:Button ID="btnFiltrar" runat="server" Text="Pesquisar" OnClick="btnFiltrar_Click" onRow/>
    <br />
    <asp:GridView ID="gdvVenda" runat="server"  OnRowCommand="gdvVenda_RowCommand"  OnRowEditing="gdvVenda_RowEditing" > 
        <Columns>
           
            <asp:ButtonField CommandName="EDITAR"    Text="editar"/>
        </Columns>
    </asp:GridView>
</asp:Content>
