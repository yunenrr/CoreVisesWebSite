<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="allProducts.aspx.vb" Inherits="CoreVisesWebSite.allProducts" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
    <link href="../css/component.css" rel='stylesheet' type='text/css' />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="men">
        <div class="container">
            <form id="getPhones" class="form-horizontal" runat="server">
              <div class="col-md-4 sidebar_men">
                    <!-- Por tipos -->
                    <h3>Filters</h3>
                    <div class="form-group">
                        <asp:Label ID="lblOS" CssClass="control-label col-sm-2" runat="server"
                            Text="OS:" AssociatedControlID="ddlOS"></asp:Label>
                        <asp:DropDownList ID="ddlOS" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Select">Select</asp:ListItem>
                            <asp:ListItem Value="Android">Android</asp:ListItem>
                            <asp:ListItem Value="iOS">iOS</asp:ListItem>
                            <asp:ListItem Value="Windows Phone">Windows Phone</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblBrand" CssClass="control-label col-sm-2" runat="server"
                            Text="Brand:" AssociatedControlID="ddlBrand"></asp:Label>
                        <asp:DropDownList ID="ddlBrand" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Select">Select</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNetworkMode" CssClass="control-label col-sm-2" runat="server"
                            Text="Brand:" AssociatedControlID="ddlOS"></asp:Label>
                        <asp:DropDownList ID="ddlNetworkMode" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Select">Select</asp:ListItem>
                            <asp:ListItem Value="2G">2G</asp:ListItem>
                            <asp:ListItem Value="3G">3G</asp:ListItem>
                            <asp:ListItem Value="4G">4G</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div><!-- Fin del menú que aparece en la izquierda / col-md-4 sidebar_men -->

                <div class="col-md-8 mens_right">
<%--                    <div class="mens-toolbar">
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
                    </div><!-- Fin del div mens-toolbar -->--%>

                    <div id="cbp-vm" class="cbp-vm-switcher cbp-vm-view-grid">
<%--                        <div class="pages">   
                            <div class="limiter visible-desktop">
                                <label>Show</label>
                                <select>
                                    <option value="" selected="selected">9</option>
                                    <option value="">15</option>
                                    <option value="">30</option>
                                </select> per page        
                            </div> <!-- Fin del div limiter visible-desktop -->
                        </div> <!-- Fin del div pages -->--%>
                        <div class="clearfix"></div>
                        <ul>
                            <%
                                ' Declaraciones
                                Dim cont As Integer = 1
                                Dim temp As String = servicePhone.getPhones
                                Dim phones As Array = temp.Split("#")

                                For Each phoneT As String In phones
                                    Dim currentPhone As Array
                                    currentPhone = phoneT.Split(";")

                                    If (currentPhone(0).ToString.Length > 0) Then
                                        If cont < 3 Then
                                            Response.Write(GetPhone("simpleCart_shelfItem",
                                                                    currentPhone(2) + " " + currentPhone(1),
                                                                    currentPhone(3), currentPhone(12),
                                                                    currentPhone(10)))
                                        Else
                                            Response.Write(GetPhone("last simpleCart_shelfItem",
                                                                    currentPhone(2) + " " + currentPhone(1),
                                                                    currentPhone(3), currentPhone(12),
                                                                    currentPhone(10)))
                                            cont = 0
                                        End If
                                        cont = cont + 1
                                    End If
                                Next
                            %>
                        </ul>
                    </div>
				    <script src="../js/cbpViewModeSwitch.js" type="text/javascript"></script>
                    <script src="../js/classie.js" type="text/javascript"></script>
                </div><!-- Fin del div col-md-8 mens_right -->

                <script runat="server">
                    Protected Function GetPhone(ccsClass As String, brandModel As String, os As String,
                                            urlImage As String, price As String) As String
                        Dim temp As String

                        temp = "                        <li class='" + ccsClass + "'>
                            <a class='cbp-vm-image' href='single.html'>
                                <div class='view view-first'>
                                    <div class='inner_content clearfix'>
                                        <div class='product_image'>
                                            <div class='mask1'>
                                                <img src='" + urlImage + "' alt='image' class='img-responsive zoom-img'>
                                            </div>
                                            <div class='mask'>
                                                <div class='info'>Quick View</div>
                                            </div>
                                            <div class='product_container'>
                                                <h4>" + brandModel + "</h4>
                                                <p>" + os + "</p>
                                                <div class='price mount item_price'>$" + price + "</div>
                                                <a class='button item_add cbp-vm-icon cbp-vm-add' href='#'>Add to cart</a>
                                            </div>		
                                        </div>
                                    </div>
                                </div> <!-- Fin del div view view-first -->
                            </a>
                        </li>"

                        Return temp
                    End Function
                </script>
            </form>
    </div> <!-- Fin del div container -->
   </div><!-- Fin del div men -->
</asp:Content>