Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Aplicacion creada por Kevin Villalobos"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Kevin Villalobos"

        Return View()
    End Function
End Class
