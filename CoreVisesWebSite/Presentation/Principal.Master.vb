Public Class Principal
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If CType(Session("condition"), Integer) = 0 Then
            logInf.NavigateUrl = "~/Presentation/login.aspx"
            logInf.Text = "Log In"
            menuController.Style.Add("display", "none")
        ElseIf CType(Session("condition"), Integer) = 1 Then
            logInf.NavigateUrl = "~/Presentation/login.aspx?exit=1"
            logInf.Text = "Exit"
            menuController.Style.Add("display", "initial")
        End If
    End Sub

End Class