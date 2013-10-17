<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="ParseXML.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    This is iA going to become the Citation Machine... <br /><br />

    Welcome to the Citation Machine!<br /><br />
       
    ISBN-10: <asp:TextBox ID="isbn" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <br /><br />Output from server: <br /><br /> <%=t %>
           
    </div>
    </form>
</body>
</html>
