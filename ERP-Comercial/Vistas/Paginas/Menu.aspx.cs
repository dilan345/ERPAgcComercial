using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERP_Comercial.Vistas.Paginas
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["jwt"] != null)
            {
                String Nombre = (String)Session["UsuarioActivo"];

                string mensaje1 = ("Bienvenido: " + Nombre + "');</script>");
                string mensaje2 = (@"<script type='text/javascript'>alert('" + mensaje1);

                ScriptManager.RegisterStartupScript(this, typeof(Page), "InicioSesion", mensaje2, false);
            }

            
        }
    }
}