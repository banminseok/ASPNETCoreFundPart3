Imports System
Imports System.Linq
Imports System.Web
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Owin

Partial Public Class ResetPassword
    Inherits System.Web.UI.Page

    Protected Property StatusMessage() As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub Reset_Click(sender As Object, e As EventArgs)
        Dim code As String = IdentityHelper.GetCodeFromRequest(Request)
        If code IsNot Nothing Then
            Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
            Dim user = manager.FindByName(Email.Text)
            If user Is Nothing Then
                ErrorMessage.Text = "사용자를 찾을 수 없습니다."
                Return
            End If
            Dim result = manager.ResetPassword(user.Id, code, Password.Text)
            If result.Succeeded Then
                Response.Redirect("~/Account/ResetPasswordConfirmation")
                Return
            End If
            ErrorMessage.Text = result.Errors.FirstOrDefault()
            Return
        End If

        ErrorMessage.Text = "오류가 발생했습니다."
    End Sub
End Class