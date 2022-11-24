using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ControladoresAGC.Models;

namespace ControladoresAGC.Controllers
{
    public class CotizacionVentaController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar Cotizaciones a la base de datos-----------//

        [ActionName("CrearCotizacion")]
        [HttpPost]

        public bool CrearCotizacion(CotizacionVentas cotizacion)
        {
            try
            {
                bd.CotizacionVentas.Add(cotizacion);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar una cotizacion de la base de datos-----------//

        [ActionName("MostrarCotizacion")]
        [HttpGet]

        public IQueryable<CotizacionDTO> Get(String id)
        {
            IQueryable<CotizacionDTO> CotizacionesDTOs = from cotizaciones in bd.CotizacionVentas
                                                   where cotizaciones.Folio == id
                                                   select new CotizacionDTO
                                                   {
                                                      Folio = cotizaciones.Folio,
                                                      RFC_Cli = cotizaciones.RFC_Cli,
                                                      IDProducto = cotizaciones.IDProducto,
                                                      IDUsuario = cotizaciones.IDUsuario,
                                                      Cantidad = cotizaciones.Cantidad,
                                                      Descripcion = cotizaciones.Descripcion,
                                                      Precio = cotizaciones.Precio,
                                                      Total = cotizaciones.Total,   
                                                      Fecha = cotizaciones.Fecha,
                                                      Remision_FolioRemision = cotizaciones.Remision_FolioRemision
                                                   };
            return CotizacionesDTOs;
        }



        //-------Controlador para Actualizar cotizacion de la base de datos-----------//

        [ActionName("ActualizarCotizacion")]
        [HttpPut]

        public bool ActualizarCotizacion(CotizacionVentas cotizacion)
        {
            try
            {
                bd.Entry(cotizacion).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar cotizacion de la base de datos-----------//


        [ActionName("BorrarCotizacion")]
        [HttpDelete]

        public bool BorrarCotizacion(string id)
        {
            try
            {
                CotizacionVentas cotizacion = bd.CotizacionVentas.Find(id);
                bd.Entry(cotizacion).State = System.Data.Entity.EntityState.Deleted;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
