<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="CoreVisesWebSite.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Kegg Phones</title>
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <link href="css/bootstrap.css" rel='stylesheet' type='text/css' />
        <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
        <!-- Custom Theme files -->
        <link href="css/style.css" rel='stylesheet' type='text/css' />
        <!-- Custom Theme files -->
        <!--webfont-->
        <link href='//fonts.googleapis.com/css?family=PT+Sans+Narrow:400,700' rel='stylesheet' type='text/css' />
        <link href='//fonts.googleapis.com/css?family=Dorsa' rel='stylesheet' type='text/css' />
        <script type="text/javascript" src="js/jquery-1.11.1.min.js"></script>
        <!-- start menu -->
        <link href="css/megamenu.css" rel="stylesheet" type="text/css" media="all" />
        <script type="text/javascript" src="js/megamenu.js"></script>
        <script>$(document).ready(function(){$(".megamenu").megamenu();});</script>
        <script src="js/jquery.easydropdown.js"></script>
        <script src="js/simpleCart.min.js"> </script>
        <!-- ícono --->
        <link rel="shortcut icon" type="image/x-icon" href="images/Logo.png" />
    </head>
    <body>
	    <div class="men_banner">
            <div class="container">
                <div class="header_top">
                    <div class="header_top_left">
                        <div class="box_11">
                            <a href="Presentation/myShoppingBag.aspx">
                                <h4>
                                    <p>Cart: </p><img src="images/bag.png" alt="" /><div class="clearfix"> </div>
                                </h4>
                            </a>
                        </div> <!-- Fin del div que muestra el total del carrito -->
                        <div class="clearfix"></div>
                    </div> <!-- DIV de todo el botón del carrito -->
                    <div class="header_top_right">
                        <ul class="header_user_info">
                            <i class="user"> </i>
                            <li class="user_desc">
                                <asp:HyperLink ID="logInf" runat="server" CssClass="login" NavigateUrl="~/Presentation/login.aspx">Log In</asp:HyperLink>
                            </li>
                            <div class="clearfix"> </div>
                        </ul>
                        <!-- start search-->
                        <div class="search-box">
                            <div id="sb-search" class="sb-search">
					            <form>
						            <input class="sb-search-submit" type="button"/>
						            <span class="sb-icon-search" id="btnSearch"> </span>
					            </form>
                            </div>
                        </div>
		                <div class="clearfix"> </div>
                    </div> <!-- Fin del header derecho -->
                    <div class="clearfix"> </div>
                </div> <!-- Fin del DIV que contiene las opciones de header -->

                <!-- DIV que contiene la imagen y el menú -->
                <div class="header_bottom">
                    <div class="logo">
                        <h1><a href="index.aspx"><span class="m_1">Kegg</span> Phones</a></h1>
                    </div><!-- Fin del DIV del logo -->
                    <div class="menu" id="menuController" runat="server">
                        <ul class="megamenu skyblue">
                            <li>
                                <a class="color2" href="#">Update Information</a>
                                <div class="megapanel">
                                    <div class="row">
                                        <div class="col1">
                                            <div class="h_nav">
                                                <ul>
                                                    <li><a href="Presentation/update.aspx?option=personal">Personal</a></li>
									                <li><a href="Presentation/update.aspx?option=address">Address</a></li>
									                <li><a href="Presentation/updatePassword.aspx">Password</a></li>
                                                    <li><a href="Presentation/update.aspx?option=card">Card</a></li>
								                </ul>	
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>				
                            <div class="clearfix"> </div>
                        </ul>
                    </div><!-- Fin del DIV del menú -->
                    <div class="clearfix"> </div>
                </div><!-- Fin del DIV que contiene la imagen y el menú -->
            </div> <!-- Fin del container de los elementos de arriba -->
	    </div> <!-- Fin del DIV de la clase banner -->
        <div class="main">
            <div class="container">
                <ul class="content-home">
                    <li class="col-sm-4">
                        <a href="Presentation/allProducts.aspx?os=Android" class="item-link" title="">
                            <div class="bannerBox">
                                <img src="images/w1.jpg" class="item-img" title="" alt="" width="100%" height="100%" />
                                <div class="item-html">
                                    <h3>Android</h3>
                                    <p>It is an operating system based on the Linux kernel.</p>
                                    <button>See more!</button>
                                </div>
                            </div>
                        </a>
                    </li> <!-- Fin de la información de Android -->
                    <li class="col-sm-4">
                        <a href="Presentation/allProducts.aspx?os=iOS" class="item-link" title="">
                            <div class="bannerBox">
                                <img src="images/w3.jpg" class="item-img" title="" alt="" width="100%" height="100%" />
                                <div class="item-html">
                                    <h3>iOS</span></h3>
                                    <p>It is a mobile operating system of the multinational Apple Inc.</p>
                                    <button>See more!</button>
                                </div>
                            </div>
                        </a>
                    </li> <!-- Fin de la información de iOS -->
                    <li class="col-sm-4">
                        <a href="Presentation/allProducts.aspx?os=Windows" class="item-link" title="">
                            <div class="bannerBox">
                                <img src="images/w2.jpg" class="item-img" title="" alt="" width="100%" height="100%" />
                                <div class="item-html">
                                    <h3>Windows<span>Phone</span></h3>
                                    <p>It is a mobile operating system developed by Microsoft</p>
                                    <button>See more!</button>
                                </div>
                            </div>
                        </a>
                    </li> <!-- Fin de la información de Windows Phone -->
                    <div class="clearfix"> </div>         
                </ul> <!-- Fin del UL content-home-->
            </div>

            <!-- Footer -->
            <div class="footer">
                <div class="container">
                    <div class="clearfix"></div>
                    <div class="copy">
                        <p> &copy; 2016 Kegg Phones. All Rights Reserved | Design by <a href="http://w3layouts.com/" target="_blank">W3layouts</a></p>
                    </div>
                </div>
            </div>

            <script type="text/javascript">
                $(document).ready
                (
                    function ()
                    {
                        $("#btnSearch").click
                        (
                            function ()
                            {
                                window.location.replace("./Presentation/searchPhone.aspx");
                            }//Función del evento
                        );//Código que se ejecuta cuando se hace clic
                    }//Fin de la función principal
                );
            </script>
        </body>
</html>