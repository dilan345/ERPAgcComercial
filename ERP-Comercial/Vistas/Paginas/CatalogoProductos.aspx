﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="AgcCiomercial.Views.Paginas.CatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Productos</title>
    <link href="../Estilos/CatalogoPr.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container-fluid text-center text-light">
            <br /><br /><br /><br /><br />
            <h1>Catálogo de productos</h1>
            <br />
            <div class="row border">
                <asp:DataList ID="Productos" runat="server">
                </asp:DataList>
            </div>
            <br />
            <asp:ImageButton ID="AgregarProducto" runat="server" CssClass="AgregarProducto" ImageUrl="~/Views/Estilos/Recursos/circle-plus-solid.svg" />
        </div>
    </div>
</asp:Content>
