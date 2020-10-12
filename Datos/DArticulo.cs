using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Datos
{
    public class DArticulo
    {
        public List<Articulo> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> lista = new List<Articulo>();

            conexion.ConnectionString = "data source=T480S-JMJ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi ";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select A.Id idarti,A.Codigo, A.Nombre,A.Descripcion,A.ImagenUrl,M.Id idmarca,M.Descripcion marca ,C.Id idcat,C.Descripcion cat,A.Precio precio from ARTICULOS A ,MARCAS M, CATEGORIAS C where A.idmarca=M.id AND	A.IdCategoria=C.id";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Articulo aux = new Articulo();
                aux.id = (int)lector["idarti"];
                aux.codigo = lector.GetString(1);
                aux.nombre = lector.GetString(2);
                aux.descripcion = lector.GetString(3);
                aux.imagen = (string)lector["ImagenUrl"];
                aux.marca = new Marca();
                aux.marca.nombre = (string)lector["marca"];
                aux.marca.id = (int)lector["idmarca"];
                aux.categoria = new Categoria();
                aux.categoria.nombre = (string)lector["cat"];
                aux.categoria.id = (int)lector["idcat"];
                aux.precio = (decimal)lector["precio"];


                lista.Add(aux);
            }
            conexion.Close();
            return lista;


        }
        public void agregar(Articulo nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=T480S-JMJ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi ";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values('" + nuevo.codigo + "', '" + nuevo.nombre + "', '" + nuevo.descripcion + "',@idMarca,@idcat, '" + nuevo.imagen + "', '"+nuevo.precio+"')";
            comando.Parameters.AddWithValue("@idMarca", nuevo.marca.id);
            comando.Parameters.AddWithValue("@idcat", nuevo.categoria.id);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void editar(Articulo arti)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
          
            conexion.ConnectionString = "data source=T480S-JMJ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi ";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update ARTICULOS set Codigo= @cod,Nombre=@nombre,Descripcion=@des, ImagenUrl=@imagen,IdMarca =@marca,IdCategoria=@idcat where Id=@id ";
            comando.Parameters.AddWithValue("@cod", arti.codigo);
            comando.Parameters.AddWithValue("@nombre",arti.nombre);
            comando.Parameters.AddWithValue("@des", arti.descripcion);
            comando.Parameters.AddWithValue("@imagen",arti.imagen);
            comando.Parameters.AddWithValue("@marca", arti.marca.id);
            comando.Parameters.AddWithValue("@cat", arti.categoria.id);
            //comando.Parameters.AddWithValue("@precio", arti.precio);
            
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

        }

        public void eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=T480S-JMJ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi ";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "delete from ARTICULOS where Id=@id";
            comando.Parameters.AddWithValue("@id",id);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
