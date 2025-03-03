<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormArticulos.aspx.cs" Inherits="Front.FormArticulos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="bg-success-subtle container-fluid">
            <div class="row">
                <div class="col">
                    <asp:Label Text="Nuevo articulo" CssClass="h2 font-monospace text-info-emphasis" runat="server" />
                </div>

            </div>
        </div>
        <div class="container p-5">

            <div class="row d-flex justify-content-around">
                <div class="col-4 ">
                    <div class="mb-3 d-flex flex-column align-items-center">
                        <label for="txbCodigoArt" class="form-label">Codigo Articulo</label>
                        <asp:TextBox runat="server" ID="txbCodigoArt" CssClass="form-control w-75" />
                    </div>

                </div>
            </div>
            <div class="row">

                <div class="col-6">

                    <div class="mb-3">
                        <label for="txbNombreProducto" class="form-label">Nombre</label>
                        <asp:TextBox ID="txbNombreProducto" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txbDescripcion" class="form-label">Descripción</label>
                        <asp:TextBox ID="txbDescripcion" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="ddlMarca" class="form-label">Marca</label>
                        <asp:DropDownList runat="server" CssClass="form-select" ID="ddlMarca">
                            <asp:ListItem Text="Selecciona una marca" Value="-1" />
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="ddlCategoria" class="form-label">Categoria</label>
                        <asp:DropDownList runat="server" CssClass="form-select" ID="ddlCategoria">
                            <asp:ListItem Text="Selecciona una categoria" Value="-1" />
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="txbPrecio" class="form-label">Precio</label>
                        <asp:TextBox ID="txbPrecio" CssClass="form-control w-50" runat="server" />
                    </div>






                </div>
                <div class="col-4">
                    <div class="mb-3">
                        <label for="txbUrlImagen" class="form-label">Imagen</label>
                        <asp:TextBox ID="txbUrlImagen" CssClass="form-control" runat="server" />
                    </div>
                    <div class="mb-3">
                        <asp:Image ImageUrl="" ID="imagenurl" runat="server" />
                    </div>
                </div>

            </div>
            <div class="row">
                <div class="col d-flex justify-content-evenly">
                    <%if (Request.QueryString["id"] != null)
                        {

                    %>
                    <asp:Button Text="Modificar" CssClass="btn btn-success" OnClick="btnCargar_Click" ID="Button1" runat="server" />
                     <asp:Button Text="Eliminar"  CssClass="btn btn-danger" runat="server" />   
                    <%}
                        else
                        {  %>
                    <asp:Button Text="Cargar" CssClass="btn btn-primary" OnClick="btnCargar_Click" ID="btnCargar" runat="server" />
                    <%}%>

                    <asp:Button Text="Cancelar" OnClick="btnCancelar_Click" ID="btnCancelar" CssClass="btn btn-warning" runat="server" />
                    
                </div>


            </div>

        </div>

    </form>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
