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
                <asp:TextBox ID="txtSupplier" runat="server" style="z-index: 1; left: 109px; top: 36px; position: absolute"></asp:TextBox>

                <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 100px; top: 242px; position: absolute"></asp:TextBox>

                <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 107px; top: 74px; position: absolute"></asp:TextBox>

        <p>

        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
        </p>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>

            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" Width="53px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <p>

            <asp:Label ID="lblPostCode" runat="server" Text="PostCode"></asp:Label>
        
        </p>
    </form>
    </body>
</html>
