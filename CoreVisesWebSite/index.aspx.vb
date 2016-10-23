Public Class index
    Inherits System.Web.UI.Page
    ''' <summary>
    ''' Función constructora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Pregunta si es la primera vez en entrar al index
        If Not IsPostBack Then
            'Pregunta si la variable condición existe en la sesión
            If Session.Item("condition") Is Nothing Then
                Session.Add("condition", 0)
                Session.Add("dollar", Me.getDollar())
                logInf.NavigateUrl = "~/Presentation/login.aspx"
                logInf.Text = "Log In"
            End If
        End If

        If CType(Session("condition"), Integer) = 0 Then
            logInf.NavigateUrl = "~/Presentation/login.aspx"
            logInf.Text = "Log In"
            menuController.Style.Add("display", "none") 'La otra es none
        ElseIf CType(Session("condition"), Integer) = 1 Then
            logInf.NavigateUrl = "~/Presentation/login.aspx?exit=1"
            logInf.Text = "Exit"
            menuController.Style.Add("display", "initial")
        End If
    End Sub
    ''' <summary>
    ''' Función que va y consulta en el Web Service del Banco Central de Costa Rica el precio del dolar
    ''' </summary>
    ''' <returns>
    ''' Double: Que corresponde al precio de la venta del dolar en la fecha actual
    ''' </returns>
    Private Function getDollar() As Double
        Dim indicator As New cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos()
        Dim typeChange As New DataSet
        typeChange = indicator.ObtenerIndicadoresEconomicos("318", Today.ToShortDateString, Today.ToShortDateString, "WebSite", "N")
        Return (Double.Parse(typeChange.Tables(0).Rows(0).ItemArray(2).ToString))
    End Function
End Class