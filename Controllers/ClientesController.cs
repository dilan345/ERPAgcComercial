using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class ClientesController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar clientes a la base de datos-----------//

        [ActionName("CrearCliente")]
        [HttpPost]

        public bool CrearCliente(Clientes clientes)
        {
            try
            {
                bd.Clientes.Add(clientes);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar cliente de la base de datos-----------//

        [ActionName(" ")]
        [HttpGet]

        public IQueryable<ClientesDTO> Get(String id)
        {
            IQueryable<ClientesDTO> clientesDTOs = from clientes in bd.Clientes
                                                   where clientes.RFC_Cli == id
                                                   select new ClientesDTO
                                                   {
                                                       RFC_Cli = clientes.RFC_Cli,
                                                       Nombre = clientes.Nombre,
                                                       Direccion = clientes.Direccion,
                                                       Telefono = clientes.Telefono,
                                                       Correo = clientes.Correo,
                                                   };
            return clientesDTOs;
        }

        //-------Controlador para mostrar los clientes de la base de datos-----------//

        [ActionName("MostrarClientes")]
        [HttpGet]

        public IQueryable<ClientesDTO> Get()
        {
            IQueryable<ClientesDTO> clientesDTOs = from clientes in bd.Clientes
                                                   select new ClientesDTO
                                                   {
                                                       RFC_Cli = clientes.RFC_Cli,
                                                       Nombre = clientes.Nombre,
                                                       Direccion = clientes.Direccion,
                                                       Telefono = clientes.Telefono,
                                                       Correo = clientes.Correo,
                                                   };
            return clientesDTOs;
        }


        //-------Controlador para Actualizar clientes de la base de datos-----------//

        [ActionName("ActualizarCliente")]
        [HttpPut]

        public bool ActualizarCliente(Clientes Clientes)
        {
            try
            {
                bd.Entry(Clientes).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar cliente de la base de datos-----------//


        [ActionName("BorrarCliente")]
        [HttpDelete]

        public bool BorrarCliente(string id)
        {
            try
            {
                Clientes clientes = bd.Clientes.Find(id);
                bd.Entry(clientes).State = System.Data.Entity.EntityState.Deleted;
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
