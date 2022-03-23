<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Order No"></asp:Label>
            <asp:TextBox ID="TextBoxOrderNo" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="TextBoxCustomerName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="TextBoxOrderDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Order Price"></asp:Label>
            <asp:TextBox ID="TextBoxOrderPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
