Public Class EncryptionMethods
    Private alphabet As String

    Private alphabetChar As Char()

    Public Sub New()
        Me.alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.:;/-_%!¿?$#[]{} "
        Me.alphabetChar = alphabet.ToCharArray()
    End Sub

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

    Private Function findLetter(letter As Char) As Integer
        Dim pos As Integer = 0

        For i As Integer = 0 To Me.alphabet.Length - 1
            If letter = alphabetChar(i) Then
                pos = i + 1
                i = Me.alphabet.Length
            End If
        Next

        Return pos
    End Function

End Class