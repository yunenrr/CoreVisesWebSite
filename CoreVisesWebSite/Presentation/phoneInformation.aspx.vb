'Importaciones necesarias
Imports MessageText

Public Class phoneInformation
    Inherits System.Web.UI.Page

    ' Declaración de variables globales
    Private encryp As New EncryptionMethods
    Private url As String
    Private key As String
    Private exceptionMessage As New ExceptionMessage
    Private successMessage As New SuccessMessage
    Private priceDollar As Double

    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dontSelect.Style.Add("display", "none")
        yesSelect.Style.Add("display", "none")
        wrongMessage.Style.Add("display", "none")
        exitMessage.Style.Add("display", "none")
        Me.priceDollar = CType(Session("dollar"), Double)

        'Verificamos que el cliente haya seleccionado un ID válido
        If Not (Request.QueryString("id") Is Nothing) Then
            Dim servicePhone As New PhoneServiceReference.PhoneServiceClient
            Dim returnString As String = ""
            Dim id As String = Request.QueryString("id")

            'Preguntamos si el mae está o no logueado
            If Session.Item("user") Is Nothing Then
                Me.key = "None"
            Else
                Me.key = CType(Session("user"), String)
            End If

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
                Dim arrayPhone As Array = returnString.Split(";")
                hfID.Value = arrayPhone(0)
                lblModelBran.Text = arrayPhone(2) + ": " + arrayPhone(1)
                lblOS.Text = arrayPhone(3)
                lblNetwork.Text = arrayPhone(4)
                lblIntMem.Text = arrayPhone(5)
                lblExtMem.Text = arrayPhone(6)
                lblPixels.Text = arrayPhone(7)
                lblFlash.Text = arrayPhone(8)
                lblResolution.Text = arrayPhone(9)
                lblPriceColon.Text = "₡" + FormatNumber(Double.Parse(arrayPhone(10)), 2).ToString
                lblPriceDollar.Text = "$" + Me.calculatePriceDollars(arrayPhone(10))
                Me.url = arrayPhone(12)
                dontSelect.Style.Add("display", "none")
                yesSelect.Style.Add("display", "initial")
            Else
                dontSelect.Style.Add("display", "initial")
                yesSelect.Style.Add("display", "none")
            End If
        Else
            dontSelect.Style.Add("display", "initial")
            yesSelect.Style.Add("display", "none")
        End If
    End Sub
    ''' <summary>
    ''' Función que se encarga de escribir la imagen del celular en la página
    ''' </summary>
    ''' <returns></returns>
    Public Function writePhone()
        Dim temp As String

        temp = "
                    <li data-thumb='" + Me.url + "'>
                        <img src='" + Me.url + "' />
                    </li>"
        Response.Write(temp)
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
    ''' Función que se ejecuta cuando se hace clic sobre el botón de agregar al carrito
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnAddCart_Click(sender As Object, e As EventArgs)
        Dim temp As String = CType(Session("phoneBuy"), String)

        'Se verifica que temp no esté vacío
        If (temp.Length > 0) Then
            Dim returnTemp As String = ""
            Dim arrayPhones As Array = temp.Split("#")
            Dim flag As Boolean = True
            Dim cont As Integer = 1

            'Se recorre por aquello de que ya el celular haya sido agregado
            For Each phoneTemp As String In arrayPhones
                Dim currentPhone As Array = phoneTemp.Split(";")

                'Se valida que el campo no esté vacío
                If (currentPhone(0).ToString.Length > 0) Then
                    'Se pregunta si es igual al actual
                    If (currentPhone(0) Like hfID.Value) Then
                        flag = False
                        currentPhone(1) = (Integer.Parse(currentPhone(1)) + Integer.Parse(ddlQuantity.SelectedItem.Value))
                    End If

                    'Se pregunta si es el primer valor
                    If (cont = 1) Then
                        returnTemp = String.Concat(returnTemp, (currentPhone(0) + ";" + currentPhone(1)))
                    Else
                        returnTemp = String.Concat(returnTemp, ("#" + currentPhone(0) + ";" + currentPhone(1)))
                    End If

                    cont = (cont + 1)
                End If
            Next

            'Se verifica, si no estaba en la lista se agrega
            If flag Then
                returnTemp = String.Concat(returnTemp, ("#" + hfID.Value + ";" + ddlQuantity.SelectedItem.ToString()))
            End If
            temp = returnTemp
        Else
            temp = String.Concat(temp, (hfID.Value + ";" + ddlQuantity.SelectedItem.ToString()))
        End If
        Session.Item("phoneBuy") = temp
        lblSuccessMessage.Text = Me.successMessage.successAdd
        exitMessage.Style.Add("display", "initial")
    End Sub
End Class