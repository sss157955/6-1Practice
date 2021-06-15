<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="_6_1Practice.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="cbl_tx" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="button1" runat="server" Text="Button" OnClick="btn1_Click" /><br />
            <asp:Label ID="lb1" runat="server" Text="Label"></asp:Label>
        </div>
         <div>
            <asp:RadioButtonList ID="rbl_tcx" runat="server">
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>D</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="button2" runat="server" Text="Button" PostBackUrl="~/CheckBoxCom.aspx" />
        </div>
    </form>
</body>
</html>
