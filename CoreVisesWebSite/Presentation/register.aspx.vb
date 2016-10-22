'importaciones necesarias
Imports MessageText

Public Class register
    Inherits System.Web.UI.Page

    'Declaración de variables globales
    Dim encryp As New EncryptionMethods
    Private excetionMessage As New ExceptionMessage
    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wrongMessage.Style.Add("display", "none")
    End Sub
    ''' <summary>
    ''' Función que se ejecuta cuando se hace clic sobre el botón de registrar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnRegister_Click(sender As Object, e As EventArgs)
        Dim service As New ClientServiceReference.ClientServiceClient
        Dim tempString = txtNameUser.Text + ";" + txtPassword.Text
        Dim tempValue As Integer

        'Manejo de excepción al momento de consultar si el cliente existe
        Try
            tempValue = Integer.Parse(encryp.decrypting(
                                      service.verifyExistsClient(encryp.encrypt(tempString, txtNameUser.Text), txtNameUser.Text),
                                      txtNameUser.Text))
        Catch ex As Exception
            lblMessage.Text = Me.excetionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
        End Try

        ' Si es igual a cero es porque no existe
        If (tempValue = 0) Then
            tempString = "0" + ";" + txtFirstName.Text + ";" + txtFirstLastName.Text + ";" + txtSecondLastName.Text + ";" +
                txtNameUser.Text + ";" + txtRPassword.Text + ";" + txtEmail.Text + ";" + txtNumberCard.Text +
                ";" + txtAddressDirection.Text + ";" + txtPostalCode.Text + ";" + txtsvcCard.Text

            'Manejo de excepción al momento de insertar un cliente
            Try
                service.insertClient((encryp.encrypt(tempString, txtNameUser.Text)), txtNameUser.Text)
                wrongMessage.Style.Add("display", "none")
                MyClass.Response.Redirect("~/Presentation/login.aspx", True)
            Catch ex As Exception
                lblMessage.Text = Me.excetionMessage.notConnectionWS
                wrongMessage.Style.Add("display", "initial")
            End Try
        Else
            lblMessage.Text = Me.excetionMessage.clientExist
            wrongMessage.Style.Add("display", "initial")
        End If
    End Sub
End Class