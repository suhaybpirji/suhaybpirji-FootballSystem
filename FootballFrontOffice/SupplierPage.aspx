<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierPage.aspx.cs" Inherits="SupplierPage" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:ListBox ID="lstSuppliers" runat="server" Height="118px" Width="335px"></asp:ListBox>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" Width="159px" />
            <asp:Button ID="btnDisplay" runat="server" Text="Display All" Width="175px" />
        </p>
        <asp:Label ID="lblPostCode" runat="server" Text="Please enter a PostCode"></asp:Label>
        <p>
            <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </p>
    </form>
</body>
</html>
