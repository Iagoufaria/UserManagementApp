@ModelType IndexViewModel
@Code
    ViewBag.Title = "Painel de controle"
End Code

<!DOCTYPE html>
<html lang="pt">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    <style>
        .dashboard-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #f8f9fa;
            border-radius: 8px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

            .dashboard-container h2, .dashboard-container h4 {
                text-align: center;
                margin-bottom: 20px;
            }

        .account-settings {
            padding: 20px;
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

            .account-settings dt {
                font-weight: bold;
                margin-bottom: 5px;
            }

            .account-settings dd {
                margin-bottom: 15px;
            }

        .action-link {
            color: #007bff;
            text-decoration: none;
        }

            .action-link:hover {
                text-decoration: underline;
            }

        .status-message {
            text-align: center;
            margin-bottom: 20px;
        }
    </style>
</head>
<body>

    <div class="dashboard-container">
        <h2>@ViewBag.Title</h2>

        <p class="text-success status-message">@ViewBag.StatusMessage</p>

        <div class="account-settings">
            <h4>Gerencie as configurações da conta</h4>
            <hr />
            <dl class="row">
                <dt class="col-sm-4">Senha:</dt>
                <dd class="col-sm-8">
                    @If Model.HasPassword Then
                        @Html.ActionLink("Alterar sua senha", "ChangePassword", Nothing, New With {.class = "action-link"})
                    Else
                        @Html.ActionLink("Criar", "SetPassword", Nothing, New With {.class = "action-link"})
                    End If
                </dd>
            </dl>
        </div>
    </div>

    @Section Scripts
        <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
    End Section

</body>
</html>
