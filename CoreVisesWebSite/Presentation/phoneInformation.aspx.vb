'Importaciones necesarias
Imports MessageText

Public Class phoneInformation
    Inherits System.Web.UI.Page

    ' Declaración de variables globales
    Private encryp As New EncryptionMethods
    Private url As String
    Private key As String
    Private exceptionMessage As New ExceptionMessage

    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wrongMessage.Style.Add("display", "none")
        dontSelect.Style.Add("display", "none")
        yesSelect.Style.Add("display", "none")

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
                lblPriceColon.Text = "₡" + (Double.Parse(arrayPhone(10))).ToString
                Me.url = arrayPhone(12)
                dontSelect.Style.Add("display", "none")
                yesSelect.Style.Add("display", "initial")
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
End Class