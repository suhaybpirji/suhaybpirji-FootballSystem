<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblIncome" runat="server" style="z-index: 1; left: 90px; top: 217px; position: absolute" Text="Income"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 91px; top: 163px; position: absolute; bottom: 559px; width: 97px;" Text="Surname"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 88px; top: 105px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 229px; top: 106px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 232px; top: 159px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 244px; top: 301px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 127px; top: 302px; position: absolute; " Text="OK" OnClick="btnOK_Click" />
        <asp:TextBox ID="txtIncome" runat="server" style="z-index: 1; left: 230px; top: 219px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
