<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="user_login.Login"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type ="text/css">
        .style1
        {
            font-size: xx-large;
            text-align : center;
        }
        .style2{
            width : 100%;
        }

        .style3{
            width : 200px;
        }
        .style4
        {
            width : 200px;
            text-align : right;
            font-size : large;
            font-weight : bold;
        }

    </style>
</head>
<body>

    <form id="form1" runat="server">
    
        <div class="auto-style1">
            <strong>LOGIN PAGE</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">User Name</td>
                <td class="auto-style6">
                    <asp:TextBox ID="Username" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Username" ErrorMessage="plz enter username" ForeColor="#FFCC00"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="plz enter password" ForeColor="#FF9900"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style7">
                    <asp:Button ID="loginuser" runat="server" OnClick="loginuser_Click" Text="LOGIN" />
                </td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">New User Resgister Here!</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </form>
    </body>
    </html>
    
   