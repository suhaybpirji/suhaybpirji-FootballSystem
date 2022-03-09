<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 187px; top: 536px; position: absolute" Text="Delete" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 39px; top: 537px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 112px; top: 537px; position: absolute" Text="Edit" />
    </form>
</body>
</html>
