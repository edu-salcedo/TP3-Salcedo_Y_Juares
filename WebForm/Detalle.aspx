<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>
<asp:Content ID="content2" ContentPlaceHolderID="MainContent" runat="server">

<%--   <div class ="container">
        <div class="jumbotron">
          <img src="<%=artDetalle.imagen %>" width="200" height="200" class="card-img-top" alt="...">
         
               <h1 class ="dsiplay-4"><%=artDetalle.nombre %></h1>
        </div>
    </div>
    <asp:label id="label1" runat="server" text="label"></asp:label>--%>
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
                     </div>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>

