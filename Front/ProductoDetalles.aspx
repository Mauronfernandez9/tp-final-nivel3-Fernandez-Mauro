<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNF.Master" AutoEventWireup="true" CodeBehind="ProductoDetalles.aspx.cs" Inherits="Front.ProductoDetalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row bg-body">
            <div class="col-7 border border-bottom d-flex justify-content-center">
                <asp:Image ID="imgUrlProducto" CssClass="img-fluid" runat="server" />
            </div>
            <div class="col d-flex flex-column justify-content-evenly border border-2 align-items-center">
                <asp:Label ID="NombreProducto" CssClass="font-monospace h1" runat="server" />
                <asp:Label ID="PrecioProducto" CssClass="font-monospace h2 " runat="server" />
                <asp:Label ID="precioEn6Cuotas" CssClass="font-monospace " runat="server" />
                <asp:Button ID="btnFavorito" CssClass="btn btn-danger" Text="Agregar Favorito" runat="server" />
            </div>
        </div>
        <div class="row bg-body">
            <div class="col">
                <h2 class="font-monospace">Descripcion</h2>
                <asp:Label ID="DescripcionProducto" Text="text" runat="server" />
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col">
                <h2 class="h2 text-white font-monospace text-capitalize text-center mt-4 mb-4">Productos relacionados</h2>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div id="carouselExample" class="carousel slide ">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <div class="card-group d-flex gap-5">
                                <asp:Repeater runat="server" ID="repetidorCarrusel1">
                                    <ItemTemplate>
                                        <div class="align-items-center border border-2 card col-3 d-flex mb-3 p-0">
                                            <img style="max-height: 200px; max-width: 150px" src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                                            <div class="card-body d-flex flex-column align-items-center">
                                                <h5 class=" fst-italic mb-4 fs-6 fw-lighter"><%#Eval("Nombre") %></h5>
                                                <p class="text-lg-center text-nowrap fw-semibold">$<%#Eval("Precio") %></p>
                                                <a href="ProductoDetalles.aspx?id=<%#Eval("Id")%>" class="btn btn-success">Ver detalles</a>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>


                            </div>
                        </div>
                        <div class="carousel-item">
                            <div class="card-group d-flex gap-5">
                                <asp:Repeater runat="server" ID="repetidorCarrusel2">
                                    <ItemTemplate>
                                        <div class="align-items-center border border-2 card col-3 d-flex mb-3 p-0">
                                            <img style="max-height: 200px; max-width: 150px" src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                                            <div class="card-body d-flex flex-column align-items-center">
                                                <h5 class=" fst-italic mb-4 fs-6 fw-lighter"><%#Eval("Nombre") %></h5>
                                                <p class="text-lg-center text-nowrap  fw-semibold">$<%#Eval("Precio") %></p>
                                                <a href="ProductoDetalles.aspx?id=<%#Eval("Id")%>" class="btn btn-success">Ver detalles</a>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>


                            </div>

                        </div>
                        <div class="carousel-item">
                            <div class="card-group d-flex gap-5">
                                <asp:Repeater runat="server" ID="repetidorCarrusel3">
                                    <ItemTemplate>
                                        <div class="align-items-center border border-2 card col-3 d-flex mb-3 p-0">
                                            <img style="max-height: 200px; max-width: 150px" src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                                            <div class="card-body d-flex flex-column align-items-center">
                                                <h5 class=" fst-italic mb-4 fs-6 fw-lighter"><%#Eval("Nombre") %></h5>
                                                <p class="text-lg-center text-nowrap fw-semibold">$<%#Eval("Precio") %></p>
                                                <a href="ProductoDetalles.aspx?id=<%#Eval("Id")%>" class="btn btn-success">Ver detalles</a>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>


                            </div>

                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon bg-primary me-auto" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                        <span class="carousel-control-next-icon bg-primary ms-auto" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
