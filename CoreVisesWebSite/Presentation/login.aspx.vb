'Importaciones necesarias
Imports MessageText

Public Class login
    Inherits System.Web.UI.Page

    ' Declaración de variables globales
    Private encryp As New EncryptionMethods
    Private excetionMessage As New ExceptionMessage
    ''' <summary>
    ''' Función que se ejecuta cuando carga la página
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wrongMessage.Style.Add("display", "none")
        If Not (Request.QueryString("exit") Is Nothing) Then
            Session.Item("condition") = 0
            Session.Item("user") = ""
            Session.Item("phoneBuy") = ""
            Response.Redirect("../index.aspx", True)
        End If
    End Sub
    ''' <summary>
    ''' Función que se ejecuta cuando se hace clic al botón de LogIn
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">Corresponde al evento</param>
    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs)
        Dim service As New ClientServiceReference.ClientServiceClient
        Dim tempString = txtNameUser.Text + ";" + txtPassword.Text
        Dim tempValue As Integer
        Dim flag As Boolean = True

        'Se verifica en el web service que el usuario exista
        Try
            tempValue = Integer.Parse(encryp.decrypting(
                                         service.verifyExistsClient(encryp.encrypt(tempString, txtNameUser.Text), txtNameUser.Text),
                                         txtNameUser.Text))
        Catch ex As Exception
            lblMessage.Text = Me.excetionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
            flag = False
        End Try

        'Se verifica que no se haya caído
        If flag Then
            'Si es diferente de 1, es porque el cliente existe
            If (tempValue <> 0) Then
                Session.Item("condition") = 1
                Session.Add("user", txtNameUser.Text)
                Dim returnString As String = ""
                flag = True

                ' Manejo de excepción al momento de obtener el cliente
                Try
                    returnString = encryp.decrypting(
                        (service.getClient(encryp.encrypt(txtNameUser.Text, txtNameUser.Text), txtNameUser.Text)), txtNameUser.Text)
                Catch ex As Exception
                    lblMessage.Text = Me.excetionMessage.notConnectionWS
                    wrongMessage.Style.Add("display", "initial")
                    flag = False
                End Try

                'Verificamos que no haya caído
                If flag Then
                    'Verificamos que returnString no esté vacío
                    If (returnString.Length > 0) Then
                        Dim arrayPhone As Array = returnString.Split(";")
                        Session.Add("name", (arrayPhone(1) + " " + arrayPhone(2) + " " + arrayPhone(3)))
                        Session.Add("id", arrayPhone(0))
                        wrongMessage.Style.Add("display", "none")
                        MyClass.Response.Redirect("~/Presentation/welcome.aspx", True)
                    End If
                End If
            Else
                lblMessage.Text = Me.excetionMessage.clientNoExist
                wrongMessage.Style.Add("display", "initial")
            End If
        End If
    End Sub
End Class