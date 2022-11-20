<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="CatalogoProveedores.aspx.cs" Inherits="AgcCiomercial.Views.Paginas.CatalogoProveedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Proveedores</title>
    <link href="../Estilos/CatalogoProv.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container-fluid text-center text-light">
            <br /><br /><br /><br /><br />
            <h1>Catálogo de prodctos</h1>
            <br />
            <div class="row border">
                <asp:GridView ID="Proveedor" runat="server"></asp:GridView>
            </div>
            <br />
            <br />
            <asp:ImageButton ID="AgregarProveedor" runat="server" CssClass="AgregarProveedor" ImageUrl="~/Views/Estilos/Recursos/circle-plus-solid.svg" />
        </div>
    </div>
</asp:Content>
