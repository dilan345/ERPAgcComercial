<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="CatalogoClientes.aspx.cs" Inherits="AgcCiomercial.Views.Paginas.CatalogoClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Clientes</title>
    <link href="../Estilos/CatalogoCl.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="container-fluid text-center text-light">
            <br /><br /><br /><br /><br />
            <h1>Catálogo de clientes</h1>
            <br />
            <div class="row border">
                <asp:GridView ID="Cliente" runat="server"></asp:GridView>
            </div>
            <br />
            <asp:ImageButton ID="AgregarCliente" runat="server" CssClass="AgregarCliente" ImageUrl="~/Views/Estilos/Recursos/circle-plus-solid.svg" />
        </div>
    </div>
</asp:Content>
