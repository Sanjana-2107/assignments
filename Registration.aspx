<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="user_login.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <div class="auto-style12">
        <span class="auto-style13"><strong>Registration Page
    </strong></span>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 285px;
        }
        .auto-style3 {
            width: 285px;
            height: 26px;
            text-align: right;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 285px;
            text-align: right;
        }
        .auto-style6 {
            width: 285px;
            text-align: right;
            height: 34px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style9 {
            height: 26px;
            width: 467px;
        }
        .auto-style10 {
            height: 34px;
            width: 467px;
        }
        .auto-style11 {
            width: 467px;
        }
        .auto-style12 {
            text-align: center;
        }
        .auto-style13 {
            font-size: x-large;
            color: #993399;
        }
        .auto-style14 {
            color: #993399;
        }
    </style>
</head>
<body>
    </div>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">User Name :</td>
                <td class="auto-style11">
                    <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="username is required" ForeColor="#990033" style="text-align: left"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">E-Mail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
                <td class="auto-style9">
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email is required !!" ForeColor="#990033"></asp:RequiredFieldValidator>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="you must enter the valid email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style6">Password&nbsp;&nbsp; :</td>
                <td class="auto-style10">
                    <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="confirmpassword" ErrorMessage="password must be 4 digits" ForeColor="#990033"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style5">Confirm Password :</td>
                <td class="auto-style11">
                    <asp:TextBox ID="confirmpassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="confirmpassword" ErrorMessage="confirm password is required" ForeColor="#990033"></asp:RequiredFieldValidator>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CompareValidator ID="pass" runat="server" ControlToCompare="confirmpassword" ControlToValidate="password" ErrorMessage="both the passwords must be same !" ForeColor="Blue"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="country" runat="server" Width="180px">
                        <asp:ListItem>SELECT COUNTRY</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>FRANCE</asp:ListItem>
                        <asp:ListItem>INDIA</asp:ListItem>
                        <asp:ListItem Value="USA">GERMANY</asp:ListItem>
                        <asp:ListItem>SRI LANKA</asp:ListItem>
                        <asp:ListItem>AFRICA</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="country" ErrorMessage="select a country name" ForeColor="#990033" InitialValue="SELECT COUNTRY"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
