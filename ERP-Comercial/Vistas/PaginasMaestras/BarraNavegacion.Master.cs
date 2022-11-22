﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERP_Comercial.Vistas.PaginasMaestras
{
    public partial class BarraNavegacion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.RedirectToRoute(Ventas.SelectedItem.Value);
        }
    }
}