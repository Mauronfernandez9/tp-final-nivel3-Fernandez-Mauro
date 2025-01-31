<%@ Page Title="" Language="C#" MasterPageFile="~/MasterNF.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Front.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .fontDropDown {
            font-size: 1.2rem !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>

       
    <div class="container">
        <div class="row mt-3 d-flex justify-content-lg-end">
            <div class="col-6 align-items-center justify-content-end d-flex">
                <label class="text-bg-dark text-nowrap me-2">Ordenar por:</label>
                <asp:DropDownList CssClass="form-select-sm form-select-sm bg-secondary text-bg-dark" ID="ddlOrdenar" OnTextChanged="ddlOrdenar_TextChanged" AutoPostBack="true" runat="server">
                    <asp:ListItem Text="" />
                    <asp:ListItem Text="Menor Precio" />
                    <asp:ListItem Text="Mayor Precio" />
                </asp:DropDownList>
            </div>

        </div>
        <div class="row mt-3">
            <div class="col text-light">
                <div class="row mb-3">
                    <div class="col"><asp:Label CssClass="h1" Text="Productos" runat="server" /></div>
                </div>
                <div class="row">
                    <div class="col-7 d-flex flex-column ">
                        <label>Categorías</label>
                        <asp:DropDownList runat="server" ID="ddlCategorias" AutoPostBack="true" OnSelectedIndexChanged="ddlCategorias_SelectedIndexChanged" CssClass="form-select-sm mt-3 text-bg-secondary">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row mt-5">
                    <div class="col d-flex flex-column align-items-start">
                        <label class="mb-3">Marcas</label>
                        <asp:Repeater ID="repetidorMarcas" runat="server">
                            <ItemTemplate>
                                <button type="button" class="btn btn-secondary mb-3"><%#Eval("Descripcion") %></button>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                
            </div>
            <div class="col-7 d-flex flex-column  flex-lg-wrap justify-content-lg-evenly">
                
                    
                        <asp:Repeater runat="server" ID="repetidorArticulos">
                            <ItemTemplate>
                                <a href="ProductoDetalles.aspx?id=<%#Eval("Id") %>" class="card mb-3 text-decoration-none" style="max-width: 540px;">
                                     <div class="row g-0">
                                             <div class="col-md-4">
                                                 <img src="<%#Eval("UrlImagen") %>" class="img-fluid rounded-start" alt="..." style="max-height: 200px; max-width: 150px">
                                             </div>
                                             <div class="col-md-8">
                                                 <div class="card-body d-flex flex-column align-items-center" "height: 50%;>
                                                     <h5 class=" fst-italic mb-4 fs-6 fw-lighter"><%#Eval("Nombre") %></h5>
                                                     <p class="text-lg-center text-nowrap font-monospace fs-3 fw-semibold">$<%#Eval("Precio") %></p>
                                                 </div>
                                           </div>
                                     </div>
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>
                  
              
                

            </div>
        </div>

    </div>
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
