Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Pregunta si es la primera vez en entrar al index
        If Not IsPostBack Then
            'Pregunta si la variable condición existe en la sesión
            If Session.Item("condition") Is Nothing Then
                Session.Add("condition", 0)
                logInf.NavigateUrl = "register.html"
                logInf.Text = "Login"
            End If
        End If
    End Sub

End Class