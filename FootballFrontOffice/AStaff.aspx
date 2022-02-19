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
        <asp:Label ID="lblIncome" runat="server" style="z-index: 1; left: 92px; top: 300px; position: absolute" Text="Income"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 92px; top: 249px; position: absolute; bottom: 392px; width: 97px;" Text="Surname"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 86px; top: 193px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; left: 79px; top: 138px; position: absolute" Text="Staff Number"></asp:Label>
        <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 218px; top: 138px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 444px; top: 167px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 209px; top: 368px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 72px; top: 372px; position: absolute" Text="DateAdded"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 120px; top: 426px; position: absolute" Text="Active" />
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 213px; top: 193px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 213px; top: 246px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 205px; top: 465px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 127px; top: 462px; position: absolute; " Text="OK" OnClick="btnOK_Click" />
        <asp:TextBox ID="txtIncome" runat="server" style="z-index: 1; left: 212px; top: 302px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
