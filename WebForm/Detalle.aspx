<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>
<asp:Content ID="content2" ContentPlaceHolderID="MainContent" runat="server">

  <% Dominio.Articulo item = artDetalle;%>
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

                        <asp:Button class ="btn btn-primary" ID="btnAgregar" onClick="btnAgregar_Click" runat="server" Text="Agregar" />
                        
                        <a href="Default.aspx" class ="btn btn-primary">Catalogo</a>
                       <asp:Label ID="lbAgregado" runat="server" Text=""></asp:Label>
 
                    </div>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>

