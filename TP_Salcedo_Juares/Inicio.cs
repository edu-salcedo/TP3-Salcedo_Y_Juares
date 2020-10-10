using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Salcedo_Juares
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ventana2 ven2 = new Ventana2(nombre.Text);
            ven2.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void controlbutton()
        {
            if (nombre.Text.Trim() != String.Empty && nombre.Text.All(char.IsLetter)) // si no esta vacio y todas son letras
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(char.IsLetter)))   // si no son todas letras
                {
                    errorProvider1.SetError(nombre, "el nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "tiene que ingresar un nombre");
                }
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlbutton();
        }
    
    }
}
