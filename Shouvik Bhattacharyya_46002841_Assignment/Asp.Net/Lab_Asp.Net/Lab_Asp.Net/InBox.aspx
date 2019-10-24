<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InBox.aspx.cs" Inherits="Lab_Asp.Net.InBox"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gridMailList" runat="server" AutoGenerateColumns="false" OnRowDeleting="gridMailList_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MailTranNo" HeaderText="MailTranNo"/>
            <asp:BoundField DataField="FromMailUserId" HeaderText="FromMailUserId"/>
            <asp:HyperLinkField DataTextField="Subject" HeaderText="Subject" datatextformatstring="{0:c}"
            DataNavigateUrlFields="MailTranNo" datanavigateurlformatstring="~/ShowMail.aspx?MailTranNo={0}"/>
            <asp:BoundField DataField="MailDateTime" HeaderText="MailDateTime"/>
            <asp:CommandField ShowDeleteButton="true"/> 
        </Columns>
    </asp:GridView>
</asp:Content>
