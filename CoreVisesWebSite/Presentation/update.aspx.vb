'Importaciones necesarias
Imports MessageText

Public Class update
    Inherits System.Web.UI.Page

    ' Declaración de variables globales
    Dim selectedOption
    Dim service As New ClientServiceReference.ClientServiceClient
    Dim encryp As New EncryptionMethods
    Private exceptionMessage As New ExceptionMessage
    Private successMessage As New SuccessMessage
    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Verificamos que sea la primera vez que entra
        If Not MyClass.IsPostBack Then
            lblSuccessMessage.Text = successMessage.successUpdate
            hiddenAll()
            If Request.QueryString("option") Is Nothing Then
                dontSelect.Style.Add("display", "initial")
            Else
                showDiv()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Función que oculta todos los elementos
    ''' </summary>
    ''' <returns></returns>
    Function hiddenAll()
        dontSelect.Style.Add("display", "none")
        uAddress.Style.Add("display", "none")
        uPersonal.Style.Add("display", "none")
        uCard.Style.Add("display", "none")
        exitMessage.Style.Add("display", "none")
        wrongMessage.Style.Add("display", "none")
        btnUpdate.Visible = False
    End Function
    ''' <summary>
    ''' Función para mostrar el elemento seleccionado
    ''' </summary>
    ''' <returns></returns>
    Function showDiv()
        ' Se recupera el valor de la URL, y se almacena en una variable
        selectedOption = Request.QueryString("option")
        Select Case selectedOption
            Case "personal"
                fillFields()
                uPersonal.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case "address"
                fillFields()
                uAddress.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case "card"
                fillFields()
                uCard.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case Else
                dontSelect.Style.Add("display", "initial")
        End Select
    End Function
    ''' <summary>
    ''' Llena todos los campos con los valores predeterminados del web service
    ''' </summary>
    ''' <returns></returns>
    Function fillFields()
        Dim returnString As String = ""

        'Manejo de exceciones al momento de obtener al cliente
        Try
            returnString = encryp.decrypting(
                service.getClient(encryp.encrypt(CType(Session("user"), String), CType(Session("user"), String)), CType(Session("user"), String)), CType(Session("user"), String))
        Catch ex As Exception
            lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
        End Try

        If (returnString.Length > 0) Then
            Dim arrayClient As Array = returnString.Split(";")

            hdID.Value = arrayClient(0)
            txtFirstName.Text = arrayClient(1)
            txtFirstLastName.Text = arrayClient(2)
            txtSecondLastName.Text = arrayClient(3)
            txtEmail.Text = arrayClient(5)
            txtNumberCard.Text = arrayClient(6)
            txtAddressDirection.Text = arrayClient(7)
            txtPostalCode.Text = arrayClient(8)
            txtsvcCard.Text = arrayClient(9)
        Else
            lblWrongMessage.Text = Me.exceptionMessage.clientNoExist
            wrongMessage.Style.Add("display", "initial")
        End If
    End Function
    ''' <summary>
    ''' Evento que se ejecuta cuando se hace clic en el botón
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs)
        ' Se recupera el cliente
        Dim returnString As String = ""

        'Manejo de excepciones al momento de recuperar el cliente
        Try
            returnString = encryp.decrypting(
                service.getClient(encryp.encrypt(CType(Session("user"), String), CType(Session("user"), String)), CType(Session("user"), String)), CType(Session("user"), String))
        Catch ex As Exception
            lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
            wrongMessage.Style.Add("display", "initial")
        End Try

        'Se verifica que returnString no esté vacío
        If (returnString.Length > 0) Then
            Dim arrayClient As Array = returnString.Split(";")
            Dim clientToUpdate As String

            ' Se recupera el valor de la URL, y se almacena en una variable
            selectedOption = Request.QueryString("option")
            Select Case selectedOption
                Case "personal"
                    clientToUpdate = arrayClient(0) + ";" + txtFirstName.Text + ";" + txtFirstLastName.Text + ";" + txtSecondLastName.Text + ";" +
                        CType(Session("user"), String) + ";" + arrayClient(4) + ";" + txtEmail.Text + ";" + arrayClient(6) +
                        ";" + arrayClient(7) + ";" + arrayClient(8) + ";" + arrayClient(9)

                    'Manejo de excepciones al momento de actualizar
                    Try
                        service.updateClient((encryp.encrypt(clientToUpdate, CType(Session("user"), String))), CType(Session("user"), String))
                        exitMessage.Style.Add("display", "initial")
                    Catch ex As Exception
                        lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                        wrongMessage.Style.Add("display", "initial")
                    End Try
                Case "address"
                    clientToUpdate = arrayClient(0) + ";" + arrayClient(1) + ";" + arrayClient(2) + ";" + arrayClient(3) + ";" +
                        CType(Session("user"), String) + ";" + arrayClient(4) + ";" + arrayClient(5) + ";" + arrayClient(6) +
                        ";" + txtAddressDirection.Text + ";" + txtPostalCode.Text + ";" + arrayClient(9)

                    'Manejo de excepciones al momento de actualizar
                    Try
                        service.updateClient((encryp.encrypt(clientToUpdate, CType(Session("user"), String))), CType(Session("user"), String))
                        exitMessage.Style.Add("display", "initial")
                    Catch ex As Exception
                        lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                        wrongMessage.Style.Add("display", "initial")
                    End Try
                Case "card"
                    clientToUpdate = arrayClient(0) + ";" + arrayClient(1) + ";" + arrayClient(2) + ";" + arrayClient(3) + ";" +
                        CType(Session("user"), String) + ";" + arrayClient(4) + ";" + arrayClient(5) + ";" + txtNumberCard.Text +
                        ";" + arrayClient(7) + ";" + arrayClient(8) + ";" + txtsvcCard.Text

                    'Manejo de excepciones al momento de actualizar
                    Try
                        service.updateClient((encryp.encrypt(clientToUpdate, CType(Session("user"), String))), CType(Session("user"), String))
                        exitMessage.Style.Add("display", "initial")
                    Catch ex As Exception
                        lblWrongMessage.Text = Me.exceptionMessage.notConnectionWS
                        wrongMessage.Style.Add("display", "initial")
                    End Try
            End Select
        Else
            lblWrongMessage.Text = Me.exceptionMessage.clientNoExist
            wrongMessage.Style.Add("display", "initial")
        End If
    End Sub
End Class