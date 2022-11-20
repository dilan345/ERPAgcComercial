<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="Cotizaciones.aspx.cs" Inherits="AgcCiomercial.Views.Paginas.Cotizaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cotizaciones</title>
    <link href="../Estilos/Cotizaciones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Fondo">
                <div class="container text-center text-light">
                    <br />
                    <h1>Cotizaciones</h1>
                    <p>Para hacer la búsqueda de una cotización puede ser mediante el nombre del cliente o por el folio</p>
                    <br />
                    <div class="row g-3 text-center ">

                        <div class="col-4 align-self-center">
                            <h4>Nombre del cliente</h4>
                        </div>
                        <div class="col-7 align-self-center">
                            <nav class="navbar" style="background:transparent;">
                                <div class="container-fluid">
                                    <form class="d-flex" role="search">
                                        <input class="form-control me-2" type="search" placeholder="Cliente" aria-label="Search" style="width: 85%;" />
                                        <button class="btn btn" type="submit">Search</button>
                                    </form>
                                </div>
                            </nav>

                        </div>
                    </div>

                    <br />

                    <div class="row g-3 text-center ">

                        <div class="col-4 align-self-center">
                            <h4>Folio</h4>
                        </div>
                        <div class="col-7 align-self-center">
                            <nav class="navbar" style="background:transparent;">
                                <div class="container-fluid">
                                    <form class="d-flex" role="search">
                                        <input class="form-control me-2" type="search" placeholder="Folio" aria-label="Search" style="width: 85%;" />
                                        <button class="btn btn" type="submit">Search</button>
                                    </form>
                                </div>
                            </nav>
                        </div>
                    </div>
                    <br />
                    <%-- GridView --%>
                    <div class="row g-3 text-center border border-primary">
                        <asp:GridView ID="GridCotizaciones" runat="server"></asp:GridView>
                    </div>
                    <br />
                    <div class="row g-3 justify-content-center text-center">
                        <a href="NuevaCotizacion.aspx"><i class="fa-solid fa-circle-plus"></i></a>
                        <h5>Nueva Cotización</h5>
                    </div>
                </div>

            </div>

</asp:Content>
