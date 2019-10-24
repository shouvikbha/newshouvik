<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Lab_Asp.Net.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 247px;
        }
    </style>
    <script type="text/javascript">
    function setDate() {
            var today = new Date();
            var date = today.getDate();
            var month = today.getMonth();
            var year = today.getFullYear();
        document.getElementById("txtCreationDate").value = date + "-" + month + "-" + year;
        document.getElementById("txtCreationDate").disabled = true;
        }
    </script>
    <script type="text/javascript">
        function ValidateModuleList(source, args)
        {
            var chkListModules= document.getElementById ('<%= chkHobbies.ClientID %>');
            var chkListinputs = chkListModules.getElementsByTagName("input");
            for (var i=0;i<chkListinputs .length;i++)
            {
                if (chkListinputs [i].checked)
                {
                    args.IsValid = true;
                    return;
                }
            }
            args.IsValid = false;
        }
    </script>
</head>
<body onload="setDate()">
    <form id="form1" runat="server">
        <h1>Mail User Registration</h1>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <table runat="server">
            <tr>
                <td>
                    <asp:Label ID="lblMailUserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMailUserName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMailUserName" ErrorMessage="UserName is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is compulsory"></asp:RequiredFieldValidator>                   
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must have atleast 2 digits some where and minimum length is 7 and should start with capital letter" ControlToValidate="txtPassword" ValidationExpression="^[A-Z](?=(.*\d){2}).{7,}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCPassword" runat="server" Text="Confirm password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCPassword" ErrorMessage="Confirm password is compulsory"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password does not match" ControlToCompare="txtPassword" ControlToValidate="txtCPassword"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCreationDate" runat="server" Text="Creation Date"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCreationDate"  runat="server" ></asp:TextBox>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblHobbies" runat="server" Text="Hobbies"></asp:Label>
                </td>
                <td>
                    <asp:CheckBoxList ID="chkHobbies" runat="server">
                        <asp:ListItem>Reading</asp:ListItem>
                        <asp:ListItem>Drawing</asp:ListItem>
                        <asp:ListItem>Sports</asp:ListItem>
                        <asp:ListItem>Watching Tv</asp:ListItem>
                        <asp:ListItem>Singing</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style1">
                    
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="ValidateModuleList" ErrorMessage="select atleast one check box"></asp:CustomValidator>
                    
                </td>
            </tr>
            <tr>
                <td><a href="SignIn.aspx">Sign In</a></td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClientClick="" OnClick="btnSubmit_Click"/>
                </td>
                <td class="auto-style1"></td>
            </tr>            
        </table>
    </form>
</body>
</html>
