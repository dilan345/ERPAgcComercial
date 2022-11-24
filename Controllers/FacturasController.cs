using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class FacturasController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar Fcturas a la base de datos-----------//

        [ActionName("CrearFactura")]
        [HttpPost]

        public bool CrearFactura(Facturas facturas)
        {
            try
            {
                bd.Facturas.Add(facturas);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar una Facturas de la base de datos-----------//

        [ActionName("MostrarFactura")]
        [HttpGet]

        public IQueryable<FacturasDTO> Get(String id)
        {
            IQueryable<FacturasDTO> facturasDTOs = from facturas in bd.Facturas
                                                         where facturas.FolioFac == id
                                                         select new FacturasDTO
                                                         {
                                                            FolioFac = facturas.FolioFac,
                                                            FolioRemision = facturas.FolioRemision,
                                                            PrecioUni = facturas.PrecioUni,
                                                            Importe = facturas.Importe,
                                                            Subtotal = facturas.Subtotal,
                                                            IVA = facturas.IVA,
                                                            Total = facturas.Total,
                                                            FechaHora = facturas.FechaHora, 
                                                            MetodoPago = facturas.MetodoPago,
                                                            FormaPago = facturas.FormaPago,
                                                         };
            return facturasDTOs;
        }



        //-------Controlador para Actualizar factura de la base de datos-----------//

        [ActionName("ActualizarFactura")]
        [HttpPut]

        public bool ActualizarFactura(Facturas facturas)
        {
            try
            {
                bd.Entry(facturas).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar factura de la base de datos-----------//


        [ActionName("BorrarFactura")]
        [HttpDelete]

        public bool Borrarfactura(string id)
        {
            try
            {
                Facturas facturas = bd.Facturas.Find(id);
                bd.Entry(facturas).State = System.Data.Entity.EntityState.Deleted;
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
