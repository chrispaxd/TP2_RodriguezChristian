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
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select a.Id, a.Codigo, a.Nombre,a.linkurl, a.Descripcion DescArticulo, a.Precio, c.id idCategoria, c.Descripcion DescCategoria, m.id idMarca,m.Descripcion DescMarca from Articulos a inner join CATEGORIAS c on a.idCategoria = c.id inner join Marcas m on a.idMarca = m.id");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector["Nombre"].ToString();
                    aux.linkurl = datos.lector["linkurl"].ToString();
                    aux.Codigo = datos.lector["Codigo"].ToString();
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Descripcion = datos.lector["DescArticulo"].ToString();
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.lector["idCategoria"];
                    aux.Categoria.Descripcion = (string)datos.lector["DescCategoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.lector["idMarca"];
                    aux.Marca.Descripcion = (string)datos.lector["DescMarca"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }

        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Insert into Articulos values (@codigo,@nombre,@descripcion, @idMarca, @idCategoria, @precio,@linkurl)");
                datos.agregarParametro("@codigo", articulo.Codigo);
                datos.agregarParametro("@nombre", articulo.Nombre);
                datos.agregarParametro("@descripcion", articulo.Descripcion);
                datos.agregarParametro("@idMarca", articulo.Marca.Id);
                datos.agregarParametro("@idCategoria", articulo.Categoria.Id);
                datos.agregarParametro("@precio", articulo.Precio);
                datos.agregarParametro("@linkurl", articulo.linkurl);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Update Articulos set Nombre=@nombre,precio=@precio,codigo=@codigo,idMarca=@idMarca,idCategoria=@idCategoria,descripcion=@descripcion,linkurl=@linkurl Where Id=@Id");
                datos.agregarParametro("@nombre", articulo.Nombre);
                datos.agregarParametro("@precio", articulo.Precio);
                datos.agregarParametro("@codigo", articulo.Codigo);
                datos.agregarParametro("@idMarca", articulo.Marca.Id);
                datos.agregarParametro("@idCategoria", articulo.Categoria.Id);
                datos.agregarParametro("@descripcion", articulo.Descripcion);
                datos.agregarParametro("@linkurl", articulo.linkurl);
                datos.agregarParametro("@Id", articulo.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void detalles(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select * from Articulos Nombre=@nombre,precio=@precio,codigo=@codigo,idMarca=@idMarca,idCategoria=@idCategoria,descripcion=@descripcion,linkurl=@linkurl Where Id=@Id");
                datos.agregarParametro("@nombre", articulo.Nombre);
                datos.agregarParametro("@codigo", articulo.Codigo);
                datos.agregarParametro("@descripcion", articulo.Descripcion);
                datos.agregarParametro("@linkurl", articulo.linkurl);
                datos.agregarParametro("@Id", articulo.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from Articulos where id =" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
