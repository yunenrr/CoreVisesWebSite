<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Presentation/Principal.Master" CodeBehind="searchPhone.aspx.vb" Inherits="CoreVisesWebSite.searchPhone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link href="../css/component.css" rel='stylesheet' type='text/css' />
    <link rel="stylesheet" href="../css/font-awesome-4.6.3/css/font-awesome.min.css" />
    <script src="../js/EncryptionMethods.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalBoard" runat="server">
    <div class="men">
        <div class="container">
            <form id="getPhones" class="form-horizontal" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="col-md-4 sidebar_men">
                            <!-- Por tipos -->
                            <h3>Search</h3>
                            <div class="form-group">
                                <label id="lblSearch" class="control-label col-sm-2" for="txtSearch">Phone:</label>
                                <input id="txtSearch" class="form-control" type="text" />
                            </div>
                            <div class="form-group">
                                <input id="btnSearch" type="button" class="btn btn-default" value="Search" />
                            </div>
                        </div>
                        <div class="col-md-8 mens_right">
                            <div id="cbp-vm" class="cbp-vm-switcher cbp-vm-view-grid">
                                <div class="clearfix"></div>
                                <ul id="ulItems"></ul>
                            </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </form>
        </div>
    </div>
    <script type="text/javascript" >
        $(document).ready
        (
            function ()
            {
                //Se ejecuta cuando se hace clic sobre el botón
                $("#btnSearch").click
                (
                    function ()
                    {
                        var key = '<%= key %>';
                        consumeWebService(encrypt($("#txtSearch").val(), key), key);
                    }
                );

                /* Función que consume el Web Service */
                function consumeWebService(textSearch,key)
                {
                    var wordC = textSearch;
                    var keyC = key;
                    $.ajax({
                        type: "GET",
                        crossDomain: true,
                        url: "http://25.45.62.52/Services/PhonesLikeService.svc/getPhonesLike?word=" + wordC + "&key=" + keyC,
                        dataType: "json",
                        success: function (data)
                        {
                            var response = data['getPhonesLikeResult'];
                            getElements(decrypting(response, key));
                        },
                        error: function (xhr)
                        {
                            console.log("ERROR");
                            $("#ulItems").html("No connection to the web service.");
                        }
                    });
                }//Fin de la función

                //Función que se encarga de obtener un string con  HTML 
                function getElements(param)
                {
                    var returnString = param;
                    var allPhone = "";
                    //Se verifica que no esté vacío
                    if (returnString.length > 0)
                    {
                        var phones = returnString.split("#");
                        var cont = 1;
                        var i;

                        //Recorremos el arreglo de celulares
                        for (i = 0; i < phones.length; i++)
                        {
                            //Validamos que no esté vacío
                            if (phones[i].length > 0)
                            {
                                var currentPhone = phones[i].split(";")

                                //Se verifica que el ID no esté vacío
                                if (currentPhone[0].length > 0)
                                {
                                    //Se verifica que cont sea menor que 3
                                    if (cont < 3)
                                    {
                                        allPhone = allPhone + writeElement("simpleCart_shelfItem",
                                                            currentPhone[2] + " " + currentPhone[1],
                                                            currentPhone[3], currentPhone[12],
                                                            currentPhone[10], currentPhone[0]);
                                    }
                                    else
                                    {
                                        allPhone = allPhone + writeElement("last simpleCart_shelfItem",
                                                            currentPhone[2] + " " + currentPhone[1],
                                                            currentPhone[3], currentPhone[12],
                                                            currentPhone[10], currentPhone[0]);
                                        cont = 0;
                                    }
                                    cont = cont + 1;
                                }//Fin del if que verifica el ID
                            }//Fin del if
                        }//Fin del for
                        $("#ulItems").html(allPhone);
                    }//Fin del if que verifica que la consulta haya retornado un valor
                    else
                    {
                        $("#ulItems").html("<p>There are no cell with these name</p>");
                    }
                }//Fin de la función getElements

                //Función que nos retorna un elemento HTML
                function writeElement(ccsClass, brandModel, os, urlImage, price, id)
                {
                    var cssClass = ccsClass + "";
                    var brandModel = brandModel + "";
                    var os = os + "";
                    var urlImage = urlImage + "";
                    var price = price + "";
                    var id = id + "";
                    var temp = "";

                    temp = "<li class='" + ccsClass + "'>" +
                            "<a class='cbp-vm-image' href='phoneInformation.aspx?id=" + id + "'>" +
                            "<div class='view view-first'>" +
                            "<div class='inner_content clearfix'>" +
                            "<div class='product_image'>" +
                            "<div class='mask1'>" +
                            "<img src='" + urlImage + "' alt='image' class='img-responsive zoom-img'>" +
                            "</div>" +
                            "<div class='mask'>" +
                            "<div class='info'>Quick View</div>" +
                            "</div>" +
                            "<div class='product_container'>" +
                            "<h4>" + brandModel + "</h4>" +
                            "<p>" + os + "</p>" +
                            "<div class='price mount item_price'>₡" + parseFloat(price).toFixed(2) + "</div>" +
                            "<div class='price mount item_price'>$" + calculatePriceDollars(price) + "</div>" +
                            "</div>" +
                            "</div>" +
                            "</div>" +
                            "</div> <!-- Fin del div view view-first -->" +
                            "</a>" +
                            "</li>";
                    return temp;
                }//Fin de la función writeElement

                //Función que se encarga de calcular el precio en dólares
                function calculatePriceDollars(price)
                {
                    var priceDollar = parseFloat('<%=priceDollar %>');
                    var priceC = parseFloat(price);
                    var temp = (priceC / priceDollar);
                    return temp.toFixed(2);
                }//Fin de la función calculatePriceDollars
            }//Fin de la función principal
        );
    </script>
</asp:Content>