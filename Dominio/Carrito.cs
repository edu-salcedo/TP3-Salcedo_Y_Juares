using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Carrito
    {
        public List<Articulo> listaArticulos { get; set; }
        public Carrito()
        {
            listaArticulos = new List<Articulo>();
        }
            
    }
}
