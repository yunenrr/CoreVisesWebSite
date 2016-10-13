Public Class Principal
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If CType(Session("condition"), Integer) = 0 Then
            logInf.NavigateUrl = "~/login.aspx"
            logInf.Text = "Log In"
        ElseIf CType(Session("condition"), Integer) = 1 Then
            logInf.Text = "Exit"
        End If
    End Sub

End Class