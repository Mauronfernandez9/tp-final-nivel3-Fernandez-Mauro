using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Front
{
	public partial class Productos : System.Web.UI.Page
	{
		public List<Articulo> listaArticulos = null;
		public List<Articulo> listaCategorias = null;
		public List<Articulo> listaMarca;
		public articuloNegocio artNegocio;

		protected void Page_Load(object sender, EventArgs e)
		{

			if (!(IsPostBack))
			{
				try
				{
					artNegocio = new articuloNegocio();
					listaArticulos = artNegocio.ListarArticulos();

					repetidorArticulos.DataSource = listaArticulos;
					repetidorArticulos.DataBind();
					Session.Add("listaArticulos", listaArticulos);


					categoriaNegocio CategoriaNegocio = new categoriaNegocio();
					marcaNegocio MarcaNegocio = new marcaNegocio();
					ddlCategorias.DataValueField = "Id";
					ddlCategorias.DataTextField = "Descripcion";
					ddlCategorias.DataSource = CategoriaNegocio.Listar();
					ddlCategorias.DataBind();
					ddlCategorias.Items.Insert(0, new ListItem("Todos", "0"));









					repetidorMarcas.DataSource = MarcaNegocio.Listar();
					repetidorMarcas.DataBind();


				}
				catch (Exception)
				{

					throw;
				}
			}



		}

		protected void ddlOrdenar_TextChanged(object sender, EventArgs e)
		{
			List<Articulo> listaOrdenada = new List<Articulo>();
			listaCategorias = (List<Articulo>)Session["listaCategorias"];
			if (ddlOrdenar.SelectedValue == "Menor Precio")
			{

				if (Session["marcaLista"] != null)
				{
					listaOrdenada = (List<Articulo>)Session["marcaLista"];
					listaOrdenada.Sort((p1, p2) => p1.Precio.CompareTo(p2.Precio));
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaOrdenada;
					repetidorArticulos.DataBind();
				}

				else if (listaCategorias != null)
				{
					listaOrdenada = listaCategorias;
					listaOrdenada.Sort((p1, p2) => p1.Precio.CompareTo(p2.Precio));
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaOrdenada;
					repetidorArticulos.DataBind();
				}
				else
				{
					listaOrdenada = (List<Articulo>)Session["listaArticulos"];
					listaOrdenada.Sort((p1, p2) => p1.Precio.CompareTo(p2.Precio));
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaOrdenada;
					repetidorArticulos.DataBind();
				}


			}
			else if (ddlOrdenar.SelectedValue == "Mayor Precio")
			{


				if (Session["marcaLista"] != null)
				{
					listaOrdenada = (List<Articulo>)Session["marcaLista"];
					listaOrdenada.Sort((p1, p2) => p2.Precio.CompareTo(p1.Precio));
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaOrdenada;
					repetidorArticulos.DataBind();
				}

				else if (listaCategorias != null)
				{
					listaOrdenada = listaCategorias;
					listaOrdenada.Sort((p1, p2) => p2.Precio.CompareTo(p1.Precio));
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaOrdenada;
					repetidorArticulos.DataBind();
				}
				else
				{
					listaOrdenada = (List<Articulo>)Session["listaArticulos"];
					listaOrdenada.Sort((p1, p2) => p2.Precio.CompareTo(p1.Precio));
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaOrdenada;
					repetidorArticulos.DataBind();
				}

			}
			else if (ddlOrdenar.SelectedValue == "")
			{
				if (Session["marcaLista"] != null)
				{
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = Session["marcaLista"];
					repetidorArticulos.DataBind();
				}
				else if (listaCategorias != null)
				{
					repetidorArticulos.DataSource = null;
					repetidorArticulos.DataSource = listaCategorias;
					repetidorArticulos.DataBind();
				}
				else
				{
					repetidorArticulos.DataSource = null;
					artNegocio = new articuloNegocio();
					repetidorArticulos.DataSource = artNegocio.ListarArticulos();
					repetidorArticulos.DataBind();
				}

			}
		}

		protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{

			ddlOrdenar.SelectedIndex=0;

			if ((ddlCategorias.SelectedIndex != 0))
			{
				artNegocio = new articuloNegocio();

				string categoria = ddlCategorias.SelectedValue.ToString();
				Session.Add("categoriaElegida", categoria);

				listaCategorias = (artNegocio.ListarArticulos()).FindAll(x => x.CategoriaArticulo.Id.ToString() == ddlCategorias.SelectedValue);

				if (Session["marcaElegida"] != null)
				{
					listaCategorias = listaCategorias.FindAll(y => y.MarcaArticulo.Descripcion == (string)Session["marcaElegida"]);
				}

				repetidorArticulos.DataSource = null;  
				repetidorArticulos.DataSource = listaCategorias;
				repetidorArticulos.DataBind();

				Session.Add("listaCategorias", listaCategorias);
			}
			else
			{
				Session.Remove("listaCategorias");
				Session.Remove("categoriaElegida");
				artNegocio = new articuloNegocio();
				repetidorArticulos.DataSource = null;
				if (Session["marcaElegida"] != null)
				{
					
					repetidorArticulos.DataSource = (artNegocio.ListarArticulos()).FindAll(x=>x.MarcaArticulo.Descripcion == (string)Session["marcaElegida"]);
					
				}
				else
				{
					repetidorArticulos.DataSource = artNegocio.ListarArticulos();
				}
				repetidorArticulos.DataBind();
			}

		}

		protected void btnMarca_Click(object sender, EventArgs e)
		{
			Button btnmarca = (Button)sender;
			string marca = btnmarca.Text;
			Session.Add("marcaElegida", marca);
			artNegocio = new articuloNegocio();
			listaMarca = ((artNegocio.ListarArticulos()).FindAll(y=>y.MarcaArticulo.Descripcion==marca));
			if (Session["categoriaElegida"] != null)
			{
				
				listaMarca = listaMarca.FindAll(x => x.CategoriaArticulo.Id == int.Parse(Session["categoriaElegida"].ToString()));

			}

			repetidorArticulos.DataSource = null;
			repetidorArticulos.DataSource = (List<Articulo>)listaMarca;
			repetidorArticulos.DataBind();
			Session.Add("marcaLista", listaMarca);

		}

		protected void btnRestaurarMarca_Click(object sender, EventArgs e)
		{
			ddlOrdenar.SelectedIndex = 0;
			Session.Remove("marcaLista");
			Session.Remove("marcaElegida");
			artNegocio = new articuloNegocio();
			repetidorArticulos.DataSource = null;
			if (Session["categoriaElegida"] != null)
			{
				repetidorArticulos.DataSource = (artNegocio.ListarArticulos()).FindAll(x=>x.CategoriaArticulo.Id == int.Parse(Session["categoriaElegida"].ToString()));
			}
			else
			{
				repetidorArticulos.DataSource = artNegocio.ListarArticulos();
			}
			repetidorArticulos.DataBind();
		}
	}
}