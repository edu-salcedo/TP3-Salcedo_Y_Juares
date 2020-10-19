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

            carritoCompra = new List<Articulo>();
            int idArticulo = Convert.ToInt32(Request.QueryString["idArticulo"]);
            bool quitar = Convert.ToBoolean(Request.QueryString["quitar"]);

            if (Session["carrito"] == null)    //si la seccion no tiene la lista de articulos  se le agrega una
            {
                Session.Add("carrito", new List<Articulo>());

            }


            if (idArticulo != 0 )
            {
                try
                {
                    articuloNuevo = new Articulo();
                    ArticuloNegocio auxNegocio = new ArticuloNegocio();
                    articuloNuevo = auxNegocio.listar().Find(x => x.id == idArticulo);  //sender le asigna a la variable articulonuevo  el id encontrado
                    carritoCompra = (List<Articulo>)Session["carrito"];
                    carritoCompra.Add(articuloNuevo);
                    Session.Add("carrito", carritoCompra);             //agregamos a la seccion "carrito" la lista con el nuevo articulo 

                }
                catch (Exception)
                {
                    Response.Redirect("Default.aspx");

                }

            }
           
            else
            {
                try
                {

                    carritoCompra = (List<Articulo>)Session["carrito"];

                }
                catch (Exception)
                {
                    Response.Redirect("Default.aspx");

                }
            }
        }
    }
}