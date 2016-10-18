Public Class update
    Inherits System.Web.UI.Page
    Dim selectedOption
    Dim service As New ClientServiceReference.ClientServiceClient
    Dim clientTemp As New ClientServiceReference.Client

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None

        If Not MyClass.IsPostBack Then
            hiddenAll()
            If Request.QueryString("option") Is Nothing Then
                dontSelect.Style.Add("display", "initial")
            Else
                showDiv()
            End If
        End If
    End Sub
    ' Función que oculta todos los elementos
    Function hiddenAll()
        dontSelect.Style.Add("display", "none")
        uAddress.Style.Add("display", "none")
        uPersonal.Style.Add("display", "none")
        uCard.Style.Add("display", "none")
        exitMessage.Style.Add("display", "none")
        btnUpdate.Visible = False
    End Function
    ' Función para mostrar el elemento seleccionado
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
    ' Llena todos los campos con los valores predeterminados
    Function fillFields()
        clientTemp = service.getClient(CType(Session("user"), String))
        txtFirstName.Text = clientTemp.Name
        txtFirstLastName.Text = clientTemp.LastName_1
        txtSecondLastName.Text = clientTemp.LastName_2
        txtEmail.Text = clientTemp.Email
        txtPostalCode.Text = clientTemp.PostalCode
        txtAddressDirection.Text = clientTemp.AddressDirection
        txtNumberCard.Text = clientTemp.NumberCard
        txtsvcCard.Text = clientTemp.SvcCard
    End Function
    ' Evento que se ejecuta cuando se hace clic en el botón
    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs)
        ' Se recupera el cliente
        clientTemp = service.getClient(CType(Session("user"), String))

        ' Se recupera el valor de la URL, y se almacena en una variable
        selectedOption = Request.QueryString("option")
        Select Case selectedOption
            Case "personal"
                service.updateClient(clientTemp.IdUser, txtFirstName.Text, txtFirstLastName.Text, txtSecondLastName.Text, clientTemp.NameUser,
                                     clientTemp.PasswordUser, txtEmail.Text, clientTemp.NumberCard, clientTemp.AddressDirection,
                                     clientTemp.PostalCode, clientTemp.SvcCard)
                exitMessage.Style.Add("display", "initial")
            Case "address"
                service.updateClient(clientTemp.IdUser, clientTemp.Name, clientTemp.LastName_1, clientTemp.LastName_2, clientTemp.NameUser,
                                     clientTemp.PasswordUser, clientTemp.Email, clientTemp.NumberCard, txtAddressDirection.Text,
                                     txtPostalCode.Text, clientTemp.SvcCard)
                exitMessage.Style.Add("display", "initial")
            Case "card"
                service.updateClient(clientTemp.IdUser, clientTemp.Name, clientTemp.LastName_1, clientTemp.LastName_2, clientTemp.NameUser,
                                     clientTemp.PasswordUser, clientTemp.Email, txtNumberCard.Text, clientTemp.AddressDirection,
                                     clientTemp.PostalCode, txtsvcCard.Text)
                exitMessage.Style.Add("display", "initial")
        End Select
    End Sub
End Class