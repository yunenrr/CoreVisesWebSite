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
    ''' <summary>
    ''' Función que retorna un mensaje de agregado al carrito
    ''' </summary>
    ''' <returns>
    ''' Mensaje indicando que ha sido agregado exitosamente al carrito
    ''' </returns>
    Public Function successAdd() As String
        Me.message = "It has been successful to cart!"
        Return Me.message
    End Function
    ''' <summary>
    ''' Función que retorna un mensaje de comrpa exitosa
    ''' </summary>
    ''' <returns>
    ''' Mensaje indicando que la compra se ha realizado exitosamente
    ''' </returns>
    Public Function successPurchase() As String
        Me.message = "Purchase made successfully!"
        Return Me.message
    End Function
End Class
