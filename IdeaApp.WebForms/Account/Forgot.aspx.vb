Imports System
Imports System.Web
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Owin

Partial Public Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Property StatusMessage() As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub Forgot(sender As Object, e As EventArgs)
        If IsValid Then
            ' 사용자의 전자 메일 주소 확인
            Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
            Dim user As ApplicationUser = manager.FindByName(Email.Text)
            If user Is Nothing OrElse Not manager.IsEmailConfirmed(user.Id) Then
                FailureText.Text = "사용자가 없거나 확인되지 않았습니다."
                ErrorMessage.Visible = True
                Return
            End If
            ' 계정 확인 및 암호 재설정을 사용하도록 설정하는 방법에 대한 자세한 내용은 https://go.microsoft.com/fwlink/?LinkID=320771을 참조하세요.
            ' 암호 재설정 페이지에 대한 코드 및 리디렉션이 포함된 전자 메일 보내기
            ' Dim code = manager.GeneratePasswordResetToken(user.Id)
            ' Dim callbackUrl = IdentityHelper.GetResetPasswordRedirectUrl(code, Request)
            ' manager.SendEmail(user.Id, "암호 재설정", "다음을 클릭하여 암호를 재설정하십시오. <a href=""" & callbackUrl & """>여기</a>")
            loginForm.Visible = False
            DisplayEmail.Visible = True
        End If
    End Sub
End Class