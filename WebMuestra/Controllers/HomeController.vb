Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Descripción acerda del sitio."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Página de contacto."

        Return View()
    End Function
End Class
