@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>Login App</h1>
    <p class="lead">Aplicativo de login desenvolvido para o teste técnico para a vaga de estágio na manga tecnologia</p>
    <p>@Html.ActionLink("Registrar-se", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</p>
</div>
