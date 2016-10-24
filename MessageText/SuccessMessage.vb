Public Class SuccessMessage
    'Declaración de variables globales
    Private message As String
    ''' <summary>
    ''' Función constructora
    ''' </summary>
    Public Sub New()
        Me.message = ""
    End Sub
    ''' <summary>
    ''' Función que le indica al usuario que ha sido actualizado
    ''' </summary>
    ''' <returns>
    ''' Un mensaje
    ''' </returns>
    Public Function successUpdate() As String
        Me.message = "Successfully updated"
        Return Me.message
    End Function

    Public Function successAdd() As String
        Me.message = "It has been successful to cart!"
        Return Me.message
    End Function
End Class
