Public Class updatePassword
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
        exitMessage.Style.Add("display", "none")
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim service As New ClientServiceReference.ClientServiceClient
        Dim clientTemp As New ClientServiceReference.Client
        clientTemp = service.getClient(CType(Session("user"), String))

        service.updateClient(clientTemp.IdUser, clientTemp.Name, clientTemp.LastName_1, clientTemp.LastName_2, clientTemp.NameUser,
                             txtRPassword.Text, clientTemp.Email, clientTemp.NumberCard, clientTemp.AddressDirection,
                             clientTemp.PostalCode, clientTemp.SvcCard)
        exitMessage.Style.Add("display", "initial")
    End Sub
End Class