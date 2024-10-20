<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Dynamic_GriedView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 568px; top: 297px; position: absolute; height: 152px; width: 232px">
            </asp:GridView>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 620px; top: 94px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 621px; top: 158px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="position: absolute; z-index: 1; left: 519px; top: 95px" Text="Name"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 517px; top: 163px; position: absolute" Text="Village"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 659px; top: 229px; position: absolute" Text="Submit" />
    </form>
</body>
</html>
