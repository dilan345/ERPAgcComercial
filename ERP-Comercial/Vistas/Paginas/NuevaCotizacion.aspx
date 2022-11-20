﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="NuevaCotizacion.aspx.cs" Inherits="AgcCiomercial.Views.Paginas.NuevaCotizacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>NuevaCotizacon</title>
    <link href="../Estilos/NuevaCo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container text-center text-light">
            <br /><br /><br /><br />
            <div class="From border border-dark">
                <br />
                <h1 style="color: #0f777e;">Nueva Cotizacióon</h1>
                <h5>Busque un articulo de la base de datos, al buscarlo se mostrara las especificaciones de este en patalla, de ser el caso de no encontrar el articulo esta el botón de agregar productos al catálogo, tambien esta el botón para visualizar los productos registrados para la cotización así como el botón para guardar la cotización si se pausa el desarrollo de esta</h5>
                <br />
                <%-- Buscar producto --%>
                <div class="row">
                    <div class="col">
                        <h4 style="margin-top:10px;">Producto</h4>
                    </div>
                    <div class="col">
                        <nav class="navbar" style="background:transparent;">
                                <div class="container">
                                    <form class="d-flex" role="search">
                                        <input class="form-control me-2" type="search" placeholder="Producto" aria-label="Search" style="width: 70%;" />
                                        <asp:ImageButton ID="Search" runat="server" class="Search" ImageUrl="~/Views/Estilos/Recursos/magnifying-glass-solid.svg"/>
                                    </form>
                                </div>
                            </nav>
                    </div>
                </div>
                <br />
                <%-- Descripcion --%>
                <div class="row">
                    <div class="col">
                        <h4>Descripción</h4>
                    </div>
                    <div class="col justify-content-center">
                        <asp:Label ID="descripcion" runat="server" Text="Aqui va el texto dilan" Class="texto"></asp:Label>
                    </div>
                </div>
                <br />
                <%-- Imagen --%>
                <div class="row">
                    <div class="col">
                        <h4>Imagen</h4>
                    </div>
                    <div class="col border border-danger">
                        <asp:Image ID="ProductoCoti" runat="server" />
                    </div>
                </div>
                <br />
                <%-- Cantidad --%>
                <div class="row">
                    <div class="col">
                        <h4>Cantidad</h4>
                    </div>
                    <div class="col justify-content-center">
                        <input type="number" id="cantidad" name="cantidad" style="text-align:center;">
                    </div>
                </div>
                <br />
                <%-- Precio --%>
                <div class="row">
                    <div class="col">
                        <h4>Precio</h4>
                    </div>
                    <div class="col text-center">
                        <asp:Label ID="precio" runat="server" Text="Aqui va el texto dilan" Class="texto"></asp:Label>
                    </div>
                </div>
                <br />
                <%-- Area --%>
                <div class="row">
                    <div class="col">
                        <h4>Área</h4>
                    </div>
                    <div class="col">
                        <asp:Label ID="Area" runat="server" Text="Aqui va el texto dilan" Class="texto"></asp:Label>
                    </div>
                </div>
                <br />
            </div>
            <br /><br />
            <div class="row">
                <div class="col">
                    <a href="#"><i class="fa-solid fa-table"></i></a>
                    <h5>Ver Tabla de productos cotizados</h5>
                </div>
                <div class="col">
                    <asp:ImageButton ID="Agregar" runat="server" Class="Agregar" ImageUrl="~/Views/Estilos/Recursos/Check.png" />
                    <h5>Agregar a la cotización</h5>
                </div>
                <div class="col">
                    <a href="#"><i class="fa-solid fa-circle-plus"></i></a>
                    <h5>Agregar producto al catálogo</h5>
                </div>
            </div>
            <br />
        </div>
    </div>
</asp:Content>
