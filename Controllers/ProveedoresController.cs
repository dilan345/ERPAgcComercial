using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class ProveedoresController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar proveedor a la base de datos-----------//

        [ActionName("AgregarProveedor")]
        [HttpPost]

        public bool AgregarProveedor(Proveedors proveedors)
        {
            try
            {
                bd.Proveedors.Add(proveedors);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un proveedor de la base de datos-----------//

        [ActionName("MostrarProveedor")]
        [HttpGet]

        public IQueryable<ProveedoresDTO> Get(String id)
        {
            IQueryable<ProveedoresDTO> proveedoresDTOs = from proveedores in bd.Proveedors
                                                     where proveedores.RFC == id
                                                     select new ProveedoresDTO
                                                     {
                                                        RFC = proveedores.RFC,
                                                        Empresa = proveedores.Empresa,
                                                        RazonSocial = proveedores.RazonSocial,
                                                        Contacto = proveedores.Contacto,
                                                        Categoria = proveedores.Categoria,
                                                        Giro = proveedores.Giro,
                                                        Telefono = proveedores.Telefono,
                                                        Correo = proveedores.Correo,   
                                                        Direccion = proveedores.Direccion,
                                                        Zona = proveedores.Zona
                                                     };
            return proveedoresDTOs;
        }

        //-------Controlador para mostrar proveedores de la base de datos-----------//

        [ActionName("MostrarProveedores")]
        [HttpGet]

        public IQueryable<ProveedoresDTO> Get()
        {
            IQueryable<ProveedoresDTO> proveedoresDTOs = from proveedores in bd.Proveedors
                                                         select new ProveedoresDTO
                                                         {
                                                             RFC = proveedores.RFC,
                                                             Empresa = proveedores.Empresa,
                                                             RazonSocial = proveedores.RazonSocial,
                                                             Contacto = proveedores.Contacto,
                                                             Categoria = proveedores.Categoria,
                                                             Giro = proveedores.Giro,
                                                             Telefono = proveedores.Telefono,
                                                             Correo = proveedores.Correo,
                                                             Direccion = proveedores.Direccion,
                                                             Zona = proveedores.Zona
                                                         };
            return proveedoresDTOs;
        }



        //-------Controlador para Actualizar proveedor de la base de datos-----------//

        [ActionName("ActualizarProveedor")]
        [HttpPut]

        public bool ActualizarProveedor(Proveedors proveedors)
        {
            try
            {
                bd.Entry(proveedors).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar producto de la base de datos-----------//


        [ActionName("BorrarProveedor")]
        [HttpDelete]

        public bool BorrarProveedor(string id)
        {
            try
            {
                Proveedors provedor = bd.Proveedors.Find(id);
                bd.Entry(provedor).State = System.Data.Entity.EntityState.Deleted;
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
