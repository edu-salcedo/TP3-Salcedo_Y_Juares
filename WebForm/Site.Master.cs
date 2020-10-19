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
    public partial class SiteMaster : MasterPage
    {
        public List<Dominio.Articulo> listaCarrito = null;
        public string debuger;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux;
            try
            {
                listaAux = negocio.listar();
                int idArticulo = listaAux.Find(x => x.nombre.ToLower().Contains(TexBuscar.Text.ToLower())).id;


                Response.Redirect("Detalle.aspx?idArticulo=" + idArticulo.ToString());
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}