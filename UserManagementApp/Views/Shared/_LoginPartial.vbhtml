﻿@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With { .id = "logoutForm", .class = "navbar-right" })
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-right">
            <li>
                @Html.ActionLink("Bem vindo, " + User.Identity.GetUserName() + " !", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage"})
            </li>
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Desconectar</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
        <li>@Html.ActionLink("Registrar", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues := Nothing, htmlAttributes := New With { .id = "loginLink" })</li>
    </ul>
End If

