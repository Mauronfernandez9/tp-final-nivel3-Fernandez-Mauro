using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Front
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Articulo> articulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            articuloNegocio ArticuloNegocio = new articuloNegocio();
            articulos = ArticuloNegocio.ListarArticulos();
            List<Articulo> articulosFiltrados = articulos.FindAll(x => x.Id >= 1 && x.Id <= 3);
            List<Articulo> articulosFiltrados2 = articulos.FindAll(x => x.Id >= 2 && x.Id <= 4);
            List<Articulo> articulosFiltrados3 = articulos.FindAll(x => x.Id >= 3 && x.Id <= 5);

            repetidor.DataSource = articulosFiltrados;
            repetidor.DataBind();

            repetidorCarrusel1.DataSource = articulosFiltrados;
            repetidorCarrusel1.DataBind();

            repetidorCarrusel2.DataSource = articulosFiltrados2;
            repetidorCarrusel2.DataBind();

            repetidorCarrusel3.DataSource = articulosFiltrados3;
            repetidorCarrusel3.DataBind();



        }
    }
}