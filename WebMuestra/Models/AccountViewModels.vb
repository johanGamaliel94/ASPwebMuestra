﻿Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
End Class

Public Class ExternalLoginListViewModel
    Public Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl As String
    Public Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider As String
    
    <Required>
    <Display(Name:="Code")>
    Public Property Code As String
    
    Public Property ReturnUrl As String
    
    <Display(Name:="Remember this browser?")>
    Public Property RememberBrowser As Boolean

    Public Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Email")>
    <EmailAddress>
    Public Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Contraseña")>
    Public Property Password As String

    <Display(Name:="Recordarme")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email As String

    <Required>
    <StringLength(100, ErrorMessage:="La {0} debe ser de al menos {2} caracteres de largo.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Contraseña")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirma tu contraseña")>
    <Compare("Password", ErrorMessage:="Las contraseñas no coinciden, verifica.")>
    Public Property ConfirmPassword As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="La {0} debe ser de al menos {2} caracteres de largo.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Contraseña")>
    Public Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirma tu contraseña.")>
    <Compare("Password", ErrorMessage:="Las contraseñas no coinciden, verifica.")>
    Public Property ConfirmPassword() As String

    Public Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String
End Class
