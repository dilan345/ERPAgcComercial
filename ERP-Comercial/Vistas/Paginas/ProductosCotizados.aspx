<%@ Page Title="" Language="C#" MasterPageFile="~/Views/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="ProductosCotizados.aspx.cs" Inherits="AgcCiomercial.Views.Paginas.ProductosCotizados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ProductosCotizados</title>
    <link href="../Estilos/ProductoCot.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Fondo ">
        <div class="container-fluid text-center text-light">
            <br /><br /><br /><br/>
            <h1>Cotizaciones</h1>
            <br /><br /><br />
            <%-- GridView --%>
            <div class="row border border-danger">
                <asp:GridView ID="Productos" runat="server"></asp:GridView>
            </div>
            <br />

            <div class="row  <%-- border  border-primary--%> %>">
                <div class="col">
                    <asp:ImageButton ID="Atras" Class="Atras" ImageUrl="~/Views/Estilos/Recursos/arrow-left-solid.svg" runat="server" />
                    <h5>Átras</h5>
                </div>
                <%-- Confirmar cotizacion --%>
                <div class="col">
                    <asp:ImageButton ID="Confirmar" runat="server" class="Confirmar" ImageUrl="~/Views/Estilos/Recursos/Check.png"/>
                    <h5>Confirmar cotización</h5>
                </div>
                <%-- Descargar --%>
                <div class="col">
                    <asp:ImageButton ID="DescargarCotiza" ImageUrl="~/Views/Estilos/Recursos/download-solid.svg" runat="server" Class="Descargar" />
                    <h5>Descargar</h5>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
