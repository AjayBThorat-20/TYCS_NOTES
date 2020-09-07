<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Temp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<asp:Label ID="Label1" runat="server" Text="Input Temperature"></asp:Label>
            &nbsp;&nbsp;
           
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&deg;
            <asp:DropDownList ID="DropDownList1" runat="server">
                
                <asp:ListItem>Celsius</asp:ListItem>
                 <asp:ListItem>Farhenheit</asp:ListItem>
               
            </asp:DropDownList>
            
            <br/><br/>

            <asp:Button ID="Button1" runat="server" Text="Convert_to_Farhenhiet" OnClick="Button1_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Convert_to_Celsius" OnClick="Button2_Click" />
            <br/><br/>

            <asp:Label ID="Label3" runat="server" Text="Result :"></asp:Label>
            &nbsp;
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            &nbsp;<asp:Label ID="Label4" runat="server" Text=""></asp:Label>
</div>
    </form>
</body>
</html>
