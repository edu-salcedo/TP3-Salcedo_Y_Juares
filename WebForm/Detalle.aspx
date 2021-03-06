﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>
<asp:Content ID="content2" ContentPlaceHolderID="MainContent" runat="server">



  <% Dominio.Articulo item = artDetalle;%>
      <div class="container">
       <div class="jumbotron">

            <h2 class="card-title"><% = item.nombre %></h2>
             <div class="row">
                <img src="<%=item.imagen %>" style="max-height: 10vw; max-width: 10vw; margin: 3vw;" >
                  <div class="card-body">
                   
                    <h4 class="card-title"><%= item.marca %></h4>
                    <h4 class="card-title"><%= item.descripcion %></h4>
                    <h4 class="card-title"><% = item.precio %></h4>

                    <a href="/Carrito.aspx?idArticulo=<% = item.id.ToString() %>" class="btn btn-success">Agregar </a>
                    
                    <a href="Default.aspx" class ="btn btn-primary">Catalogo</a>

                  </div>
              </div>
           </div>
    </div>
    

</asp:Content>

