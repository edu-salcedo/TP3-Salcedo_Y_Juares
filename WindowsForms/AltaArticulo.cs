using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Dominio;

namespace WindowsForms
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            DArticulo dArticulo = new DArticulo();

            nuevo.codigo = txtCodigo.Text;
            nuevo.nombre = txtNombre.Text;
            nuevo.descripcion = txtDescripcion.Text;
            nuevo.marca = (Marca)cboMarca.SelectedItem;
            nuevo.categoria = (Categoria)cboCategoria.SelectedItem;
            nuevo.imagenURL = txtImagenURL.Text;
            nuevo.precio = decimal.Parse(txtPrecio.Text);

            dArticulo.alta(nuevo);

            MessageBox.Show("Articulo agregado");
            Close();

        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            DMarca marca = new DMarca();

            cboMarca.DataSource = marca.listar();

            DCategoria categoria = new DCategoria();

            cboCategoria.DataSource = categoria.listar();
        }
    }
}
