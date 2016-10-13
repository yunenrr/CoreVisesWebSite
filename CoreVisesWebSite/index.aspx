﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="CoreVisesWebSite.index" %>

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
	    <div class="banner">
            <div class="container">
                <div class="header_top">
                    <div class="header_top_left">
                        <div class="box_11">
                            <a href="checkout.html">
                                <h4>
                                    <p>Cart: <span class="simpleCart_total"></span> (<span id="simpleCart_quantity" class="simpleCart_quantity"></span> items)</p><img src="images/bag.png" alt=""/><div class="clearfix"> </div>
                                </h4>
                            </a>
                        </div> <!-- Fin del div que muestra el total del carrito -->
                        <p class="empty"><a href="javascript:;" class="simpleCart_empty">Empty Cart</a></p>
                        <div class="clearfix"></div>
                    </div> <!-- DIV de todo el botón del carrito -->
                    <div class="header_top_right">
                        <div class="lang_list">
                            <select tabindex="4" class="dropdown">
					            <option value="0" class="label">₡ Colon</option>
					            <option value="1">$ Dollar</option>
					            <option value="2">₡ Colon</option>
				            </select>
			            </div>
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
						            <input class="sb-search-input" placeholder="Enter your search term..." type="search" name="search" id="search" />
						            <input class="sb-search-submit" type="submit" value="" />
						            <span class="sb-icon-search"> </span>
					            </form>
                            </div>
                        </div>
				        <!----search-scripts---->
                        <script src="js/classie1.js"></script>
				        <script src="js/uisearch.js"></script>
				        <script> new UISearch( document.getElementById( 'sb-search' ) );</script>
					    <!----//search-scripts---->
		                <div class="clearfix"> </div>
                    </div> <!-- Fin del header derecho -->
                    <div class="clearfix"> </div>
                </div> <!-- Fin del DIV que contiene las opciones de header -->

                <!-- DIV que contiene la imagen y el menú -->
                <div class="header_bottom">
                    <div class="logo">
                        <h1><a href="index.aspx"><span class="m_1">Kegg</span> Phones</a></h1>
                    </div><!-- Fin del DIV del logo -->
                    <div class="menu">
                        <ul class="megamenu skyblue">
                            <li>
                                <a class="color2" href="#">Network</a>
                                <div class="megapanel">
                                    <div class="row">
                                        <div class="col1">
                                            <div class="h_nav">
                                                <ul>
                                                    <li><a href="men.html">2G</a></li>
									                <li><a href="men.html">3G</a></li>
									                <li><a href="men.html">4G</a></li>
								                </ul>	
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <a class="color4" href="#">Brands</a>
                                <div class="megapanel" style="margin-left: 54%;">
                                    <div class="row">
                                        <div class="col2">
                                            <div class="h_nav">
                                                <ul>
                                                    <li><a href="men.html">Apple</a></li>
									                <li><a href="men.html">Samsung</a></li>
									                <li><a href="men.html">LG</a></li>
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
                        <a href="single.html" class="item-link" title="">
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
                        <a href="single.html" class="item-link" title="">
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
                        <a href="single.html" class="item-link" title="">
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
            <!-- Información que va en medio -->
            <div class="middle_content">
                <div class="container">
                    <h2>Welcome</h2>
                    <p>Online shopping variety of cell and smartphones to crazy prices..!!</p>
                </div>
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
        </body>
</html>
