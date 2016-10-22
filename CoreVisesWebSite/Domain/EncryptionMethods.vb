Public Class EncryptionMethods
    ' Declaración de variables globales
    Private alphabet As String
    Private alphabetChar As Char()

    ' Método constructor
    Public Sub New()
        Me.alphabet = "abcdefghijklmnopqrstuvwxyz1234567890,.:;/@-_%!¿?$#[]{} "
        Me.alphabetChar = alphabet.ToCharArray()
    End Sub
    ' Función que encripta
    Public Function encrypt(text As String, key As String) As String
        Dim newText As String = ""

        Dim textChar As Char() = text.ToCharArray()
        Dim keyChar As Char() = key.ToCharArray()
        Dim k As Integer = 0
        Dim keyPosition As Integer = 0
        Dim letterPosition As Integer = 0
        Dim newPosition As Integer = 0
        For i As Integer = 0 To text.Length - 1
            letterPosition = findLetter(textChar(i))
            keyPosition = findLetter(keyChar(k))
            newPosition = letterPosition + keyPosition
            If newPosition > alphabet.Length Then
                newPosition = newPosition - alphabet.Length
            End If
            newText += alphabetChar(newPosition - 1)
            k += 1
            If k = key.Length Then
                k = 0
            End If
        Next

        Return newText
    End Function
    ' Función que desencripta
    Public Function decrypting(text As String, key As String) As String
        Dim newText As String = ""

        Dim textChar As Char() = text.ToCharArray()
        Dim keyChar As Char() = key.ToCharArray()
        Dim k As Integer = 0
        Dim keyPosition As Integer = 0
        Dim letterPosition As Integer = 0
        Dim newPosition As Integer = 0
        For i As Integer = 0 To text.Length - 1
            letterPosition = findLetter(textChar(i))
            keyPosition = findLetter(keyChar(k))
            newPosition = letterPosition - keyPosition
            If newPosition < 1 Then
                newPosition = alphabet.Length + newPosition
            End If
            newText += alphabetChar(newPosition - 1)
            k += 1
            If k = key.Length Then
                k = 0
            End If
        Next

        Return newText
    End Function
    ' Función que busca la posición de las palabras en nuestro abecedario
    Private Function findLetter(letter As Char) As Integer
        Dim pos As Integer = 0

        For i As Integer = 0 To Me.alphabet.Length - 1
            If Char.ToUpperInvariant(letter) = Char.ToUpperInvariant(alphabetChar(i)) Then
                pos = i + 1
                i = Me.alphabet.Length
            End If
        Next

        Return pos
    End Function
End Class
