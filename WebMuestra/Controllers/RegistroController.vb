Imports System.Web.Mvc

Namespace Controllers
    Public Class RegistroController
        Inherits Controller

        ' GET: Registro
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Registro/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Registro/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Registro/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Registro/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Registro/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Registro/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Registro/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace