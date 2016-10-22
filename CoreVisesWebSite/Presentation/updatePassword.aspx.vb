'Importaciones necesarias
Imports MessageText

Public Class updatePassword
    Inherits System.Web.UI.Page

    ' Declaración de variables globales
    Dim encryp As New EncryptionMethods
    Private exceptionMessage As New ExceptionMessage
    Private successMessage As New SuccessMessage
    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblSuccessMessage.Text = successMessage.successUpdate
        exitMessage.Style.Add("display", "none")
        wrongMessage.Style.Add("display", "none")
    End Sub
    ''' <summary>
    ''' Función que se ejecuta cuando se hace clic sobre el botón de actualizar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim service As New ClientServiceReference.ClientServiceClient
        Dim returnString As String = ""

        'Manejo de excepciones al momento de obtener el cliente
        Try
            returnString = encryp.decrypting(
                service.getClient(encryp.encrypt(CType(Session("user"), String), CType(Session("user"), String)), CType(Session("user"), String)), CType(Session("user"), String))
        Catch ex As Exception
            lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
        End Try

        'Verificamos que returnString no esté vacío
        If (returnString.Length > 0) Then
            Dim arrayClient As Array = returnString.Split(";")
            Dim clientToUpdate As String

            clientToUpdate = arrayClient(0) + ";" + arrayClient(1) + ";" + arrayClient(2) + ";" + arrayClient(3) + ";" +
                        CType(Session("user"), String) + ";" + txtRPassword.Text + ";" + arrayClient(5) + ";" + arrayClient(6) +
                        ";" + arrayClient(7) + ";" + arrayClient(8) + ";" + arrayClient(9)

            'Manejo de excepciones al momento de actualizar
            Try
                service.updateClient((encryp.encrypt(clientToUpdate, CType(Session("user"), String))), CType(Session("user"), String))
                exitMessage.Style.Add("display", "initial")
            Catch ex As Exception
                lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                wrongMessage.Style.Add("display", "initial")
            End Try
        Else
            lblWrongMessage.Text = Me.exceptionMessage.clientNoExist
            wrongMessage.Style.Add("display", "initial")
        End If
    End Sub
End Class