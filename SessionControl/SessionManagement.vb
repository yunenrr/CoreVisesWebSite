Public Class SessionManagement

    'Declaración de variables globales
    Private key As String
    Private condition As String

    Public Sub New()
        'Preguntamos si el mae está o no logueado
        If Session.Item("user") Is Nothing Then
            Me.key = "None"
        Else
            Me.key = CType(Session("user"), String)
        End If

        Me.condition = ""
    End Sub
End Class
