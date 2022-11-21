using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ERP_Comercial
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapPageRoute("Menu", "menu", "~/Vistas/Paginas/Menu.aspx");
            RouteTable.Routes.MapPageRoute("BorrarJWT", "Logout", "~/Vistas/Logout.aspx");
            RouteTable.Routes.MapPageRoute("CerrarSesion", "Login", "~/Vistas/Login.aspx");


            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
