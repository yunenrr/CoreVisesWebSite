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
    ''' Función que muestra un mensaje indicando que no hubo conexión con el web service.
    ''' </summary>
    ''' <returns>
    ''' Un mensaje
    ''' </returns>
    Public Function notConnectionWS() As String
        Me.message = "No connection to the web service."
        Return Me.message
    End Function
    ''' <summary>
    ''' Función que muestra un mensaje indicando que el cliente no existe en el sistema
    ''' </summary>
    ''' <returns>
    ''' Un mensaje
    ''' </returns>
    Public Function clientNoExist() As String
        Me.message = "The client entered does not exist in our system."
        Return Me.message
    End Function
    ''' <summary>
    ''' Función que muestra un mensaje indicando que el cliente ya está registrado en el sistema
    ''' </summary>
    ''' <returns>
    ''' Un mensaje
    ''' </returns>
    Public Function clientExist() As String
        Me.message = "The client already exists in the system."
        Return Me.message
    End Function
End Class
