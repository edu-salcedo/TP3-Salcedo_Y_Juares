<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <hr />
   <h1>

   </h1>

    <table class="table table-dark">
        <thead>
          <tr>
              <th scope="col"> </th>
              <th scope="col">Codigo</th>
              <th scope="col">Nombre</th>
              <th scope="col">Precio</th> 
          </tr>
       </thead>
    <%foreach(Dominio.Articulo item in carritoCompra)
      { %>
         
            <tbody>
                <tr>
                    <td><img src="<%=item.imagen %>" alt="<%=item.imagen %>" width="100" height="100"></td>
                    <td><%=item.codigo %></td>
                    <td><%=item.nombre %></td>
                    <td><%=item.precio %></td>
                    <td><a class="btn btn-primary btn-lg" href="Carrito.aspx?idCancelar=<%= item.id %>" role="button">Cancelar</a></td> 

               </tr>
           </tbody>   
    <%}%>
   </table> 
</asp:Content>
