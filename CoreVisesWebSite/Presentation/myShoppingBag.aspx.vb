'Importaciones necesarias
Imports MessageText

Public Class myShoppingBag
    Inherits System.Web.UI.Page

    'Declaración de variables globales
    Private encryp As New EncryptionMethods
    Private exceptionMessage As New ExceptionMessage
    Private key As String
    Private priceDollar As Double
    Private listCartd As String = ""
    Private servicePhone As New PhoneServiceReference.PhoneServiceClient
    Private totalColons As Double = 0
    Private totalDollar As Double = 0
    Private amountItems As Integer = 0

    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wrongMessage.Style.Add("display", "none")
        Me.priceDollar = CType(Session("dollar"), Double)

        'Preguntamos si el mae está o no logueado
        If Session.Item("user") Is Nothing Then
            Me.key = "None"
        Else
            Me.key = CType(Session("user"), String)
        End If

        'Pregunta que si es la primera ves en entrar
        If Not IsPostBack Then
            Me.listCartd = Me.listCartd & CType(Session("phoneBuy"), String)

            phoneToDelete.Value = ""
            Me.writeHTML()
        End If
    End Sub
    '********************************* Escribir en la tabla *************************************
    ''' <summary>
    ''' Función que se encarga de escribir en la tabla
    ''' </summary>
    ''' <returns></returns>
    Private Function writeHTML()
        wrongMessage.Style.Add("display", "none")
        tableBody.InnerHtml = Me.getTextHTML()
        lblAmount.Text = Me.amountItems
        lblTotalColon.Text = FormatNumber(Me.totalColons, 2).ToString
        lblTotalDollar.Text = FormatNumber(Me.totalDollar, 2).ToString
    End Function

    ''' <summary>
    ''' Función que nos retornar código HTML, que contiene todos los tr de la tabla
    ''' </summary>
    ''' <returns>
    ''' Todos los tr que van a ser mostrados en la tabla
    ''' </returns>
    Private Function getTextHTML() As String
        Dim allPhoneList As String = ""

        'Se verifica que no se haya seleccionado eliminar algún teléfono
        If (Me.phoneToDelete.Value.ToString.Length > 0) Then
            Me.filterPhone()
        End If

        'Se verifica que temp no esté vacío
        If (Me.listCartd.Length > 0) Then
            'Obtenemos un arreglo de ID de celulares y Cantidades
            Dim arrayPhones As Array = Me.listCartd.Split("#")
            Dim tempPhone As Array

            'Recorremos el arreglo de ID de celulares y Cantidades
            For Each phoneTemp As String In arrayPhones
                Dim currentPhone As Array = phoneTemp.Split(";")

                'Se valida que el campo no esté vacío
                If (currentPhone(0).ToString.Length > 0) Then
                    tempPhone = Me.getPhoneInformation(currentPhone(0))
                    allPhoneList = allPhoneList & Me.writeTR((tempPhone(2) + " " + tempPhone(1)),
                                                             currentPhone(1), tempPhone(10), currentPhone(0))
                    Me.amountItems = (Me.amountItems + Integer.Parse(currentPhone(1)))
                End If
            Next
        End If
        Return allPhoneList
    End Function
    ''' <summary>
    ''' Función que se encarga de filtrar la lista de teléfonos
    ''' </summary>
    ''' <returns></returns>
    Private Function filterPhone()
        Dim temp As String = Me.phoneToDelete.Value.ToString
        Dim returnTemp As String = ""

        'Se verifica que el hidden field no esté vacío
        If (temp.Length > 0) Then
            'Se verifica que temp no esté vacío
            If (Me.listCartd.Length > 0) Then
                'Obtenemos un arreglo de ID de celulares y Cantidades
                Dim arrayPhones As Array = Me.listCartd.Split("#")

                'Recorremos el arreglo de ID de celulares y Cantidades
                For Each phoneTemp As String In arrayPhones
                    Dim currentPhone As Array = phoneTemp.Split(";")

                    'Se valida que el campo no esté vacío
                    If (currentPhone(0).ToString.Length > 0) Then
                        'Se pregunta si el código actual es igual de hidden field
                        If Not (currentPhone(0) Like Me.phoneToDelete.Value) Then
                            returnTemp = String.Concat(returnTemp, ("#" + currentPhone(0) + ";" + currentPhone(1)))
                        End If
                    End If
                Next
                Me.listCartd = returnTemp
            End If
        End If
        Me.phoneToDelete.Value = ""
    End Function
    ''' <summary>
    ''' Función que se encarga de mandar código HTML, específicamente TR
    ''' </summary>
    ''' <param name="name">Corresponde a la marca y modelo del celular</param>
    ''' <param name="quantity">Corresponde a la cantidad</param>
    ''' <param name="price">Corresponde al precio del celular</param>
    ''' <param name="id">Corresponde al ID del celular</param>
    ''' <returns>
    ''' Un String que dentro contiene código HTML
    ''' </returns>
    Private Function writeTR(name As String, quantity As String, price As String, id As String) As String
        Dim temp As String
        Me.totalColons = Me.totalColons + (Double.Parse(price) * Integer.Parse(quantity))
        Me.totalDollar = Me.totalDollar + ((Double.Parse(Me.calculatePriceDollars(price))) * Integer.Parse(quantity))

        temp =
            "
                <tr>
                    <td>" + name + "</td>
                    <td>" + quantity + "</td>
                    <td>$" + Me.calculatePriceDollars(price) + "</td>
                    <td>₡" + FormatNumber(Double.Parse(price), 2).ToString + "</td>
                    <td><input id='btn" + id + "' type='button' value='Remove' onclick='removePhone(" + id + ")'/></td>
                </tr>
            "
        Return temp
    End Function
    '********************************* Consultas al Web Service *********************************
    ''' <summary>
    ''' Función que nos retorna la información de un celular
    ''' </summary>
    ''' <param name="id">Corresponde al identificador único del celular</param>
    ''' <returns>
    ''' Un Array con la información correspondiente al celular solicitado
    ''' </returns>
    Private Function getPhoneInformation(id As String) As Array
        Dim returnString As String = ""
        Dim arrayPhone As Array

        'Manejo de excpeciones al momento de obtener la información del celular
        Try
            returnString = encryp.decrypting(servicePhone.getPhoneById(encryp.encrypt(id, Me.key), Me.key),
                                             Me.key)
        Catch ex As Exception
            lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
        End Try

        'Verificamos que returnString no esté vacío
        If (returnString.Length > 0) Then
            arrayPhone = returnString.Split(";")
        End If

        Return arrayPhone
    End Function
    ''' <summary>
    ''' Función que se ejecuta cuando se hace clic sobre el botón
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnPay_Click(sender As Object, e As EventArgs)
        Dim salePhone As New SalePhoneServiceReference.SalePhoneServiceClient
        'Preguntamos si está loguado
        If CType(Session("condition"), Integer) = 1 Then
            Dim id = Me.encryp.encrypt(CType(Session("id"), Integer), Me.key)
            Dim phones = Me.encryp.encrypt(Me.listCartd, Me.key)
            Dim total = Me.encryp.encrypt(Me.totalColons, Me.key)

            'Manejo de excepciones al momento de registrar la venta
            Try
                salePhone.registerSale(id, phones, total, Me.key)
            Catch ex As Exception
                lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                wrongMessage.Style.Add("display", "initial")
            End Try
        Else
            MyClass.Response.Redirect("~/Presentation/login.aspx", True)
        End If
    End Sub
    '***************************************** Cálculos *****************************************
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
    ''' Se cambio el estado del campo oculto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub phoneToDelete_ValueChanged(sender As Object, e As EventArgs)
        wrongMessage.Style.Add("display", "none")
        tableBody.InnerHtml = Me.getTextHTML()
    End Sub
End Class