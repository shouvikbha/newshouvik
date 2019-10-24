<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMail.aspx.cs" Inherits="Lab_Asp.Net.SendMail" MasterPageFile="~/Site1.Master"%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    <table runat="server">
        <tr>
            <td>
                <asp:Label ID="lblMailUName" runat="server" Text="To Mail User Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMailUName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="To mail is required" ControlToValidate="txtMailUName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblSubject" runat="server" Text="Subject"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Subject is required" ControlToValidate="txtSubject"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMailBody" runat="server" Text="Mail Body"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMailBody" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mail Body is required" ControlToValidate="txtMailBody"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
            </td>
        </tr>
    </table>
    
</asp:Content>
