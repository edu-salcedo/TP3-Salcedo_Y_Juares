<%@ Page Title="home page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <%--  <div class="container">

        <header class="container-header">
            <div class="row">
                <div class="col-sm-3 container">
                    <asp:Image ID="logo" CssClass="imalogo" runat="server" />
                </div>
                <div class="col-sm-6 container">
                    <nav class="navbar navbar-expand-lg navbar-light bg-light">
                        
                        <asp:TextBox ID="TbxFiltro" CssClass="form-control mr-sm-2" placed runat="server"></asp:TextBox>

                        <asp:Button ID="btnBuscar" CssClass="btn btn-outline-success " runat="server" Text="Buscar" />
                    </nav>

                </div>
            </div>
        </header>

    </div>--%>

    <section class="container">

        <div class="row">
            <div class="col-sm-12">
                
                    <div class="card-columns">
                          <% foreach (Dominio.Articulo item in listaArticulos)
                              { %>
                              <div class="card">
                                   <img src="<%=item.imagen %>" width="200" height="200" class="card-img-top" alt="...">
            
                                   <asp:Button ID="Button1" runat="server" Text="Agregar" />
                                   <asp:Button ID="Button2" runat="server" Text="Ver Detalles" />
                                   <div class="card-body">
                                     <h5 class="card-title"><% =item.nombre%> </h5>
                                     <h5 class="card-title"><% =item.precio%> </h5>

                                   </div>
                             </div>
                           <%} %>
                    </div> 
                

            </div>
        </div>
    </section>




<%--    <seccion class="container-section-articulos">

         <div>class ="row"

           <div>class ="col-sm-12"
       
              <% foreach (Dominio.Articulo item in listaArticulos)
                 { %>
                     <div class="card-columns">
                              <div class="card">
                                   <img src="<%=item.imagen %>" width="200" height="200" class="card-img-top" alt="...">
            
                                   <asp:Button ID="Button1" runat="server" Text="Agregar" />
                                   <asp:Button ID="Button2" runat="server" Text="Ver Detalles" />
                                   <div class="card-body">
                                     <h5 class="card-title"><% =item.nombre%> </h5>
                                     <h5 class="card-title"><% =item.precio%> </h5>
               
                               </div>
                      </div>
                <%} %>

             </div>
        </div>
        </div>
    </secction>--%>


   
</asp:Content>
