Imports System.Text
Imports System.Data
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Testing.cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos


<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        'Prueba de consumir el web service del banco de costa rica
        'Dim indicador As New cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos()
        'Dim tipoCambio As New DataSet
        'tipoCambio = indicador.ObtenerIndicadoresEconomicos("318", Today.ToShortDateString, Today.ToShortDateString, "WebSite", "N")
        ''Console.Write(Today.ToShortDateString)
        'Console.Write(Double.Parse(tipoCambio.Tables(0).Rows(0).ItemArray(2).ToString))

        Dim temp As Double = 3000.0129
        Dim dollar As Double = 559.12
        Dim suma As Double = (temp / dollar)
        Console.Write(FormatNumber(suma, 2))
    End Sub

End Class