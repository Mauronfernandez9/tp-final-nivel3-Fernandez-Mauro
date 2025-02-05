<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNF.Master" AutoEventWireup="true" CodeBehind="Gestion.aspx.cs" Inherits="Front.Gestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <div class="container-fluid">
        <div class="row mt-3 mb-3">
            <div class="col">
                <h1 class=" text-white">Gestión de articulos</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-3 d-flex align-items-center">
                <a class="btn btn-primary mb-3" href="FormArticulos.aspx">Nuevo Articulo</a>
            </div>
            <div class="col d-flex align-items-center justify-content-center">
                <asp:Label CssClass="text-white" Text="Filtro rápido" runat="server" />
                <asp:TextBox runat="server" CssClass="form-text ms-2"></asp:TextBox>
            </div>
            <div class="col-3 d-flex align-items-center">
                <asp:Button CssClass="btn btn-warning " Text="Filtro Avanzado" runat="server" />
            </div>
        </div>

        <asp:UpdatePanel runat="server">
            <ContentTemplate>


                <div class="row">
                    <div class="col">
                        <asp:GridView AllowPaging="true" OnPageIndexChanging="gvArticulos_PageIndexChanging"   PageSize="4" OnSelectedIndexChanged="gvArticulos_SelectedIndexChanged" DataKeyNames="Id" runat="server" ID="gvArticulos" CssClass="table table-warning table-bordered mb-5 text-center" AutoGenerateColumns="false">
                            <PagerStyle CssClass="border border-0 p-1 rounded-1 text-bg-success" />
                            <Columns>
                                <asp:BoundField HeaderText="Codigo Art" DataField="CodigoArticulo" />
                                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                                <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                                <asp:BoundField HeaderText="Precio" DataFormatString="{0:N2}" DataField="Precio" />
                                <asp:BoundField HeaderText="Marca" DataField="MarcaArticulo.Descripcion" />
                                <asp:BoundField HeaderText="Categoria" DataField="CategoriaArticulo.Descripcion" />
                                <asp:CommandField HeaderText="Acción" ShowSelectButton="true" ControlStyle-CssClass="btn btn-success p-1" SelectText="Detalles" />
                            </Columns>

                        </asp:GridView>

                    </div>
                </div>



            </ContentTemplate>
        </asp:UpdatePanel>


    </div>
</asp:Content>
