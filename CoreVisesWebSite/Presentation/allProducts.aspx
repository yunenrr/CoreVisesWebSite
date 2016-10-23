<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="allProducts.aspx.vb" Inherits="CoreVisesWebSite.allProducts" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <link href="../css/component.css" rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="men">
        <div class="container">
            <form id="getPhones" class="form-horizontal" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="col-md-4 sidebar_men">
                            <!-- Por tipos -->
                            <h3>Filters</h3>
                            <div class="form-group">
                                <asp:Label ID="lblOS" CssClass="control-label col-sm-2" runat="server"
                                    Text="OS:" AssociatedControlID="ddlOS"></asp:Label>
                                <asp:DropDownList ID="ddlOS" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlOS_SelectedIndexChanged">
                                    <asp:ListItem Value="Select">Select</asp:ListItem>
                                    <asp:ListItem Value="Android">Android</asp:ListItem>
                                    <asp:ListItem Value="iOS">iOS</asp:ListItem>
                                    <asp:ListItem Value="Windows Phone">Windows Phone</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblBrand" CssClass="control-label col-sm-2" runat="server"
                                    Text="Brand:" AssociatedControlID="ddlBrand"></asp:Label>
                                <asp:DropDownList ID="ddlBrand" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlBrand_SelectedIndexChanged">
                                    <asp:ListItem Value="Select">Select</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label ID="lblNetworkMode" CssClass="control-label col-sm-2" runat="server"
                                    Text="Net:" AssociatedControlID="ddlNetworkMode"></asp:Label>
                                <asp:DropDownList ID="ddlNetworkMode" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlNetworkMode_SelectedIndexChanged">
                                    <asp:ListItem Value="Select">Select</asp:ListItem>
                                    <asp:ListItem Value="2G">2G</asp:ListItem>
                                    <asp:ListItem Value="3G">3G</asp:ListItem>
                                    <asp:ListItem Value="4G">4G</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
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
                            </div>
                        </div><!-- Fin del menú que aparece en la izquierda / col-md-4 sidebar_men -->
                        <div class="col-md-8 mens_right">
                            <div id="cbp-vm" class="cbp-vm-switcher cbp-vm-view-grid">
                                <div class="clearfix"></div>
                                <ul id="ulItems" runat="server">
                                </ul>
                            </div>
                            <div id="wrongMessage" runat="server">
                                <div class="form-group">
                                    <div class="alert alert-danger col-sm-offset-2" style="width:42%">
                                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                        <asp:Label ID="lblWrongMessage" runat="server"></asp:Label>
                                    </div>
                                </div>
                            </div>
				            <script src="../js/cbpViewModeSwitch.js" type="text/javascript"></script>
                            <script src="../js/classie.js" type="text/javascript"></script>
                        </div><!-- Fin del div col-md-8 mens_right -->
                    </ContentTemplate>
                </asp:UpdatePanel>
            </form>
    </div> <!-- Fin del div container -->
   </div><!-- Fin del div men -->
</asp:Content>