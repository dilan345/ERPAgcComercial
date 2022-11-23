<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="CatalogoClientes.aspx.cs" Inherits="ERP_Comercial.Vistas.Paginas.CatalogoClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/CatalogoCli.css" rel="stylesheet" />
    <title>Clientes</title>
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
            <asp:ImageButton ID="AgregarCliente" runat="server" CssClass="AgregarCliente" ImageUrl="~/Vistas/Estilos/Recursos/circle-plus-solid.svg" />
        </div>
    </div>
</asp:Content>
