﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AccountingNote.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>流水帳管理系統</h1>
            <a href="Login.aspx">登入</a>
        </div>
        <asp:PlaceHolder runat="server" ID="plcLogin" Visible="false">
            Account:
            <asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
            <br />
            Password:
            <asp:TextBox ID="txtPWD" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
            <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
        </asp:PlaceHolder>
    </form>
</body>
</html>
