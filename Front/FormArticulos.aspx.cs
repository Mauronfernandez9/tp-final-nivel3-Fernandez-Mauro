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
    public partial class FormArticulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (!IsPostBack)
			{
				categoriaNegocio categoriaNego = new categoriaNegocio();
				ddlCategoria.DataValueField = "Id";
				ddlCategoria.DataTextField = "Descripcion";
				ddlCategoria.DataSource = categoriaNego.Listar();
				ddlCategoria.DataBind();
				marcaNegocio marcaNego = new marcaNegocio();
				ddlMarca.DataTextField = "Descripcion";
				ddlMarca.DataValueField = "Id";
				ddlMarca.DataSource = marcaNego.Listar();
				ddlMarca.DataBind();
				ddlCategoria.Items.Insert(0, new ListItem("Selecciona una categoria...", "-1"));
				ddlMarca.Items.Insert(0, new ListItem("Selecciona una marca...", "-1"));

				if (Request.QueryString["id"] != null)
				{
					articuloNegocio articuloNegocio = new articuloNegocio();
					Articulo articuloModificar = articuloNegocio.ObtenerArticulo(int.Parse(Request.QueryString["id"]));
					txbCodigoArt.Text = articuloModificar.CodigoArticulo;
					txbDescripcion.Text = articuloModificar.Descripcion;
					txbNombreProducto.Text = articuloModificar.Nombre;
					txbPrecio.Text = articuloModificar.Precio.ToString();
					txbUrlImagen.Text = articuloModificar.UrlImagen;
					ddlCategoria.SelectedValue = articuloModificar.CategoriaArticulo.Id.ToString();
					ddlMarca.SelectedValue = articuloModificar.MarcaArticulo.Id.ToString();
					imagenurl.ImageUrl = articuloModificar.UrlImagen;
				}
			}

        }


		protected void btnCancelar_Click(object sender, EventArgs e)
		{
            Response.Redirect("Gestion.aspx", false);
		}

		protected void btnCargar_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txbCodigoArt.Text) || string.IsNullOrEmpty(txbNombreProducto.Text) || string.IsNullOrEmpty(txbDescripcion.Text) || string.IsNullOrEmpty(txbPrecio.Text))
				{
					return;
				}

				Articulo nuevoArticulo = new Articulo();
				nuevoArticulo.CodigoArticulo = txbCodigoArt.Text;
				nuevoArticulo.Nombre = txbNombreProducto.Text;
				nuevoArticulo.Descripcion = txbDescripcion.Text;
				nuevoArticulo.Precio = decimal.Parse(txbPrecio.Text);
				nuevoArticulo.UrlImagen = !string.IsNullOrEmpty(txbUrlImagen.Text) ? txbUrlImagen.Text : "";

				if (ddlCategoria.SelectedValue.ToString() == "-1" || ddlMarca.SelectedValue.ToString() == "-1")
				{
					return;
				}
				nuevoArticulo.MarcaArticulo = new Marca();
				nuevoArticulo.MarcaArticulo.Id = int.Parse(ddlMarca.SelectedValue.ToString());

				nuevoArticulo.CategoriaArticulo = new Categoria();
				nuevoArticulo.CategoriaArticulo.Id = int.Parse(ddlCategoria.SelectedValue.ToString());

				articuloNegocio artNegocio = new articuloNegocio();
				artNegocio.CrearArticulo(nuevoArticulo);
				Response.Redirect("Gestion.aspx", false);
			}
			catch (Exception exce)
			{
				Session.Add("error", exce.Message);
				Response.Redirect("error.aspx", false);
			}


		}


	}
}