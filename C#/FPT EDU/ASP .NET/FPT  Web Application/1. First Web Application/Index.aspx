<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_1.First_Web_Application.Demo_Web_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Uta95s</title>
</head>
<body>
    <form id="formLogin" runat="server" method="post">
        <div>
            <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblUser" runat="server" Text="UserName"></asp:Label>
            &nbsp;<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <hr />
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Passwords"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPass" runat="server" ></asp:TextBox>
        </div>
        <asp:Button ID="btnClick" runat="server" Text="Submit" OnClick="btnClick_Click" />
    </form>
</body>
</html>
