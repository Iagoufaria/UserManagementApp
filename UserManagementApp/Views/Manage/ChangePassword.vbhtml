@ModelType ChangePasswordViewModel
@Code
    ViewBag.Title = "Alterar senha"
End Code

<!DOCTYPE html>
<html lang="pt">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    <style>
        .password-change-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #f8f9fa;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

            .password-change-container h2, .password-change-container h4 {
                text-align: center;
                margin-bottom: 20px;
            }

        .form-control {
            border-radius: 5px;
        }

        .btn-submit {
            background-color: #007bff;
            color: white;
            width: 100%;
            transition: background-color 0.3s;
        }

            .btn-submit:hover {
                background-color: #0056b3;
            }

        .text-danger {
            color: #dc3545 !important;
        }
        .mb-3{
            margin-left: 14rem;
            margin-bottom: 1rem;
        }
    </style>
</head>
<body>

    <div class="password-change-container">
        <h2>@ViewBag.Title</h2>

        @Using Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, New With {.class = "needs-validation", .novalidate = "true"})
            @Html.AntiForgeryToken()

            @<text>
                <h4>Mantenha sua conta segura</h4>
                <hr />
                @Html.ValidationSummary("", New With {.class = "text-danger"})

                <div class="mb-3">
                    @Html.LabelFor(Function(m) m.OldPassword, New With {.class = "form-label"})
                    @Html.PasswordFor(Function(m) m.OldPassword, New With {.class = "form-control", .required = "required"})
                    @Html.ValidationMessageFor(Function(m) m.OldPassword, "", New With {.class = "text-danger"})
                    <div class="invalid-feedback">
                        Por favor, insira sua senha atual.
                    </div>
                </div>

                <div class="mb-3">
                    @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "form-label"})
                    @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control", .required = "required"})
                    @Html.ValidationMessageFor(Function(m) m.NewPassword, "", New With {.class = "text-danger"})
                    <div class="invalid-feedback">
                        Por favor, insira uma nova senha.
                    </div>
                </div>

                <div class="mb-3">
                    @Html.LabelFor(Function(m) m.ConfirmPassword, New With {.class = "form-label"})
                    @Html.PasswordFor(Function(m) m.ConfirmPassword, New With {.class = "form-control", .required = "required"})
                    @Html.ValidationMessageFor(Function(m) m.ConfirmPassword, "", New With {.class = "text-danger"})
                    <div class="invalid-feedback">
                        Por favor, confirme sua nova senha.
                    </div>
                </div>

                <div class="d-grid gap-2">
                    <button type="submit" class="btn btn-submit">Alterar senha</button>
                </div>
            </text>
        End Using
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
