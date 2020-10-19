<%@ Page Title="home page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
      <td>
          <asp:ImageButton ID="ImageButton1" width="120" height="120" runat="server" ImageUrl="https://neoattack.com/wp-content/uploads/2017/06/carrito-compra-1024x1024.png" /> <%--OnClick="ImageButton1_Click" />--%>
      </td>


   <div class="container-fluid">
        <div class="row" style="margin-bottom:10px">
            <div class="col-md-12">
                <h1>Lista de Productos</h1>
                    <div class="form-group">

                         <% foreach (Dominio.Articulo item in listaArticulos)
                        { %>
                        <div class="col-12 col-sm-4">
                            <div class="card">
                                <img src="<%=item.imagen %>" width="200" height="200" class="card-img-top" alt="...">

                                <div class="card-body">

                                   <h5 class="card-title"><% =item.nombre%> </h5>
                                   <h5 class="card-title"><% =item.precio%> </h5>
                                </div>
                               <%-- <asp:Button class ="btn btn-primary" ID="btnAgregar" onClick="btnAgregar_Click" runat="server" Text="Agregar" />--%>
                                <a href="Detalle.aspx?idArticulo=<%=item.id.ToString() %>" class ="btn btn-primary">Detalle</a>
                                <%-- no debe tener espacios  el href si no te manda error de objeto no instanciado--%>
                                <hr/>
                             </div>
                       </div>
                    <%} %>
                  </div>
               
            </div>
         </div>
      </div>

</asp:Content>
