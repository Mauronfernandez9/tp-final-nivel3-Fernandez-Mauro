using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using helper;

namespace negocio
{
    public class articuloNegocio
    {
        AccesoDatos datos;

        public List<Articulo> ListarArticulos()
        {
            try
            {

                datos = new AccesoDatos();
                List<Articulo> lista = new List<Articulo>();
                datos.SettearConsulta("SELECT A.Id AS idArticulo,Codigo,Nombre,A.Descripcion AS descripcionArticulo,M.Id AS idMarca,M.Descripcion AS descripcionMarca,C.Id AS idCategoria,C.Descripcion AS descripcionCategoria,ImagenUrl,Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdCategoria=C.Id AND A.IdMarca=M.Id");
                datos.EjecutarQuery();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    if (!(string.IsNullOrEmpty(datos.Lector["idArticulo"].ToString())))
                    {
                        aux.Id = (int)datos.Lector["idArticulo"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["Nombre"].ToString())))
                    {
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["Precio"].ToString())))
                    {
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["ImagenUrl"].ToString())))
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["idMarca"].ToString())))
                    {
                        aux.MarcaArticulo = new Marca();
                        aux.MarcaArticulo.Id = (int)datos.Lector["idMarca"];
                        aux.MarcaArticulo.Descripcion = (string)datos.Lector["descripcionMarca"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["descripcionArticulo"].ToString())))
                    {
                        aux.Descripcion = (string)datos.Lector["descripcionArticulo"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["Codigo"].ToString())))
                    {
                        aux.CodigoArticulo = (string)datos.Lector["Codigo"];

                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["idCategoria"].ToString())))
                    {
                        aux.CategoriaArticulo = new Categoria();
                        aux.CategoriaArticulo.Id = (int)datos.Lector["idCategoria"];
                        aux.CategoriaArticulo.Descripcion = (string)datos.Lector["descripcionCategoria"];
                    }
                    lista.Add(aux);

                }
                return lista;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public Articulo ObtenerArticulo(int id)
        {
            try
            {
                datos = new AccesoDatos();
                datos.SettearConsulta("SELECT A.Id AS idArticulo,Codigo,Nombre,A.Descripcion AS descripcionArticulo,M.Id AS idMarca,M.Descripcion AS descripcionMarca,C.Id AS idCategoria,C.Descripcion AS descripcionCategoria,ImagenUrl,Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdCategoria=C.Id AND A.IdMarca=M.Id AND A.Id = @id");
                datos.SettearParametros("@id", id);
                datos.EjecutarQuery();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    if (!(string.IsNullOrEmpty(datos.Lector["idArticulo"].ToString())))
                    {
                        aux.Id = (int)datos.Lector["idArticulo"];
                    }
                    else
                    {
                        throw new Exception("Articulo no encontrado...");
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["Nombre"].ToString())))
                    {
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["Precio"].ToString())))
                    {
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["ImagenUrl"].ToString())))
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["idMarca"].ToString())))
                    {
                        aux.MarcaArticulo = new Marca();
                        aux.MarcaArticulo.Id = (int)datos.Lector["idMarca"];
                        aux.MarcaArticulo.Descripcion = (string)datos.Lector["descripcionMarca"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["descripcionArticulo"].ToString())))
                    {
                        aux.Descripcion = (string)datos.Lector["descripcionArticulo"];
                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["Codigo"].ToString())))
                    {
                        aux.CodigoArticulo = (string)datos.Lector["Codigo"];

                    }
                    if (!(string.IsNullOrEmpty(datos.Lector["idCategoria"].ToString())))
                    {
                        aux.CategoriaArticulo = new Categoria();
                        aux.CategoriaArticulo.Id = (int)datos.Lector["idCategoria"];
                        aux.CategoriaArticulo.Descripcion = (string)datos.Lector["descripcionCategoria"];
                    }
                    return aux;

                }
                throw new Exception("Producto no encontrado!");



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
