<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="login.aspx.vb" Inherits="CoreVisesWebSite.login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <form id="login_Client" class="form-horizontal center-block" runat="server" style="margin-left: 25%;">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
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
                        <div class="form-group">
                            <div class="col-md-12">
                                <asp:Label ID="Label3" runat="server" Text="Are not you registered? Click ">
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Presentation/register.aspx" runat="server">here</asp:HyperLink></asp:Label>
                            </div>
                        </div>
                        <div id="wrongMessage" runat="server">
                            <div class="form-group">
                                <div class="alert alert-danger col-sm-offset-2" style="width:42%">
                                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                    The client entered does not exist in our system
                                </div>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                    <ProgressTemplate>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <i class="fa fa-spinner fa-pulse fa-3x fa-fw"></i>
                                <span class="sr-only">Loading...</span>
                            </div>
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </form>
        </div>
    </div>
</asp:Content>
