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

namespace WindowsForms
{
    public partial class lista : Form
    {
        public lista()
        {
            InitializeComponent();
        }

        private void lista_Load(object sender, EventArgs e)
        {
            DArticulo arti = new DArticulo();
            dgvlista.DataSource = arti.listar();
        }

        private void dgvlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
