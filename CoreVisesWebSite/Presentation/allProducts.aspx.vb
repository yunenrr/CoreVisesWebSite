Public Class allProducts
    Inherits System.Web.UI.Page
    Public servicePhone

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None

        'Pregunta que si es la primera ves en entrar
        If Not IsPostBack Then
            Dim servicebrand As New BrandServiceReference.BrandServiceClient
            servicePhone = New PhoneServiceReference.PhoneServiceClient
            Dim temp As String = servicebrand.getAllBrands
            Dim brand As Array = temp.Split("#")

            For Each brandT As String In brand
                Dim currentBrand As Array
                currentBrand = brandT.Split(";")

                If (currentBrand(0).ToString.Length > 0) Then
                    ddlBrand.Items.Add(currentBrand(1).ToString)
                End If
            Next
        End If
    End Sub

End Class