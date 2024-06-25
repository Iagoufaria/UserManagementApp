@ModelType LoginViewModel
@Code
    ViewBag.Title = "Log in"
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    <style>
        .login-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #f8f9fa;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

            .login-container h2, .login-container h4 {
                text-align: center;
                margin-bottom: 20px;
            }

        .btn-login {
            background-color: #007bff;
            color: white;
            width: 100%;
            transition: background-color 0.3s;
        }

            .btn-login:hover {
                background-color: #0056b3;
            }

        .form-check {
            display: flex;
            align-items: center;
        }

        body > div.container.body-content > div > div{
            display:flex;
            justify-content: center;
        }

        .mb-3{
            margin-bottom: 1rem;
        }

        #loginForm > form > div.form-check.mb-3 {
            align-items: baseline;
        }
    </style>
</head>
<body>

    <div class="login-container">
        <h2>@ViewBag.Title</h2>
        <h4>Use sua conta para realizar o login</h4>
        <div class="row">
            <div class="col-md-6 offset-md-2">
                <section id="loginForm">
                    @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "needs-validation", .novalidate = "true"})

                        @Html.AntiForgeryToken()

                        @<text>
                            
                            <hr />
                            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

                            <div class="mb-3">
                                @Html.LabelFor(Function(m) m.Email, New With {.class = "form-label"})
                                @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control", .required = "required"})
                                @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                                <div class="invalid-feedback">
                                    Insira um e-mail valido
                                </div>
                            </div>

                            <div class="mb-3">
                                @Html.LabelFor(Function(m) m.Password, New With {.class = "form-label"})
                                @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control", .required = "required"})
                                @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "text-danger"})
                                <div class="invalid-feedback">
                                    Insira sua senha
                                </div>
                            </div>

                            <div class="form-check mb-3">
                                @Html.CheckBoxFor(Function(m) m.RememberMe, New With {.class = "form-check-input"})
                                @Html.LabelFor(Function(m) m.RememberMe, New With {.class = "form-check-label"})
                            </div>

                            <div class="d-grid gap-2">
                                <button type="submit" class="btn btn-login">Log in</button>
                            </div>

                            <p class="mt-3">
                                @Html.ActionLink("Ainda não tem sua conta? Registre-se já", "Register")
                            </p>
                            @* Enable this once you have account confirmation enabled for password reset functionality
                                <p>
                                    @Html.ActionLink("Forgot your password?", "ForgotPassword")
                                </p>*@
                        </text>

                    End Using
                </section>
            </div>
        </div>
    </div>

    @Section Scripts
        <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
        <script src="~/bundles/jqueryval"></script>
        <script>
        (function () {
            'use strict';
            var forms = document.querySelectorAll('.needs-validation');
            Array.prototype.slice.call(forms).forEach(function (form) {
                form.addEventListener('submit', function (event) {
                    if (!form.checkValidity()) {
                        event.preventDefault();
                        event.stopPropagation();
                    }
                    form.classList.add('was-validated');
                }, false);
            });
        })();
        </script>
    End Section

</body>
</html>
