Imports System
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Protected Sub ASPxCardView1_CommandButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxCardViewCommandButtonEventArgs)
        If e.ButtonType = CardViewCommandButtonType.SelectCheckbox Then
            e.Visible = Not chkDisabled.Checked
        End If
    End Sub
End Class