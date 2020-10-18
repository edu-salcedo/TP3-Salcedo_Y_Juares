<%@ Page Title="Carrito de compras" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehid="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <% Dominio.Articulo item = articuloAgregado;%>
       <div class="jumbotron">
        <h2 class="card-title"><% = item.nombre %></h2>
        <div class="row">

            <div class="col-md-4">
                <div class="card" style="width: 18rem;">
                    <img src="<%=item.imagen %>" class="card-img-top" alt="alternative-text" width="280">
                    <div class="card-body">
                       
                        <h4 class="card-title"><%= item.marca %></h4>
                        <h4 class="card-title"><%= item.descripcion %></h4>
                        <h4 class="card-title"><% = item.precio %></h4>
                     </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
