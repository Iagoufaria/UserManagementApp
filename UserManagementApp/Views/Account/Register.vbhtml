@ModelType RegisterViewModel
@Code
    ViewBag.Title = "Cadastrar"
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    <style>
        .register-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #f8f9fa;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

            .register-container h2, .register-container h4 {
                text-align: center;
                margin-bottom: 30px;
            }

        .btn-register {
            background-color: #007bff;
            color: white;
            width: 100%;
            transition: background-color 0.3s;
        }

            .btn-register:hover {
                background-color: #0056b3;
            }


        .mb-3{
            margin-left: 15rem;
            margin-bottom: 1rem;
        }
    </style>
</head>
<body>

    <div class="register-container">
        <h2>@ViewBag.Title</h2>
        <h4>Crie sua nova conta</h4>
        @Using Html.BeginForm("Register", "Account", FormMethod.Post, New With {.class = "needs-validation", .novalidate = "true"})

            @Html.AntiForgeryToken()

            @<text>
                
                <hr />
                @Html.ValidationSummary("", New With {.class = "text-danger"})

                <div class="mb-3">
                    @Html.LabelFor(Function(m) m.Email, New With {.class = "form-label"})
                    @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control", .required = "required"})
                    <div class="invalid-feedback">
                        Insira um email valido
                    </div>
                </div>

                <div class="mb-3">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "form-label"})
                    @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control", .required = "required"})
                    <div class="invalid-feedback">
                        Insira sua senha
                    </div>
                </div>

                <div class="mb-3">
                    @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "form-label"})
                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control", .required = "required"})
                    <div class="invalid-feedback">
                        Confirme sua senha
                    </div>
                </div>

                <div class="d-grid gap-2">
                    <button type="submit" class="btn btn-register">Cadastrar</button>
                </div>
            </text>

        End Using
    </div>

    @section Scripts
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
