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


            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
