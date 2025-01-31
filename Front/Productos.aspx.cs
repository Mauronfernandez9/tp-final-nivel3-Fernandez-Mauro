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

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!(IsPostBack))
            {
                try
                {
                    articuloNegocio artNegocio = new articuloNegocio();
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

                if (listaCategorias != null)
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
                if (listaCategorias != null)
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
            else
            {
                if (listaCategorias != null)
                {
                    repetidorArticulos.DataSource = null;
                    repetidorArticulos.DataSource = listaCategorias;
                    repetidorArticulos.DataBind();
                }
                else
                {
                    repetidorArticulos.DataSource = null;
                    repetidorArticulos.DataSource = (List<Articulo>)Session["listaArticulos"];
                    repetidorArticulos.DataBind();
                }

            }
        }

        protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlOrdenar.SelectedIndex = -1;

            if (ddlCategorias.SelectedValue.ToString() != "0")
            {
                listaCategorias = new List<Articulo>();

                listaCategorias = ((List<Articulo>)Session["listaArticulos"]).FindAll(x => x.CategoriaArticulo.Id == int.Parse(ddlCategorias.SelectedValue.ToString()));
                Session.Add("listaCategorias", listaCategorias);
                repetidorArticulos.DataSource = null;
                repetidorArticulos.DataSource = (List<Articulo>)Session["listaCategorias"];
                repetidorArticulos.DataBind();
            }
            else
            {
                listaCategorias = null;
                Session.Remove("listaCategorias");
                repetidorArticulos.DataSource = null;
                repetidorArticulos.DataSource = (List<Articulo>)Session["listaArticulos"];
                repetidorArticulos.DataBind();
            }

        }
    }
}