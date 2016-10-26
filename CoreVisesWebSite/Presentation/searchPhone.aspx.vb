Public Class searchPhone
    Inherits System.Web.UI.Page
    Public key As String
    Public priceDollar As Double

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Preguntamos si el mae está o no logueado
        If Session.Item("user") Is Nothing Then
            Me.key = "None"
        Else
            Me.key = CType(Session("user"), String)
        End If

        'Preguntamos si tenemos el precio del dolar
        If Session.Item("dollar") Is Nothing Then
            Me.priceDollar = 500
        Else
            Me.priceDollar = CType(Session("dollar"), Double)
        End If
    End Sub
End Class