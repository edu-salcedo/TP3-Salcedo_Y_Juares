<%@ Page Title="home page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div class="card text-center">
         <img src="https://geckocr.com/wp-content/uploads/2018/07/Tienda-Online.png" id="imagencarro">
    </div>
    <hr />
 <div class="row">
         <% if (listaArticulos.Count == 0)
            {%>
                <h3 style="color:white; margin-left: 1vw; ">No hay articulos que coincidan con tu busqueda.</h3>
           <% }
       
        foreach (Dominio.Articulo item in listaArticulos)
            { %>
        <div class="col-xs-12 col-sm-4 col-md-3" style="margin-bottom: 1vw;">
            <div class="card text-center h-100 textodiv">
                <div class="card-body d-flex flex-column">
                     <img src="<%=item.imagen%>" style="max-height: 10vw; max-width: 10vw; margin: 3vw;" />
                    <h4 class="card-title"> <b ><%= item.nombre %></b></h4>
                    <h5 class="card-title"><%= item.marca %></h5>
                    <h5 class="card-title">$<%= item.precio %></h5>
                    <a href="Carrito.aspx?idArticulo=<%=item.id.ToString() %>" class="btn btn-success">Agregar</a>
                    <br />
                    <a href="Detalle.aspx?idArticulo=<%=item.id.ToString() %>" class ="btn btn-info">Detalle</a>
                     <%-- no debe tener espacios  el href si no te manda error de objeto no instanciado--%>
                </div>
            </div>
         </div>
        <% } %>
     </div>
</asp:Content>
