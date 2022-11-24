using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class PedidoesController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar pedidos a la base de datos-----------//

        [ActionName("AgregarPedido")]
        [HttpPost]
          
        public bool CrearPedido(Pedidoes pedidoes)
        {
            try
            {
                bd.Pedidoes.Add(pedidoes);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un pedido de la base de datos-----------//

        [ActionName("MostrarPedido")]
        [HttpGet]

        public IQueryable<pedidosDTO> Get(String id)
        {
            IQueryable<pedidosDTO> pedidosDTOs = from pedidos in bd.Pedidoes
                                                   where pedidos.PedidoID == id
                                                   select new pedidosDTO
                                                   {
                                                       PedidoID = pedidos.PedidoID,
                                                       RFC = pedidos.RFC,
                                                       IDProducto = pedidos.IDProducto,
                                                       IDUsuario = pedidos.IDUsuario,
                                                       Cantidad = pedidos.Cantidad,
                                                       PrecioUnitario = pedidos.PrecioUnitario,
                                                       Total = pedidos.Total,
                                                       ClabeBancaria = pedidos.ClabeBancaria,
                                                       FechaInicio = pedidos.FechaInicio,
                                                       FechaVencimiento = pedidos.FechaVencimiento,
                                                   };
            return pedidosDTOs;
        }



        //-------Controlador para Actualizar pedido de la base de datos-----------//

        [ActionName("ActualizarPedido")]
        [HttpPut]

        public bool ActualizarPedido(Pedidoes pedidoes)
        {
            try
            {
                bd.Entry(pedidoes).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar pedido de la base de datos-----------//


        [ActionName("BorrarPedido")]
        [HttpDelete]

        public bool BorrarPedido(string id)
        {
            try
            {
                Pedidoes pedido = bd.Pedidoes.Find(id);
                bd.Entry(pedido).State = System.Data.Entity.EntityState.Deleted;
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
