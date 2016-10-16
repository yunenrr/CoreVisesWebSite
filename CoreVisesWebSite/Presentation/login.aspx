<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="login.aspx.vb" Inherits="CoreVisesWebSite.login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server"></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <form id="login_Client" class="form-horizontal center-block" runat="server" style="margin-left: 25%;">
                <h2>Log In</h2>
                <!-- Nombre de usuario -->
                <div class="form-group">
                    <asp:Label ID="lblNameUser" CssClass="control-label col-sm-2" runat="server" 
                        Text="Name User:" AssociatedControlID="txtNameUser"></asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtNameUser" MaxLength="30" runat="server"
                            CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNameUser" runat="server" ErrorMessage="Write the user name" 
                            ControlToValidate="txtNameUser" 
                            Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <!-- Contraseña -->
                <div class="form-group">
                    <asp:Label ID="lblPassword" CssClass="control-label col-sm-2" runat="server" 
                        Text="Password:" AssociatedControlID="txtPassword"></asp:Label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtPassword" TextMode="Password" MaxLength="30" runat="server"
                            CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Write the password" 
                            ControlToValidate="txtPassword" 
                            Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <!-- Boton -->
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btnLogIn" runat="server" Text="Log In" CssClass="btn btn-default" OnClick="btnLogIn_Click"/>
                    </div>
                </div>
                <div class="col-md-12">
                    <asp:Label ID="Label3" runat="server" Text="Are not you registered? Click ">
                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Presentation/register.aspx" runat="server">here</asp:HyperLink></asp:Label>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
