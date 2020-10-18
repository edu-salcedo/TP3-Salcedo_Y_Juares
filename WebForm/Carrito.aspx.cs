using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class Carrito : System.Web.UI.Page
    {
        public Articulo articuloAgregado { get; set; }
        public List<Articulo> listaArticulosCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //  artDetalle = ((List<Articulo>)Session.Contents["ListaArticulos"]).Find(X => X.id.ToString().Contains(idItem));
                listaArticulosCarrito = negocio.listar();
                int idaux = Convert.ToInt32(Request.QueryString["idArticuloAgregado"]);
                articuloAgregado = listaArticulosCarrito.Find(x => x.id == idaux);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}