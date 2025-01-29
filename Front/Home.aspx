<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNF.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Front.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <div id="carouselExampleRide" class="carousel slide mb-3" data-bs-ride="true">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img style="height: 20rem;" src="https://img.freepik.com/vector-gratis/plantilla-realista-portada-redes-sociales-cyber-monday_23-2149816816.jpg?t=st=1737681013~exp=1737684613~hmac=e8d8692e06bb49e338d7d8ba3d5941e30ad03a618849585b4440b5f0ca42015a&w=826" class="d-block w-100" alt="...">
                        </div>
                        <div class="carousel-item">
                            <img style="height: 20rem;" src="https://img.freepik.com/vector-gratis/diseno-plantillas-tiendas-electronica_23-2151285501.jpg?t=st=1737681024~exp=1737684624~hmac=f07bc813c5cc38dac954eb28a7abf5772cec5d07a9292c4d4fb68096cfcf743d&w=740" class="d-block w-100" alt="...">
                        </div>
                        <div class="carousel-item">
                            <img style="height: 20rem;" src="https://img.freepik.com/vector-gratis/plantilla-pagina-aterrizaje-plana-cyber-monday_23-2149114962.jpg?t=st=1737681028~exp=1737684628~hmac=96dbf9edd31e1e5c5f1710593269246004af29144d742e8a527e530c1ac08a35&w=740" class="d-block w-100" alt="...">
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleRide" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleRide" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
        </div>

    </div>

    <div class="container mt-5">
        <div class="row">
            <div class="col-5 gap-3 d-flex flex-column justify-content-center">
                <div class="card text-bg-dark mb-3">
                    <img src="https://www.peru-smart.com/wp-content/uploads/2023/07/BANNER-SMART-CELULAR-3.webp" class="card-img" alt="...">
                    <div class="card-img-overlay">
                        <h5 class="card-title">Celulares</h5>
                    </div>
                </div>
                <div class="card text-bg-dark">
                    <img src="https://www.smarttech-tv.com/es/image/cache/catalog/home_banner/HomeBanner_1920x960_monitor-1920x960.jpg" class="card-img" alt="...">
                    <div class="card-img-overlay">
                        <h5 class="card-title">Televisores</h5>
                    </div>
                </div>
            </div>
            <div class="col d-flex flex-column gap-3">
                <div class="card text-bg-dark">
                    <img src="https://gsmpro.cl/cdn/shop/articles/c17c5068-6c2d-4213-8512-b8ff31ff8549.webp?v=1733714994&width=1000" class="card-img" alt="...">
                    <div class="card-img-overlay">
                        <h5 class="card-title">Consolas</h5>
                    </div>
                </div>
                <div class="card text-bg-dark">
                    <img src="https://img.pikbest.com/wp/202408/development-innovation-innovative-3d-mobile-mockup-paired-with-web-banner-and-laptop_9763223.jpg!bwr800" class="card-img" alt="...">
                    <div class="card-img-overlay">
                        <h5 class="card-title">Computadoras</h5>
                    </div>
                </div>
            </div>
        </div>

    </div>



    <div class="container mt-5">
        <div class="row">
            <div class="col d-flex align-items-center justify-content-start">
                <h3 class="text-bg-dark font-monospace">Alguno de nuestros productos</h3>
                <a href="#" class="ms-3 font-monospace text-decoration-none text-success">Ver todo</a>
            </div>
        </div>


        <div class="row  d-flex justify-content-evenly gap-3 mt-3 bg-gradient border rounded-4 p-3 align-items-center mb-3">




            <asp:Repeater runat="server" ID="repetidor">
                <ItemTemplate>
                    <div class="card col-3 mb-3 d-flex align-items-center bg-dark p-0">
                        <img style="max-height: 200px;" src="<%#Eval("UrlImagen") %>" class="card-img-top img-thumbnail" alt="...">
                        <div class="card-body d-flex flex-column align-items-center">
                            <h5 class="card-title small text-nowrap text-center text-white"><%#Eval("Nombre") %></h5>
                            <p class="card-text h6 text-center font-monospace text-white">$<%#Eval("Precio") %></p>
                            <a href="ProductoDetalles.aspx?id=<%#Eval("Id")%>" class="btn btn-success">Ver detalles</a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>



    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <img src="Images/Home/aceleracondiscos.jpg" class="img-thumbnail mb-3" alt="...">
            </div>

        </div>
    </div>



    <div class="container">
        <div class="row">
            <div class="col">
                <h2 class="h2 text-white font-monospace text-capitalize text-center mt-4 mb-4">Conoce nuestros productos más destacados</h2>
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
                                        <div class="card col-3 mb-3 d-flex align-items-center bg-dark p-0 border border-2">
                                            <img style="max-height: 200px;" src="<%#Eval("UrlImagen") %>" class="card-img-top img-thumbnail" alt="...">
                                            <div class="card-body d-flex flex-column align-items-center">
                                                <h5 class="card-title small text-nowrap text-center text-white"><%#Eval("Nombre") %></h5>
                                                <p class="card-text h6 text-center font-monospace text-white">$<%#Eval("Precio") %></p>
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
                                        <div class="card col-3 mb-3 d-flex align-items-center bg-dark p-0 border border-2">
                                            <img style="max-height: 200px;" src="<%#Eval("UrlImagen") %>" class="card-img-top img-thumbnail" alt="...">
                                            <div class="card-body d-flex flex-column align-items-center">
                                                <h5 class="card-title small text-nowrap text-center text-white"><%#Eval("Nombre") %></h5>
                                                <p class="card-text h6 text-center font-monospace text-white">$<%#Eval("Precio") %></p>
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
                                        <div class="card col-3 mb-3 d-flex align-items-center bg-dark p-0 border border-2">
                                            <img style="max-height: 200px;" src="<%#Eval("UrlImagen") %>" class="card-img-top img-thumbnail" alt="...">
                                            <div class="card-body d-flex flex-column align-items-center">
                                                <h5 class="card-title small text-nowrap text-center text-white"><%#Eval("Nombre") %></h5>
                                                <p class="card-text h6 text-center font-monospace text-white">$<%#Eval("Precio") %></p>
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


    <div class="container mb-3 d-flex flex-column align-items-center">
        <div class="row">
            <div class="col">
                <h3 class="text-white font-monospace text-center h3 mt-3 mb-2">¿Que beneficios te ofrecemos?</h3>
            </div>
        </div>
        <div class="row">
            <div class="col d-flex justify-content-center">
                <div class="card-group w-75  ">
                    <div class="card d-flex align-items-center bg-dark-subtle">
                        <img src="Images/Home/caja.png" style="width: 5rem" class="card-img-top pt-2" alt="...">
                        <div class="card-body">
                            <h5 class="card-title h5 text-primary-emphasis ">Recibí tus productos en menos de 48 hs</h5>
                            <p class="card-text">Tus paquetes están seguros. Tenés el respaldo de los envíos con Mercado Libre.</p>
                        </div>
                    </div>
                    <div class="card d-flex align-items-center bg-dark-subtle">
                        <img src="Images/Home/transporte.png" style="width: 5rem" class="card-img-top pt-2" alt="...">
                        <div class="card-body">
                            <h5 class="card-title h5 text-primary-emphasis ">Aprovechá el beneficio del envío gratis</h5>
                            <p class="card-text">Aplica en compras a partir de $180,000. Sumá todo lo que quieras al carrito.</p>
                        </div>
                    </div>
                    <div class="card d-flex align-items-center bg-dark-subtle">
                        <img src="Images/Home/tarjeta-de-credito.png" style="width: 5rem" class="card-img-top pt-2" alt="...">
                        <div class="card-body">
                            <h5 class="card-title h5 text-primary-emphasis ">Elegí tu medio de pago favorito</h5>
                            <p class="card-text">
                                Pagá con tarjeta o en efectivo. Tu dinero está protegido con Mercado Pago.

                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>





</asp:Content>
