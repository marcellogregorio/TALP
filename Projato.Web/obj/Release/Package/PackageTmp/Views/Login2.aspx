<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="Projato.Web.Views.Login2" EnableSessionState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" media="screen" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <p class="text-center">
        Login:
    <br />
    <asp:TextBox ID="login" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
    <br />

    <asp:Button ID="btnEntrar" class="btn btn-small" runat="server" Text="Entrar"  OnClick="btnEntrar_Click"/>
    </p>
    </form>
</body>
</html>
