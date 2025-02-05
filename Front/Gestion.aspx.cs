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
    public partial class Gestion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                articuloNegocio ArticuNegocio = new articuloNegocio();
                gvArticulos.DataSource = ArticuNegocio.ListarArticulos();
                gvArticulos.DataBind();
                Session.Add("listaArticulos", ArticuNegocio.ListarArticulos());
            }

        }

        protected void gvArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvArticulos.SelectedDataKey.Value.ToString();
            Response.Redirect("FormArticulos.aspx?id=" + id, false);

        }

        protected void gvArticulos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvArticulos.PageIndex = e.NewPageIndex;
            gvArticulos.DataSource = (List<Articulo>)Session["listaArticulos"];
            gvArticulos.DataBind();
        }
    }
}