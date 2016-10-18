Public Class allProducts
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None

        'Pregunta que si es la primera ves en entrar
        If Not IsPostBack Then
            Dim servicebrand As New BrandServiceReference.BrandServiceClient
            Dim brands As New List(Of BrandServiceReference.Brand)
            brands.Add(servicebrand.getAllBrands().)

            For Each temporal As BrandServiceReference.Brand In brands
                ddlBrand.Items.Add(temporal.Name)
            Next

            'Dim cont As Integer = 0
            ' For Each t As BrandServiceReference.Brand In brands
            'ddlBrand.Items.Insert(cont, t.Name)
            'cont = cont + 1
            ' Next

        End If
    End Sub

End Class