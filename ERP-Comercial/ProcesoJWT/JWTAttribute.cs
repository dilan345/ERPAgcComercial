﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ERP_Comercial.ProcesoJWT
{
    public class JWTAttribute : ActionFilterAttribute
    {
        private CrearJWT clave = new CrearJWT();

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            try
            {
                string token = actionContext.Request.Headers.GetValues("Authorization").FirstOrDefault();
                if (token == "Bearer")
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
                else
                {
                    Epoch epoch = new Epoch();

                    double ahora = epoch.convertirEpoch(DateTime.Now);

                    string tokenO = token.Substring(7);
                    string payload = Jose.JWT.Decode(tokenO, clave.GetSecretKey());

                    JSONwt empleadoJwt = JsonConvert.DeserializeObject<JSONwt>(payload);

                    if (ahora <= empleadoJwt.Exp)
                    {
                        actionContext.Request.Properties.Add("payload", payload);
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                    }
                }
            }
            catch (Exception ex)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            base.OnActionExecuting(actionContext);
        }
    }
}