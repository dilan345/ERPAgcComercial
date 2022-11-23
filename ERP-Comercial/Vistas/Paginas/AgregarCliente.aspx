﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PaginasMaestras/Home.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="ERP_Comercial.Vistas.Paginas.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/NuevoCli.css" rel="stylesheet" />
    <title>NuevoCliente</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Fondo">
        <div class="Fondo">

                <div class="container justify-content-center text-center">
                    <br /><br /><br /><br /><br /><br /><br />
                    <div class="From ">

                        <br />
                        <h1><b>Nuevo Proveedor</b></h1>
                        <br />
                        <br />

                        <div class="row g-3 text-center">

                            <div class="col-6 align-self-center">
                                <h3>RFC</h3>
                            </div>

                            <div class="col-6 align-self-center align-items-center">

                                <div class="global">
                                    <div class="mensajes">
                                        <div class="texto justify-content-center align-self-center">
                                            <asp:TextBox ID="txtRFCClient" runat="server" Class="TextBox"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />

                        <div class="row g-3 text-center">

                            <div class="col-6 align-self-center">
                                <h3>Nombre</h3>
                            </div>

                            <div class="col-6 align-self-center align-items-center">

                                <div class="global">
                                    <div class="mensajes">
                                        <div class="texto justify-content-center align-self-center">
                                            <asp:TextBox ID="txtNom" runat="server" Class="TextBox"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />

                        <div class="row g-3 text-center">

                            <div class="col-6 align-self-center">
                                <h3>Dirección</h3>
                            </div>

                            <div class="col-6 align-self-center align-items-center">

                                <div class="global">
                                    <div class="mensajes">
                                        <div class="texto justify-content-center align-self-center">
                                            <asp:TextBox ID="txtDirecClient" runat="server" Class="TextBox"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />

                        <div class="row g-3 text-center">

                            <div class="col-6 align-self-center">
                                <h3>Teléfono</h3>
                            </div>

                            <div class="col-6 align-self-center align-items-center">

                                <div class="global">
                                    <div class="mensajes">
                                        <div class="texto justify-content-center align-self-center">
                                            <asp:TextBox ID="txttelClient" runat="server" Class="TextBox"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />

                        <div class="row g-3 text-center">

                            <div class="col-6 align-self-center">
                                <h3>Correo</h3>
                            </div>

                            <div class="col-6 align-self-center align-items-center">

                                <div class="global">
                                    <div class="mensajes">
                                        <div class="texto justify-content-center align-self-center">
                                            <asp:TextBox ID="txtEmailClient" runat="server" Class="TextBox"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />

                        <div class="row g-3 text-center">

                            <div class=" align-self-center align-items-center">
                                <asp:Button ID="btnGuardarClient" runat="server" Text="Guardar" class="btn border border-white btn-lg" />
                            </div>
                        </div>

                        <br />
                    </div>
                <br /><br /><br /><br /><br />
                    <br />
                </div>

            </div>

    </div>
</asp:Content>
