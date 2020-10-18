using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
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


        public void editar(Articulo arti)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                conexion.setearQuery("update ARTICULOS set Codigo= @cod, Nombre=@nombre,Descripcion=@des, ImagenUrl=@imagen,IdMarca=@marca,idcategoria=@cat,Precio=@precio where Id=@id ");
                conexion.agregarParametro("@cod", arti.codigo);
                conexion.agregarParametro("@nombre", arti.nombre);
                conexion.agregarParametro("@des", arti.descripcion);
                conexion.agregarParametro("@imagen", arti.imagen);
                conexion.agregarParametro("@marca", arti.marca.id);
                conexion.agregarParametro("@cat", arti.categoria.id);
                conexion.agregarParametro("@precio", arti.precio);
                conexion.agregarParametro("@id", arti.id);
                conexion.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                conexion.setearQuery("insert into ARTICULOS(Codigo, Nombre, Descripcion, ImagenUrl, IdMarca, IdCategoria, Precio)values( @cod,@nombre,@des,@imagen,@marca,@cat,@precio) ");
                conexion.agregarParametro("@cod", nuevo.codigo);
                conexion.agregarParametro("@nombre", nuevo.nombre);
                conexion.agregarParametro("@des",    nuevo.descripcion);
                conexion.agregarParametro("@imagen", nuevo.imagen);
                conexion.agregarParametro("@marca",  nuevo.marca.id);
                conexion.agregarParametro("@cat",    nuevo.categoria.id);
                conexion.agregarParametro("@precio", nuevo.precio);
                //conexion.agregarParametro("@id",     nuevo.id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public void eliminar(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearQuery("delete from ARTICULOS where Id=@id");
                conexion.agregarParametro("@id",id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
          
        }

    }
}
