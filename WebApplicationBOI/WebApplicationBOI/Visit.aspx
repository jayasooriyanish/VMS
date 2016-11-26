<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visit.aspx.cs" Inherits="WebApplicationBOI.Visit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 519px">
    <form id="form1" runat="server">
    <div style="height: 221px">
    
        <asp:Label ID="LabelVisitId" runat="server" Text="Visit Id"></asp:Label>
        <asp:TextBox ID="TextBoxVisitId" runat="server" Height="16px" style="margin-left: 30px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelInDate" runat="server" Text="In Date"></asp:Label>
        <asp:TextBox ID="TextBoxInDate" runat="server" style="margin-left: 29px; margin-bottom: 8px" Width="120px"></asp:TextBox>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelOutDate" runat="server" Text="Out Date"></asp:Label>
        <asp:TextBox ID="TextBoxOutDate" runat="server" style="margin-left: 18px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelInTime" runat="server" Text="InTime"></asp:Label>
        <asp:TextBox ID="TextBoxInTime" runat="server" style="margin-left: 33px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelOutTime" runat="server" Text="Out Time"></asp:Label>
        <asp:TextBox ID="TextBoxOutTime" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
