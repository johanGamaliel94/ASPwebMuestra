Imports System.Data.Entity

Namespace Models
    Public Class Usuario
        Public Property ID As Integer
        Public Property nombreCompleto As String
        Public Property correo As String
    End Class

    Public Class UsuarioDbContext
        Inherits DbContext
        Public Property Usuarios As DbSet(Of Usuario)
    End Class
End Namespace
