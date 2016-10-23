'Importaciones necesarias
Imports MessageText

Public Class allProducts
    Inherits System.Web.UI.Page

    'Declaración de variables globales
    Private encryp As New EncryptionMethods
    Private exceptionMessage As New ExceptionMessage
    Private key As String

    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wrongMessage.Style.Add("display", "none")

        'Pregunta que si es la primera ves en entrar
        If Not IsPostBack Then
            Dim servicebrand As New BrandServiceReference.BrandServiceClient
            Dim temp As String = ""

            'Preguntamos si el mae está o no logueado
            If Session.Item("user") Is Nothing Then
                Me.key = "None"
            Else
                Me.key = CType(Session("user"), String)
            End If

            'Manejo de excepciones al momento de recibir todas las marcas
            Try
                temp = encryp.decrypting(servicebrand.getAllBrands(Me.key), Me.key)
            Catch ex As Exception
                lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                wrongMessage.Style.Add("display", "initial")
            End Try

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
        End If
    End Sub
    ''' <summary>
    ''' Función que se encarga de mostrar todos los celulares del Web Service
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDivPhone()
        ' Declaraciones
        Dim servicePhone As New PhoneServiceReference.PhoneServiceClient
        Dim cont As Integer = 1
        'Dim temp As String = servicePhone.getPhones(CType(Session("user"), String))
        Dim temp As String = ""

        'Manejo de excepciones al momento de obtener todos los celulares
        Try
            temp = encryp.decrypting(servicePhone.getPhones(Me.key), Me.key)
        Catch ex As Exception
            lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
        End Try

        'Verificamos que temp no esté vacío
        If (temp.Length > 0) Then
            Dim phones As Array = temp.Split("#")

            'Recorremos cada uno de los celulares que nos da el Web Service
            For Each phoneT As String In phones
                Dim currentPhone As Array = phoneT.Split(";")
                If (currentPhone(0).ToString.Length > 0) Then
                    If cont < 3 Then
                        Response.Write(WritePhone("simpleCart_shelfItem",
                                                currentPhone(2) + " " + currentPhone(1),
                                                currentPhone(3), currentPhone(12),
                                                currentPhone(10), currentPhone(0)))
                    Else
                        Response.Write(WritePhone("last simpleCart_shelfItem",
                                                currentPhone(2) + " " + currentPhone(1),
                                                currentPhone(3), currentPhone(12),
                                                currentPhone(10), currentPhone(0)))
                        cont = 0
                    End If
                    cont = cont + 1
                End If
            Next
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
    Public Function WritePhone(ccsClass As String, brandModel As String, os As String, urlImage As String, price As String, id As String) As String
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
    ' Realiza todos los filtros indicados
    Private Function filter(currentPhone As Array) As Boolean
        If ddlOS.SelectedValue IsNot "Select" Then
            If currentPhone(3) IsNot ddlOS.SelectedValue Then
                Return False
            End If
        End If
        If ddlBrand.SelectedValue IsNot "Select" Then
            If currentPhone(2) IsNot ddlBrand.SelectedValue Then
                Return False
            End If
        End If
        If ddlNetworkMode.SelectedValue IsNot "Select" Then
            If currentPhone(4) IsNot ddlNetworkMode.SelectedValue Then
                Return False
            End If
        End If

        Return True
    End Function

    Protected Sub ddlOS_SelectedIndexChanged(sender As Object, e As EventArgs)
        GetDivPhone()
    End Sub

    Protected Sub ddlBrand_SelectedIndexChanged(sender As Object, e As EventArgs)
        GetDivPhone()
    End Sub

    Protected Sub ddlNetworkMode_SelectedIndexChanged(sender As Object, e As EventArgs)
        GetDivPhone()
    End Sub
End Class