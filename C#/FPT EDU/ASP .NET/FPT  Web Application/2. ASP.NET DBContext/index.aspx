<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_2.ASP.NET_DBContext.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Catetogory Name&nbsp;
            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <input id="btnSave" type="submit" value="Save" /><br />
            <asp:GridView ID="gvProduct" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
