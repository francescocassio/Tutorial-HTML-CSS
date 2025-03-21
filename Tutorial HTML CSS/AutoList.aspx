<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutoList.aspx.cs" Inherits="AutoList" %>

<!DOCTYPE html>
<html lang="it">
<head runat="server">
    <title>Lista Automobili</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h2>Lista Automobili</h2>
            <div class="row">
                <% foreach (var auto in ListaAuto) { %>
                    <div class="col-md-4 mb-4">
                        <div class="card shadow">
                            <div class="card-body">
                                <h5 class="card-title"><%= auto.Marca %> - <%= auto.Modello %></h5>
                                <p class="card-text">Targa: <strong><%= auto.Targa %></strong></p>
                            </div>
                        </div>
                    </div>
                <% } %>
            </div>
        </div>
    </form>
</body>
</html>
