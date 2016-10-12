Public Class Client
    ' Declaración de las instancias
    Private nameValue As String
    Private lastNameFirstValue As String
    Private lastNameSecondValue As String
    Private nameuserValue As String
    Private passwordValue As String
    Private emailValue As String
    Private numberCardValue As String
    Private addressDirectionValue As String
    Private postalCodeValue As String
    Private svcCardValue As String

    ' Propiedad para el nombre
    Public Property Name() As String
        Get
            Name = nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property

    ' Propiedad para el apellido 1
    Public Property LastNameFirst() As String
        Get
            LastNameFirst = lastNameFirstValue
        End Get
        Set(ByVal value As String)
            lastNameFirstValue = value
        End Set
    End Property

    ' Propiedad para el apellido 2
    Public Property LastNameSecond() As String
        Get
            LastNameSecond = lastNameFirstValue
        End Get
        Set(ByVal value As String)
            lastNameSecondValue = value
        End Set
    End Property

    ' Propiedad para el nombre de usuario
    Public Property NameUser() As String
        Get
            NameUser = nameuserValue
        End Get
        Set(ByVal value As String)
            nameuserValue = value
        End Set
    End Property

    ' Propiedad para la contraseña
    Public Property Password() As String
        Get
            Password = passwordValue
        End Get
        Set(ByVal value As String)
            passwordValue = value
        End Set
    End Property

    ' Propiedad para el correo
    Public Property Email() As String
        Get
            Email = emailValue
        End Get
        Set(ByVal value As String)
            emailValue = value
        End Set
    End Property

    ' Propiedad para el número de tarjeta
    Public Property NumberCard() As String
        Get
            NumberCard = numberCardValue
        End Get
        Set(ByVal value As String)
            numberCardValue = value
        End Set
    End Property

    ' Propiedad para la dirección
    Public Property AddressDirection() As String
        Get
            AddressDirection = addressDirectionValue
        End Get
        Set(ByVal value As String)
            addressDirectionValue = value
        End Set
    End Property

    ' Propiedad para el código postal
    Public Property PostalCode() As String
        Get
            PostalCode = postalCodeValue
        End Get
        Set(ByVal value As String)
            postalCodeValue = value
        End Set
    End Property

    ' Propiedad para el svcCard
    Public Property SvcCard() As String
        Get
            SvcCard = svcCardValue
        End Get
        Set(ByVal value As String)
            svcCardValue = value
        End Set
    End Property
End Class