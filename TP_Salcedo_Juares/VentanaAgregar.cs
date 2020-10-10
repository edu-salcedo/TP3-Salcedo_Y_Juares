using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP_Salcedo_Juares
{
    public partial class VentanaAgregar : Form
    {
        private Articulo articulo = null;
        public VentanaAgregar()
        {
            InitializeComponent();

        }
        public VentanaAgregar(Articulo arti)
        {
            InitializeComponent();
            articulo = arti;
        }


        private void VentanaAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            cbMarca.DataSource = marca.listar();    // llena el comno box con la lista de marcas
            cbMarca.ValueMember = "id";
            cbMarca.DisplayMember = "nombre";
            cbMarca.SelectedIndex = -1;

            CategoriaNegocio cat = new CategoriaNegocio();
            cbCategoria.DataSource = cat.listar();    // llena el comno box con la lista de categorias
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.SelectedIndex = -1;

            if (articulo != null)

            {
                
                texNombre.Text = articulo.nombre;
                texCodigo.Text = articulo.codigo;
                textDescripcion.Text = articulo.descripcion;
                texImagen.Text = articulo.imagen;
                texPrecio.Text = Convert.ToString(articulo.precio);

                cbMarca.SelectedValue = articulo.marca.id;
                cbCategoria.SelectedValue = articulo.categoria.id;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio darti = new ArticuloNegocio();
            if (articulo == null) articulo = new Articulo();
          
                articulo.codigo = texCodigo.Text;                // se asigna el codigo que ingreso en texbox
                articulo.nombre = texNombre.Text;               //      "        nombre  "     "      "
                articulo.imagen = texImagen.Text;
                articulo.descripcion = textDescripcion.Text;    //      "        descripcion   "     "      "
                articulo.marca = (Marca)cbMarca.SelectedItem;
                articulo.categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.precio = decimal.Parse(texPrecio.Text);
            

            if (articulo.id == 0)
            {
                darti.agregar(articulo);                   //  se llama funcion agregar y se manda parametro articulo con los valores ingresados
            }
            else
            {
                darti.editar(articulo);                    //se llama funcion etitar
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
