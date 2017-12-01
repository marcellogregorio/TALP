<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projato.Web.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    Fazer Login:
    <br />
    <asp:TextBox ID="login" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
    <br />

    <asp:Button ID="btnEntrar" runat="server" Text="Entrar"  OnClick="btnEntrar_Click"/>
</asp:Content>
