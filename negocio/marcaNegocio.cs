using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using helper;

namespace negocio
{
    public class marcaNegocio
    {
        public AccesoDatos datos;

        public List<Marca> Listar()
        {
            try
            {
                datos = new AccesoDatos();
                List<Marca> lista = new List<Marca>();
                datos.SettearConsulta("SELECT Id,Descripcion FROM MARCAS");
                datos.EjecutarQuery();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
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
