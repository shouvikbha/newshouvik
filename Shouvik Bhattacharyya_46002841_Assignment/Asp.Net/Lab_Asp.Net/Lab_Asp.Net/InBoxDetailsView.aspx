<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InBoxDetailsView.aspx.cs" Inherits="Lab_Asp.Net.InBoxDetailsView" MasterPageFile="~/Site1.Master"%>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" OnPageIndexChanging="DetailsView1_PageIndexChanging"
    OnItemDeleting="DetailsView1_ItemDeleting" AutoGenerateRows="false" AllowPaging="True">
    <Fields>
            <asp:BoundField DataField="MailTranNo" HeaderText="MailTranNo"/>
            <asp:BoundField DataField="FromMailUserId" HeaderText="FromMailUserId"/>
            <asp:HyperLinkField DataTextField="Subject" HeaderText="Subject" datatextformatstring="{0:c}"
            DataNavigateUrlFields="MailTranNo" datanavigateurlformatstring="~/ShowMail.aspx?MailTranNo={0}"/>
            <asp:BoundField DataField="MailDateTime" HeaderText="MailDateTime"/>
            <asp:CommandField ShowDeleteButton="true"/> 
        </Fields>
</asp:DetailsView>
</asp:Content>
