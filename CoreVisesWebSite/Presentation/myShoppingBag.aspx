<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="myShoppingBag.aspx.vb" Inherits="CoreVisesWebSite.myShoppingBag" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="account-in">
        <div class="container">
            <div class="check_box">
                <div class="col-md-9 cart-items">
                    <h1>My Shopping Bag (2)</h1>
                    <script>
                        $(document).ready(function (c)
                        {
                            $('.close1').on('click', function (c) {
                                $('.cart-header').fadeOut('slow', function (c) {
                                    $('.cart-header').remove();
                                });
                            });
                        });
                    </script>
                    <div class="cart-header">
                        <div class="close1"> </div>
                        <div class="cart-sec simpleCart_shelfItem">
                            <div class="cart-item cyc">
                                <img src="../images/m3.jpg" class="img-responsive" alt=""/>
                            </div>
                            <div class="cart-item-info">
                                <h3><a href="#">Mountain Hopper(XS R034)</a><span>Model No: 3578</span></h3>
                                <ul class="qty">
                                    <li><p>Size : 5</p></li>
                                    <li><p>Qty : 1</p></li>
                                </ul>
                                <div class="delivery">
                                    <p>Service Charges : Rs.100.00</p>
                                    <span>Delivered in 2-3 business days</span>
                                    <div class="clearfix"></div>
                                </div>	
                            </div><!-- Fin del div cart-item-info-->
                            <div class="clearfix"></div>
                        </div><!-- Fin del div cart-sec simpleCart_shelfItem-->
                    </div><!--Fin del div cart-header-->
                    <script>
                        $(document).ready(function (c)
                        {
                            $('.close2').on('click', function (c)
                            {
                                $('.cart-header2').fadeOut('slow', function (c)
                                {
                                    $('.cart-header2').remove();
                                });
                            });
                        });
                    </script>
                    <div class="cart-header">
                        <div class="close2"> </div>
                        <div class="cart-sec simpleCart_shelfItem">
                            <div class="cart-item cyc">
                                <img src="../images/m4.jpg" class="img-responsive" alt=""/>
                            </div>
                            <div class="cart-item-info">
                                <h3><a href="#">Mountain Hopper(XS R034)</a><span>Model No: 3578</span></h3>
                                <ul class="qty">
                                    <li><p>Size : 5</p></li>
                                    <li><p>Qty : 1</p></li>
                                </ul>
                                <div class="delivery">
                                    <p>Service Charges : Rs.100.00</p>
                                    <span>Delivered in 2-3 business days</span>
                                    <div class="clearfix"></div>
                                </div>	
                            </div><!-- Fin del div cart-item-info-->
                            <div class="clearfix"></div>
                        </div><!-- Fin del div cart-sec simpleCart_shelfItem-->
                    </div><!-- Fin del div cart-header2-->
                </div><!-- Fin del div col-md-9 cart-items-->
                <div class="col-md-3 cart-total">
                    <div class="price-details">
                        <h3>Price Details</h3>
				        <span>Total</span>
				        <span class="total1">6200.00</span>
				        <span>Delivery Charges</span>
				        <span class="total1">150.00</span>
				        <div class="clearfix"></div>
                    </div>
                    <ul class="total_price">
                        <li class="last_price"> <h4>TOTAL</h4></li>	
                        <li class="last_price"><span>6350.00</span></li>
                        <div class="clearfix"> </div>
                    </ul>
                    <div class="clearfix"></div>
                    <a class="order" href="#">Pay</a>
                    <div class="total-item">
                        <p><a href="login.aspx">Log In</a> to use accounts</p>
                    </div>
                </div><!-- Fin del div col-md-3 cart-total-->
            </div><!-- Fin del div check_box-->
        </div> <!-- Fin del div container-->
    </div><!-- Fin del div account-in-->
</asp:Content>
