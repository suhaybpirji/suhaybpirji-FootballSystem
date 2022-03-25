<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDelete.aspx.cs" Inherits="SupplierDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Are You Sure You Want To Delete This?"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Yes" />
            <asp:Button ID="Button2" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
