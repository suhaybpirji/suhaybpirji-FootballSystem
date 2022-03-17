<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 38px; top: 108px; position: absolute; height: 199px; width: 264px"></asp:ListBox>
        </div>
        <asp:Label ID="lblEnter" runat="server" style="z-index: 1; left: 45px; top: 347px; position: absolute; height: 10px; width: 198px" Text="Please Enter First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 50px; top: 391px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 150px; top: 448px; position: absolute" Text="Display All" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 54px; top: 449px; position: absolute; width: 76px;" Text="Apply" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 176px; top: 576px; position: absolute; height: 31px; width: 73px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 41px; top: 581px; position: absolute; height: 29px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 111px; top: 579px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
