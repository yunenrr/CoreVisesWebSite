<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="welcome.aspx.vb" Inherits="CoreVisesWebSite.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <form id="create_Client" class="form-horizontal center-block" runat="server" style="margin-left: 25%;">
                <h2>Welcome <asp:Label ID="lblName" runat="server" Text="Client"></asp:Label>!!</h2>
            </form>
        </div>
    </div>
</asp:Content>
