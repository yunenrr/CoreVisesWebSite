Public Class welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblName.Text = CType(Session("user"), String)
    End Sub

End Class