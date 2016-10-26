<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="myShoppingBag.aspx.vb" Inherits="CoreVisesWebSite.myShoppingBag" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script type='text/javascript' src="//ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <div class="check_box">
                <form id="login_Client" runat="server">
                    <asp:ScriptManager ID="ScriptManager1" EnablePageMethods="true" 
                        EnablePartialRendering="true" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:HiddenField ID="phoneToDelete" ClientIDMode="Static" runat="server" />
                            <div class="col-md-9 cart-items">
                                <h1>My Shopping Bag (<asp:Label ID="lblAmount" runat="server"></asp:Label>)</h1>
                                <div class="cart-header">
                                    <table class="table">
                                        <thead>
                                            <tr>
                                                <th>Phone</th>
                                                <th>Quantity</th>
                                                <th>Price Dollar</th>
                                                <th>Price Collons</th>
                                                <th>Remove</th>
                                            </tr>
                                        </thead>
                                        <tbody id="tableBody" runat="server">
                                        </tbody>
                                    </table>
                                </div>
                            </div><!-- Fin del div col-md-9 cart-items-->
                            <div class="col-md-3 cart-total">
                                <ul class="total_price">
                                    <li class="last_price"> <h4>Total Colon</h4></li>	
                                    <li class="last_price"><span>₡<asp:Label ID="lblTotalColon" runat="server" Text="0"></asp:Label></span></li>
                                    <div class="clearfix"> </div>
                                    <li class="last_price"> <h4>Total Dolar</h4></li>	
                                    <li class="last_price"><span>$<asp:Label ID="lblTotalDollar" runat="server" Text="0"></asp:Label></span></li>
                                </ul>
                                <div class="clearfix"></div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <asp:Button ID="btnPay" runat="server" 
                                            CssClass="btn btn-default" Width="100%" BackColor="#F9D9BE" 
                                            Text="Pay" OnClick="btnPay_Click" ClientIDMode="Static"/>
                                    </div>
                                </div>
                                <div class="clearfix"></div>
                                <!-- Mensajes de error -->
                                <div id="wrongMessage" runat="server">
                                    <div class="form-group">
                                        <div class="alert alert-danger col-sm-offset-2" style="width:42%">
                                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                            <asp:Label ID="lblWrongMessage" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                                <div id="exitMessage" runat="server">
                                    <div class="form-group">
                                        <div class="alert alert-success col-sm-offset-2" style="width:42%">
                                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                            <asp:Label ID="lblSuccessMessage" runat="server"></asp:Label>
                                        </div>
                                    </div>
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
                            </div><!-- Fin del div col-md-3 cart-total-->
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </form>
            </div><!-- Fin del div check_box-->
        </div> <!-- Fin del div container-->
    </div><!-- Fin del div account-in-->
    <script type="text/javascript">
        function removePhone(phone)
        {
            document.getElementById('phoneToDelete').value = phone;
            PageMethods.filterPhone();
        }//Fin de la función
    </script>
</asp:Content>
