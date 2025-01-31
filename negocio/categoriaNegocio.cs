using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using helper;

namespace negocio
{
    public class categoriaNegocio
    {
		public AccesoDatos datos;
        public List<Categoria> Listar()
        {
			try
			{
				List<Categoria> lista = new List<Categoria>();
				datos = new AccesoDatos();
				datos.SettearConsulta("SELECT Id,Descripcion FROM CATEGORIAS");
				datos.EjecutarQuery();
				while (datos.Lector.Read())
				{
					Categoria aux = new Categoria();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
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

    }
}
