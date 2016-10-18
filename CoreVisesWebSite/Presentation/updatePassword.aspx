<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="updatePassword.aspx.vb" Inherits="CoreVisesWebSite.updatePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <form id="update_Password" class="form-horizontal center-block" runat="server" style="margin-left: 25%;">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <h2>Change Password</h2>
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
                        <!-- Vuelve a escribir la contraseña -->
                        <div class="form-group">
                            <asp:Label ID="lblRPassword" CssClass="control-label col-sm-2" runat="server" 
                                Text="Rewrite Password:" AssociatedControlID="txtRPassword"></asp:Label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtRPassword" TextMode="Password" MaxLength="30" runat="server"
                                    CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvRPassword" runat="server" ErrorMessage="Space blank" 
                                    ControlToValidate="txtRPassword" 
                                    Display="Dynamic" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="cvRPassword" runat="server" ErrorMessage="Differents passwords"
                                    ControlToCompare="txtPassword" ControlToValidate="txtRPassword"
                                    Display="Dynamic" CssClass="alert alert-danger"></asp:CompareValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-default" OnClick="btnUpdate_Click"/>
                            </div>
                        </div>
                        <div id="exitMessage" runat="server">
                            <div class="form-group">
                                <div class="alert alert-success col-sm-offset-2" style="width:42%">
                                    <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                    Successfully updated
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
