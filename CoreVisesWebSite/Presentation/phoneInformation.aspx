<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="phoneInformation.aspx.vb" Inherits="CoreVisesWebSite.phoneInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="../js/easyResponsiveTabs.js" type="text/javascript"></script>
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(
            function ()
            {
                $('#horizontalTab').easyResponsiveTabs(
                {
                    type: 'default', //Types: default, vertical, accordion           
                    width: 'auto', //auto or any width like 600px
                    fit: true   // 100% fit in a container
                }
                );
            }
            );
    </script>	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="men">
        <div class="container">
            <form id="phoneInformation" class="form-horizontal" runat="server">
                <!-- No seleccionó opción -->
                <div id="dontSelect" runat="server">
                    <h2>Please select one phone</h2>
                </div>
                <div id="yesSelect" runat="server">
                    <div class="col-md-9 single_top">
                        <div class="single_left">
                            <div class="labout span_1_of_a1">
                                <div class="flexslider">
                                    <ul class="slides">
                                        <% writePhone %>
                                    </ul>
                                </div><!-- Fin del div flexslider-->
                                <div class="clearfix"></div>	
                            </div> <!-- Fin del div labout span_1_of_a1 -->
                            <div class="cont1 span_2_of_a1 simpleCart_shelfItem">
                                <asp:HiddenField ID="hfID" runat="server" />
                                <h1><asp:Label ID="lblModelBran" runat="server"></asp:Label></h1>
                                <p class="availability">Availability: <span class="color">In stock</span></p>
                                <div class="price_single">
                                    <span class="item_price actual"><asp:Label ID="lblPriceDollar" runat="server"></span>
                                    <span class="item_price actual"><asp:Label ID="lblPriceColon" runat="server"></asp:Label></span>
                                </div>
                                <h2 class="quick">OS: <asp:Label ID="lblOS" runat="server"></asp:Label></h2>
                                <h2 class="quick">Network: <asp:Label ID="lblNetwork" runat="server"></asp:Label></h2>
                                <h2 class="quick">Internal Memory: <asp:Label ID="lblIntMem" runat="server"></asp:Label></h2>
                                <h2 class="quick">External Memory: <asp:Label ID="lblExtMem" runat="server"></asp:Label></h2>
                                <h2 class="quick">Pixels: <asp:Label ID="lblPixels" runat="server"></asp:Label></h2>
                                <h2 class="quick">Flash: <asp:Label ID="lblFlash" runat="server"></asp:Label></h2>
                                <h2 class="quick">Resolution: <asp:Label ID="lblResolution" runat="server"></asp:Label></h2>
                                <div class="quantity_box">
                                    <ul class="product-qty">
                                        <span>Quantity:</span>
                                        <select>
                                            <option>1</option>
                                            <option>2</option>
                                            <option>3</option>
                                            <option>4</option>
                                            <option>5</option>
                                            <option>6</option>
                                        </select>
                                    </ul>
                                    <ul class="single_social">
                                        <li><a href="#"><i class="fb1"> </i> </a></li>
						                <li><a href="#"><i class="tw1"> </i> </a></li>
						                <li><a href="#"><i class="g1"> </i> </a></li>
						                <li><a href="#"><i class="linked"> </i> </a></li>
		   		                    </ul>
                                    <div class="clearfix"></div>
                                </div><!--Fin del div quantity_box-->
                                <a href="#" class="btn btn-primary btn-normal btn-inline btn_form button item_add item_1" target="_self">Add to cart</a>
                                <div id="wrongMessage" runat="server">
                                    <div class="form-group">
                                        <div class="alert alert-danger col-sm-offset-2" style="width:42%">
                                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                                            <asp:Label ID="lblWrongMessage" runat="server"></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div><!-- Fin del div cont1 span_2_of_a1 simpleCart_shelfItem-->
                        </div><!-- Fin del div single_left -->
                    </div><!-- Fin del div col-md-9 single_top -->
                </div>
            </form>
        </div><!-- Fin de la clase container -->
    </div><!-- Fin del div men -->
    
    <!-- FlexSlider -->
    <script defer src="../js/jquery.flexslider.js"></script>
    <link rel="stylesheet" href="../css/flexslider.css" type="text/css" media="screen" />
    <script>
        // Can also be used with $(document).ready()
        $(window).load(
            function ()
            {
                $('.flexslider').flexslider(
                {
                    animation: "slide",
                    controlNav: "thumbnails"
                });
            }
        );
    </script>
</asp:Content>
