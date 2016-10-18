﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="allProducts.aspx.vb" Inherits="CoreVisesWebSite.allProducts" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <link href="../css/component.css" rel='stylesheet' type='text/css' />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="men">
        <div class="container">
            <div class="col-md-4 sidebar_men">
                <form id="getPhones" class="form-horizontal" runat="server">
                    <!-- Por tipos -->
                    <h3>Filters</h3>
                    <div class="form-group">
                        <asp:Label ID="lblOS" CssClass="control-label col-sm-2" runat="server"
                            Text="OS:" AssociatedControlID="ddlOS"></asp:Label>
                        <asp:DropDownList ID="ddlOS" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Android">Android</asp:ListItem>
                            <asp:ListItem Value="iOS">iOS</asp:ListItem>
                            <asp:ListItem Value="Windows Phone">Windows Phone</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblBrand" CssClass="control-label col-sm-2" runat="server"
                            Text="Brand:" AssociatedControlID="ddlOS"></asp:Label>
                        <asp:DropDownList ID="ddlBrand" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </form>
            </div>
            <div class="col-md-4 sidebar_men">
                <!-- Por tipos -->
                <h3>Categories</h3>
                <ul class="product-categories color"><li class="cat-item cat-item-42"><a href="#">Dresses</a> <span class="count">(14)</span></li>
                    <li class="cat-item cat-item-60"><a href="#">Glasses</a> <span class="count">(2)</span></li>
                    <li class="cat-item cat-item-63"><a href="#">Gloves</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-54"><a href="#">Jeans</a> <span class="count">(8)</span></li>
			        <li class="cat-item cat-item-55"><a href="#">Shoes</a> <span class="count">(11)</span></li>
			        <li class="cat-item cat-item-64"><a href="#">Shorts</a> <span class="count">(3)</span></li>
			        <li class="cat-item cat-item-61"><a href="#">Skirts</a> <span class="count">(3)</span></li>
			        <li class="cat-item cat-item-56"><a href="#">Sweaters</a> <span class="count">(6)</span></li>
			        <li class="cat-item cat-item-57"><a href="#">T-Shirts</a> <span class="count">(13)</span></li>
			        <li class="cat-item cat-item-58"><a href="#">Tops</a> <span class="count">(7)</span></li>
			        <li class="cat-item cat-item-62"><a href="#">Watchers</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-41"><a href="#">Women</a> <span class="count">(17)</span></li>
                </ul>

                <!-- Por colores -->
                <h3>Colors</h3>
                <ul class="product-categories color"><li class="cat-item cat-item-42"><a href="#">Green</a> <span class="count">(14)</span></li>
			        <li class="cat-item cat-item-60"><a href="#">Blue</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-63"><a href="#">Red</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-54"><a href="#">Gray</a> <span class="count">(8)</span></li>
			        <li class="cat-item cat-item-55"><a href="#">Green</a> <span class="count">(11)</span></li>
                </ul>

                <!-- Por tallas -->
                <h3>Sizes</h3>
                <ul class="product-categories color"><li class="cat-item cat-item-42"><a href="#">L</a> <span class="count">(14)</span></li>
                    <li class="cat-item cat-item-60"><a href="#">M</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-63"><a href="#">S</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-54"><a href="#">XL</a> <span class="count">(8)</span></li>
			        <li class="cat-item cat-item-55"><a href="#">XS</a> <span class="count">(11)</span></li>
                </ul>

                <!-- Por precios -->
                <h3>Price</h3>
                <ul class="product-categories"><li class="cat-item cat-item-42"><a href="#">200$-300$</a> <span class="count">(14)</span></li>
			        <li class="cat-item cat-item-60"><a href="#">300$-400$</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-63"><a href="#">400$-500$</a> <span class="count">(2)</span></li>
			        <li class="cat-item cat-item-54"><a href="#">500$-600$</a> <span class="count">(8)</span></li>
			        <li class="cat-item cat-item-55"><a href="#">600$-700$</a> <span class="count">(11)</span></li>
                </ul>
            </div> <!-- Fin del menú que aparece en la izquierda / col-md-4 sidebar_men -->
            <div class="col-md-8 mens_right">
                <div class="mens-toolbar">
                    <div class="sort">
                        <div class="sort-by">
                            <label>Sort By</label>
                            <select>
                                <option value="">Position</option>
                                <option value="">Name</option>
                                <option value="">Price</option>
                            </select>
                            <a href=""><img src="../images/arrow2.gif" alt="" class="v-middle"></a>
                        </div> <!-- Fin del div sort-by -->
                    </div><!-- Fin del div sort -->
                    <ul class="women_pagenation dc_paginationA dc_paginationA06">
                        <li><a href="#" class="previous">Page : </a></li>
                        <li class="active"><a href="#">1</a></li>
                        <li><a href="#">2</a></li>
                    </ul>
                    <div class="clearfix"></div>		
                </div><!-- Fin del div mens-toolbar -->
                <div id="cbp-vm" class="cbp-vm-switcher cbp-vm-view-grid">
                    <div class="cbp-vm-options">
                        <a href="#" class="cbp-vm-icon cbp-vm-grid cbp-vm-selected" data-view="cbp-vm-view-grid" title="grid">Grid View</a>
                        <a href="#" class="cbp-vm-icon cbp-vm-list" data-view="cbp-vm-view-list" title="list">List View</a>
                    </div>
                    <div class="pages">   
                        <div class="limiter visible-desktop">
                            <label>Show</label>
                            <select>
                                <option value="" selected="selected">9</option>
                                <option value="">15</option>
                                <option value="">30</option>
                            </select> per page        
                        </div> <!-- Fin del div limiter visible-desktop -->
                    </div> <!-- Fin del div pages -->
                    <div class="clearfix"></div>
                    <ul>
                        <li class="simpleCart_shelfItem">
                            <a class="cbp-vm-image" href="single.html">
                                <div class="view view-first">
                                    <div class="inner_content clearfix">
                                        <div class="product_image">
                                            <div class="mask1">
                                                <img src="../images/m4.jpg" alt="image" class="img-responsive zoom-img">
                                            </div>
                                            <div class="mask">
                                                <div class="info">Quick View</div>
                                            </div>
                                            <div class="product_container">
                                                <h4>Lorem 2015</h4>
                                                <p>Dresses</p>
                                                <div class="price mount item_price">$99.00</div>
                                                <a class="button item_add cbp-vm-icon cbp-vm-add" href="#">Add to cart</a>
                                            </div>		
                                        </div>
                                    </div>
                                </div> <!-- Fin del div view view-first -->
                            </a>
                        </li>
                        <li class="simpleCart_shelfItem">
                            <a class="cbp-vm-image" href="single.html">
                                <div class="view view-first">
                                    <div class="inner_content clearfix">
                                        <div class="product_image">
                                            <div class="mask1">
                                                <img src="../images/m4.jpg" alt="image" class="img-responsive zoom-img">
                                            </div>
                                            <div class="mask">
                                                <div class="info">Quick View</div>
                                            </div>
                                            <div class="product_container">
                                                <h4>Lorem 2015</h4>
                                                <p>Dresses</p>
                                                <div class="price mount item_price">$99.00</div>
                                                <a class="button item_add cbp-vm-icon cbp-vm-add" href="#">Add to cart</a>
                                            </div>		
                                        </div>
                                    </div>
                                </div> <!-- Fin del div view view-first -->
                            </a>
                        </li>
                        <li class="last simpleCart_shelfItem">
                            <a class="cbp-vm-image" href="single.html">
                                <div class="view view-first">
                                    <div class="inner_content clearfix">
                                        <div class="product_image">
                                            <div class="mask1">
                                                <img src="../images/m2.jpg" alt="image" class="img-responsive zoom-img">
                                            </div>
                                            <div class="mask">
                                                <div class="info">Quick View</div>
                                            </div>
                                            <div class="product_container">
                                                <h4>Lorem 2015</h4>
                                                <p>Dresses</p>
                                                <div class="price mount item_price">$99.00</div>
                                                <a class="button item_add cbp-vm-icon cbp-vm-add" href="#">Add to cart</a>
                                            </div>		
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
				<script src="../js/cbpViewModeSwitch.js" type="text/javascript"></script>
                <script src="../js/classie.js" type="text/javascript"></script>
    	</div> <!-- Fin del div col-md-8 mens_right -->
    </div> <!-- Fin del div container -->
   </div><!-- Fin del div men -->
</asp:Content>
