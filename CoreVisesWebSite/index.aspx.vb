Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Pregunta si es la primera vez en entrar al index
        If Not IsPostBack Then
            'Pregunta si la variable condición existe en la sesión
            If Session.Item("condition") Is Nothing Then
                Session.Add("condition", 0)
                logInf.NavigateUrl = "~/Presentation/login.aspx"
                logInf.Text = "Log In"
            End If
        End If

        If CType(Session("condition"), Integer) = 0 Then
            logInf.NavigateUrl = "~/Presentation/login.aspx"
            logInf.Text = "Log In"
            menuController.Style.Add("display", "none") 'La otra es none
        ElseIf CType(Session("condition"), Integer) = 1 Then
            logInf.Text = "Exit"
            menuController.Style.Add("display", "initial")
        End If
    End Sub
End Class