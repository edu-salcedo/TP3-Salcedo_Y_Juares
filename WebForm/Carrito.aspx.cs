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
        public Articulo articuloNuevo { get; set; }
        public List<Articulo> carritoCompra = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            int idArticulo = Convert.ToInt32(Session["idart"]);   //convierto el id del articulo  seleccionado en detalle.aspx para comprar

            try
            {
                if (idArticulo != 0)
                {
                    carritoCompra = new List<Articulo>();
                    articuloNuevo = new Articulo();
                    ArticuloNegocio auxNegocio = new ArticuloNegocio();
                    articuloNuevo = auxNegocio.listar().Find(x => x.id == idArticulo);
                }
                if (Session["carrito"] != null)
                {
                    carritoCompra = (List<Articulo>)Session["carrito"];
                }

                carritoCompra.Add(articuloNuevo);    //se agrega el articulo seleccionado a la lista carrito
                Session.Add("carrito", carritoCompra);       //se agrega a la session "carrito" la lista carrito 
            }
            catch (Exception)
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}