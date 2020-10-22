<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebForm.Error1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lbError" runat="server" Text="Error"></asp:Label>
    <div> 
         <div>
            <section class="error-message">
                <section class="error-message-container">
                    <h1 class="animated bounce"> Lo sentimos...Cometimos un error</h1>
                    <asp:Label Text="" runat="server" ID="lblError" CssClass="clase"/>
                </section>
            </section>
            
        </div>
            <a href="Catalogo.aspx">ir al home</a>
    </div>
</asp:Content>
