using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class RemisionesController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar remision a la base de datos-----------//

        [ActionName("AgregarRemision")]
        [HttpPost]

        public bool Agregarremision(Remisions remisions)
        {
            try
            {
                bd.Remisions.Add(remisions);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar una remision de la base de datos-----------//

        [ActionName("MostrarRemision")]
        [HttpGet]

        public IQueryable<RemisionesDTO> Get(String id)
        {
            IQueryable<RemisionesDTO> remisionesDTOs = from remison in bd.Remisions
                                                         where remison.FolioRemision == id
                                                         select new RemisionesDTO
                                                         {
                                                            FolioRemision = remison.FolioRemision,
                                                            Folio = remison.Folio,
                                                            Responsable = remison.Responsable,
                                                            FechaEntrega = remison.FechaEntrega,
                                                            CotizacionVentas_Folio = remison.CotizacionVentas_Folio,
                                                            CotizacionVenta_Folio = remison.CotizacionVenta_Folio,
                                                            Factura_FolioFac = remison.Factura_FolioFac,
                                                         };
            return remisionesDTOs;
        }

        //-------Controlador para mostrar un proveedor de la base de datos-----------//

        [ActionName("MostrarRemisiones")]
        [HttpGet]

        public IQueryable<RemisionesDTO> Get()
        {
            IQueryable<RemisionesDTO> remisionesDTOs = from remison in bd.Remisions
                                                       select new RemisionesDTO
                                                       {
                                                           FolioRemision = remison.FolioRemision,
                                                           Folio = remison.Folio,
                                                           Responsable = remison.Responsable,
                                                           FechaEntrega = remison.FechaEntrega,
                                                           CotizacionVentas_Folio = remison.CotizacionVentas_Folio,
                                                           CotizacionVenta_Folio = remison.CotizacionVenta_Folio,
                                                           Factura_FolioFac = remison.Factura_FolioFac,
                                                       };
            return remisionesDTOs;
        }




        //-------Controlador para Actualizar remision de la base de datos-----------//

        [ActionName("ActualizarRemision")]
        [HttpPut]

        public bool ActualizarRemision(Remisions remisions)
        {
            try
            {
                bd.Entry(remisions).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar remision de la base de datos-----------//


        [ActionName("BorrarRemision")]
        [HttpDelete]

        public bool BorrarRemision(string id)
        {
            try
            {
                Remisions remisions = bd.Remisions.Find(id);
                bd.Entry(remisions).State = System.Data.Entity.EntityState.Deleted;
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
