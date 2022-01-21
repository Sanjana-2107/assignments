<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ad.aspx.cs" Inherits="WebApplication3.ad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> LOG IN</title>
    ADMIN LOGIN
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: hotpink;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="NAME"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNAME" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="contact_no"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtcontact_no" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    
                     <td><asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" /></td>   
                    <td>  <asp:Button ID="Button2" runat="server" Text="reset" /></td>  
                    </table>
            <hr />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
