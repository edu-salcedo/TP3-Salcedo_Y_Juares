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
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulo artDetalle { get; set; }
        public List<Articulo> listaArticulo { get; set; }

       private int idaux;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //  artDetalle = ((List<Articulo>)Session.Contents["ListaArticulos"]).Find(X => X.id.ToString().Contains(idItem));
                listaArticulo = negocio.listar();
                idaux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                artDetalle = listaArticulo.Find(x => x.id == idaux);
            }
            catch (Exception)
            {
                Response.Redirect("Default.aspx");
            }

        }
    }
}