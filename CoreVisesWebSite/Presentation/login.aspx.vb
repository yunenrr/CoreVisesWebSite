﻿Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyClass.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
        wrongMessage.Style.Add("display", "none")

        If Not (Request.QueryString("exit") Is Nothing) Then
            Session.Item("condition") = 0
            Response.Redirect("../index.aspx")
        End If
    End Sub

    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs)
        Dim service As New ClientServiceReference.ClientServiceClient
        Dim tempValue As Integer
        tempValue = service.verifyExistsClient(txtNameUser.Text, txtPassword.Text)

        If (tempValue <> 0) Then
            Session.Item("condition") = 1
            Session.Add("user", txtNameUser.Text)
            wrongMessage.Style.Add("display", "none")
            MyClass.Response.Redirect("~/Presentation/welcome.aspx")
        Else
            wrongMessage.Style.Add("display", "initial")
        End If
    End Sub
End Class