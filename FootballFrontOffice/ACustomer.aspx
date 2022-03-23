<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 31px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 46px; top: 89px; position: absolute; width: 118px; right: 386px" Text="Customer Number"></asp:Label>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 206px; top: 86px; position: absolute"></asp:TextBox>
        <p>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 47px; top: 133px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 205px; top: 135px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 205px; top: 177px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 46px; top: 174px; position: absolute; width: 67px; height: 23px" Text="Surname"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 45px; top: 221px; position: absolute" Text="Mobile Number"></asp:Label>
        <asp:TextBox ID="txtMobileNo" runat="server" style="z-index: 1; left: 203px; top: 218px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 202px; top: 266px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 44px; top: 265px; position: absolute; width: 89px; right: 1377px; height: 24px" Text="Address"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 44px; top: 343px; position: absolute" Text="DateAdded"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 203px; top: 338px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 110px; top: 431px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 47px; top: 489px; position: absolute; right: 1429px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 106px; top: 567px; position: absolute; height: 37px; width: 73px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 227px; top: 565px; position: absolute; height: 39px; width: 73px" Text="Cancel" />
    </form>
</body>
</html>
