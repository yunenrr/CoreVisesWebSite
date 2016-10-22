Public Class ExceptionMessage
    'Declaración de variables globales
    Private message As String
    ''' <summary>
    ''' Función constructora
    ''' </summary>
    Public Sub New()
        Me.message = ""
    End Sub
    ''' <summary>
    ''' Función que retorna un mensaje, se va a mostrar cuando no hay conexión con el web service
    ''' </summary>
    ''' <returns>
    ''' Un mensaje indicando que no se ha podido establecer conexión con el servidor
    ''' </returns>
    Public Function notConnectionWS() As String
        Me.message = "No connection to the web service"
        Return Me.message
    End Function
End Class
