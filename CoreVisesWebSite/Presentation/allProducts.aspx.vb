'Importaciones necesarias
Imports MessageText

Public Class allProducts
    Inherits System.Web.UI.Page

    'Declaración de variables globales
    Private encryp As New EncryptionMethods
    Private exceptionMessage As New ExceptionMessage
    Private key As String
    Private priceDollar As Double

    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wrongMessage.Style.Add("display", "none")
        Dim flag As Boolean = True

        'Preguntamos si el mae está o no logueado
        If Session.Item("user") Is Nothing Then
            Me.key = "None"
        Else
            Me.key = CType(Session("user"), String)
        End If

        'Preguntamos si tenemos el precio del dolar
        If Session.Item("dollar") Is Nothing Then
            Me.key = 500
        Else
            Me.key = CType(Session("dollar"), Double)
        End If

        'Pregunta que si es la primera ves en entrar
        If Not IsPostBack Then
            Dim servicebrand As New BrandServiceReference.BrandServiceClient
            Dim temp As String = ""
            Me.priceDollar = CType(Session("dollar"), Double)

            'Manejo de excepciones al momento de recibir todas las marcas
            Try
                temp = encryp.decrypting(servicebrand.getAllBrands(Me.key), Me.key)
            Catch ex As Exception
                lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                wrongMessage.Style.Add("display", "initial")
                flag = False
            End Try

            'Verificamos que no se haya caído
            If flag Then
                'Verificamos que temp no esté vacío
                If (temp.Length > 0) Then
                    Dim brand As Array = temp.Split("#")

                    For Each brandT As String In brand
                        Dim currentBrand As Array
                        currentBrand = brandT.Split(";")

                        If (currentBrand(0).ToString.Length > 0) Then
                            ddlBrand.Items.Add(currentBrand(1).ToString)
                        End If
                    Next
                End If

                'Verificamos si el cliente eligió un SO en el index
                If (Request.QueryString("os") Is Nothing) Then
                    Me.updatePanelPhone()
                Else
                    Select Case (Request.QueryString("os"))
                        Case "Android"
                            ddlOS.Items.FindByText("Android").Selected = True
                        Case "iOS"
                            ddlOS.Items.FindByText("iOS").Selected = True
                        Case "Windows"
                            ddlOS.Items.FindByText("Windows Phone").Selected = True
                        Case Else
                            ddlOS.Items.FindByText("Select").Selected = True
                    End Select
                    Me.updatePanelPhone()
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Función que se encarga de mostrar todos los celulares del Web Service
    ''' </summary>
    ''' <returns></returns>
    Public Function getDivPhone() As String
        ' Declaraciones
        Dim servicePhone As New PhoneServiceReference.PhoneServiceClient
        Dim cont As Integer = 1
        'Dim temp As String = servicePhone.getPhones(CType(Session("user"), String))
        Dim temp As String = ""
        Dim allPhone As String = ""
        Dim flag As Boolean = True

        'Manejo de excepciones al momento de obtener todos los celulares
        Try
            temp = encryp.decrypting(servicePhone.getPhones(Me.key), Me.key)
        Catch ex As Exception
            lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
            flag = False
        End Try

        'Verificamos que no se haya caído
        If flag Then
            'Verificamos que temp no esté vacío
            If (temp.Length > 0) Then
                Dim phones As Array = temp.Split("#")

                'Recorremos cada uno de los celulares que nos da el Web Service
                For Each phoneT As String In phones
                    Dim currentPhone As Array = phoneT.Split(";")
                    If (currentPhone(0).ToString.Length > 0) Then

                        'Verificamos con las funcionalidades especificades por el cliente
                        If (Me.filter(currentPhone)) Then
                            If cont < 3 Then
                                allPhone = allPhone & writePhone("simpleCart_shelfItem",
                                                        currentPhone(2) + " " + currentPhone(1),
                                                        currentPhone(3), currentPhone(12),
                                                        currentPhone(10), currentPhone(0))
                            Else
                                allPhone = allPhone & writePhone("last simpleCart_shelfItem",
                                                        currentPhone(2) + " " + currentPhone(1),
                                                        currentPhone(3), currentPhone(12),
                                                        currentPhone(10), currentPhone(0))
                                cont = 0
                            End If
                            cont = cont + 1
                        End If
                    End If
                Next
            End If
            Return allPhone
        Else
            Return "Nothing"
        End If
    End Function
    ''' <summary>
    ''' Función que se encarga de devolvernos varios elementos HTML, los cuales contienen el celular
    ''' </summary>
    ''' <param name="ccsClass">Corresponde a la clase CSS que se le desea aplicar</param>
    ''' <param name="brandModel">Corresponde a la marca y modelo del celular</param>
    ''' <param name="os">Corresponde al sistema operativo del celular</param>
    ''' <param name="urlImage">Corresponde a la URL de la imágen del celular</param>
    ''' <param name="price">Corresponde al precio del celular</param>
    ''' <param name="id">Corresponde al ID del celular</param>
    ''' <returns>
    ''' Un String que se va aplicar como código HTML dentro de la página ASPX
    ''' </returns>
    Private Function writePhone(ccsClass As String, brandModel As String, os As String, urlImage As String, price As String, id As String) As String
        Dim temp As String

        temp = "<li class='" + ccsClass + "'>
                <a class='cbp-vm-image' href='phoneInformation.aspx?id=" + id + "'>
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
                                    <div class='price mount item_price'>₡" + FormatNumber(Double.Parse(price), 2).ToString + "</div>
                                    <div class='price mount item_price'>$" + Me.calculatePriceDollars(price) + "</div>
                                </div>		
                            </div>
                        </div>
                    </div> <!-- Fin del div view view-first -->
                </a>
            </li>"

        Return temp
    End Function
    ''' <summary>
    ''' Función que nos permite pasar el precio de colones a dolares
    ''' </summary>
    ''' <param name="priceCollons">Corresponde al precio en colones</param>
    ''' <returns>
    ''' Un String con el precio en dolares
    ''' </returns>
    Private Function calculatePriceDollars(priceCollons As String) As String
        Dim priceC As Double = Double.Parse(priceCollons)
        Dim temp As Double = (priceC / Me.priceDollar)
        Return FormatNumber(temp, 2).ToString
    End Function
    ''' <summary>
    ''' Se encarga de realizar los filtros necesarios
    ''' </summary>
    ''' <param name="currentPhone"></param>
    ''' <returns></returns>
    Private Function filter(currentPhone As Array) As Boolean
        Dim flag As Boolean = True

        If Not (ddlOS.SelectedValue Like "Select") Then
            If Not (currentPhone(3).ToString.ToUpper Like ddlOS.SelectedValue.ToString.ToUpper) Then
                flag = False
            End If
        End If
        If Not (ddlBrand.SelectedValue Like "Select") Then
            If Not (currentPhone(2).ToString.ToUpper Like ddlBrand.SelectedValue.ToString.ToUpper) Then
                flag = False
            End If
        End If
        If Not (ddlNetworkMode.SelectedValue Like "Select") Then
            If (currentPhone(4).ToString.ToUpper Like ddlNetworkMode.SelectedValue.ToString.ToUpper) Then
                flag = False
            End If
        End If
        Return flag
    End Function
    ''' <summary>
    ''' Función que se ejecuta cuando se cambia el SO
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub ddlOS_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.updatePanelPhone()
    End Sub
    ''' <summary>
    ''' Función que se ejecuta cuando se cambia la marca
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub ddlBrand_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.updatePanelPhone()
    End Sub
    ''' <summary>
    ''' Función que se ejecuta cuando se cambia la red
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub ddlNetworkMode_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.updatePanelPhone()
    End Sub
    ''' <summary>
    ''' Función que se encarga de actualizar el panel de los celulares
    ''' </summary>
    ''' <returns></returns>
    Private Function updatePanelPhone()
        wrongMessage.Style.Add("display", "none")
        ulItems.InnerHtml = Me.getDivPhone()

        If (ulItems.InnerHtml.ToString().Length() = 0) Then
            lblWrongMessage.Text = Me.exceptionMessage.phoneNoExist
            wrongMessage.Style.Add("display", "initial")
        End If
    End Function
End Class