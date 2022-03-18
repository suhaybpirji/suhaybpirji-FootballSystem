<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASupplier.aspx.cs" Inherits="ASupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSupplier" runat="server" Text="SupplierNo"></asp:Label>
        <input id="txtSupplier" type="text" /><p>
            <asp:Label ID="lblPostCode" runat="server" Text="PostCode"></asp:Label>
            <input id="txtPostCode" type="text" /></p>
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
        <input id="txtDateAdded" type="text" /><p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" Width="53px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
