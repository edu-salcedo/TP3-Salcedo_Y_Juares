<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <table class="table table-dark">
        <thead>
          <tr>
              <th scope="col">Imagen </th>
              <th scope="col">Articulo</th>
              <th scope="col">Importe</th>           
          </tr>
       </thead>
    <%foreach(Dominio.Articulo item in carritoCompra)
      { %>
         
            <tbody>
                <tr>
                    <td><img src="<%=item.imagen %>" alt="<%=item.imagen %>" width="100" height="100"></td>
                    <td><%=item.nombre %></td>
                    <td><%=item.precio %></td>
               </tr>
           </tbody>   

    <%}%>
   </table> 
</asp:Content>
