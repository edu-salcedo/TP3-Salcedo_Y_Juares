<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebForm.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <hr />
    <hr />
    <hr />
    <div class="card text-center">

    </div>
        <table class="table table-dark">
           
          <thead>
             <tr>
                <th scope="col"> </th>
                <th scope="col"> Codigo</th>
                <th scope="col">Nombre</th>
                <th scope="col">Precio</th> 
            </tr>
                 
         </thead>
             
    <%foreach(Dominio.Articulo item in carritoCompra)
      { %>
         
            <tbody>
                <tr>
                    <td><img src="<%=item.imagen %>" alt="<%=item.imagen %>" width="100" height="100"></td>
                    <td> <b><%=item.codigo %> </b></td>
                    <td><%=item.nombre %></td>
                    <td><%=item.precio %></td>
                    <td><a class="btn btn-warning" href="Carrito.aspx?idCancelar=<%= item.id %>" role="button">Cancelar</a></td> 

               </tr>
           </tbody>   
    <%}%>
   </table> 
 

    <div>

       <h3 style="font-family:'Arial Rounded MT'">total : $<asp:Label ID="lbtotal" Text="" runat="server" /></h3>

    </div>
    <hr>
    <a href="Default.aspx" class ="btn btn-secondary btn lg">Ver mas Articulos</a>
</asp:Content>
