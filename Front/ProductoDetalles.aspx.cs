using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Front
{
    public partial class ProductoDetalles : System.Web.UI.Page
    {
        public List<Articulo> articulos;
        articuloNegocio ArticuloNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                ArticuloNegocio = new articuloNegocio();
                Articulo articuloAMostrar = ArticuloNegocio.ObtenerArticulo(int.Parse(Request.QueryString["id"].ToString()));
                NombreProducto.Text = articuloAMostrar.Nombre;
                PrecioProducto.Text = "$" + (articuloAMostrar.Precio.ToString("N2"));
                precioEn6Cuotas.Text = "En 6 cuotas de $" + (((articuloAMostrar.Precio) / 6).ToString("N2"));
                DescripcionProducto.Text = articuloAMostrar.Descripcion;
                imgUrlProducto.ImageUrl = string.IsNullOrEmpty(articuloAMostrar.UrlImagen) ? "data:image/jpeg;base64,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" : articuloAMostrar.UrlImagen;
            }
            if (ArticuloNegocio != null)
            {
                articulos = ArticuloNegocio.ListarArticulos();
                List<Articulo> articulosFiltrados = articulos.FindAll(x => x.Id >= 1 && x.Id <= 3);
                List<Articulo> articulosFiltrados2 = articulos.FindAll(x => x.Id >= 2 && x.Id <= 4);
                List<Articulo> articulosFiltrados3 = articulos.FindAll(x => x.Id >= 3 && x.Id <= 5);



                repetidorCarrusel1.DataSource = articulosFiltrados;
                repetidorCarrusel1.DataBind();

                repetidorCarrusel2.DataSource = articulosFiltrados2;
                repetidorCarrusel2.DataBind();

                repetidorCarrusel3.DataSource = articulosFiltrados3;
                repetidorCarrusel3.DataBind();


            }

        }
    }
}