Public Class register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
        wrongMessage.Style.Add("display", "none")
    End Sub

    Protected Sub btnRegister_Click(sender As Object, e As EventArgs)
        Dim service As New ClientServiceReference.ClientServiceClient
        Dim tempValue As Integer
        tempValue = service.verifyExistsClient(txtNameUser.Text, txtRPassword.Text)

        ' Si es igual a cero es porque no existe
        If (tempValue = 0) Then
            service.insertClient(0, txtFirstName.Text, txtFirstLastName.Text, txtSecondLastName.Text,
                     txtNameUser.Text, txtRPassword.Text, txtEmail.Text, txtNumberCard.Text,
                     txtAddressDirection.Text, txtPostalCode.Text, txtsvcCard.Text)
            wrongMessage.Style.Add("display", "none")
            MyClass.Response.Redirect("~/Presentation/login.aspx")
        Else
            wrongMessage.Style.Add("display", "initial")
        End If
    End Sub
End Class