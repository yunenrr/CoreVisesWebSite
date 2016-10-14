Public Class update
    Inherits System.Web.UI.Page
    Dim selectedOption
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None

        If Request.QueryString("option") Is Nothing Then
            dontSelect.Style.Add("display", "initial")
        End If
        hiddenAll()
        showDiv()
    End Sub
    ' Función que oculta todos los elementos
    Function hiddenAll()
        dontSelect.Style.Add("display", "none")
        uAddress.Style.Add("display", "none")
        uPersonal.Style.Add("display", "none")
        uPassword.Style.Add("display", "none")
        uCard.Style.Add("display", "none")
        btnUpdate.Visible = False
    End Function
    ' Función para mostrar el elemento seleccionado
    Function showDiv()
        ' Se recupera el valor de la URL, y se almacena en una variable
        selectedOption = Request.QueryString("option")
        Select Case selectedOption
            Case "personal"
                uPersonal.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case "address"
                uAddress.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case "password"
                uPassword.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case "card"
                uCard.Style.Add("display", "initial")
                btnUpdate.Visible = True
            Case Else
                dontSelect.Style.Add("display", "initial")
        End Select
    End Function
End Class