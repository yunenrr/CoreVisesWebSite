<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="phoneInformation.aspx.vb" Inherits="CoreVisesWebSite.phoneInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <script src="../js/easyResponsiveTabs.js" type="text/javascript"></script>
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
            <div class="col-md-9 single_top">
                <div class="single_left">
                    <div class="labout span_1_of_a1">
                        <div class="flexslider">
                            <ul class="slides">
                                <li data-thumb="../images/s1.jpg">
                                    <img src="../images/s1.jpg" />
                                </li>
                                <li data-thumb="../images/s2.jpg">
                                    <img src="../images/s2.jpg" />
                                </li>
                                <li data-thumb="../images/s3.jpg">
                                    <img src="../images/s3.jpg" />
                                </li>
                                <li data-thumb="../images/s4.jpg"
                                    ><img src="../images/s4.jpg" />
                                </li>
                            </ul>
                        </div><!-- Fin del div flexslider-->
                        <div class="clearfix"></div>	
                    </div> <!-- Fin del div labout span_1_of_a1 -->
                    <div class="cont1 span_2_of_a1 simpleCart_shelfItem">
                        <h1>Duis autem</h1>
                        <p class="availability">Availability: <span class="color">In stock</span></p>
                        <div class="price_single">
                            <span class="reducedfrom">$140.00</span>
                            <span class="amount item_price actual">$120.00</span>
                        </div>
                        <h2 class="quick">Quick Overview:</h2>
                        <p class="quick_desc"> Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; es</p>
                        <ul class="size">
                            <h3>Length</h3>
                            <li><a href="#">32</a></li>
                            <li><a href="#">34</a></li>
                        </ul>
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
                    </div><!-- Fin del div cont1 span_2_of_a1 simpleCart_shelfItem-->
                </div><!-- Fin del div single_left -->
            </div><!-- Fin del div col-md-9 single_top -->
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
