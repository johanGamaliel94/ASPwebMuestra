@Code
    ViewBag.Title = "Confirm Email"
End Code

<h2>@ViewBag.Title.</h2>
<div>
    <p>
        Gracias por confirmar tu email, @Html.ActionLink("Da click aquí para iniciar sesión", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
