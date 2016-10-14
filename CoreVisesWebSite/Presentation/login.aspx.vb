Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
    End Sub

    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs)
        If (txtNameUser.Text = "Yunen") And (txtPassword.Text = "12345") Then
            Session.Item("condition") = 1
            Response.Redirect("../index.aspx")
        End If
    End Sub
End Class