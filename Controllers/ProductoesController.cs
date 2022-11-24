using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class ProductoesController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar productos a la base de datos-----------//

        [ActionName("AgregarProducto")]
        [HttpPost]

        public bool AgregarProducto(Productoes productoes)
        {
            try
            {
                bd.Productoes.Add(productoes);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un producto de la base de datos-----------//

        [ActionName("MostrarProducto")]
        [HttpGet]

        public IQueryable<ProductosDTO> Get(String id)
        {
            IQueryable<ProductosDTO> productosDTOs = from productos in bd.Productoes
                                                 where productos.IDProducto == id
                                                 select new ProductosDTO
                                                 {
                                                    IDProducto = productos.IDProducto,
                                                    Nombre = productos.Nombre,
                                                    Descripcion = productos.Descripcion,
                                                    Precio = productos.Precio,
                                                    Categoria = productos.Categoria
                                                 };
            return productosDTOs;
        }

        //-------Controlador para mostrar productos de la base de datos-----------//

        [ActionName("MostrarProductos")]
        [HttpGet]

        public IQueryable<ProductosDTO> Get()
        {
            IQueryable<ProductosDTO> productosDTOs = from productos in bd.Productoes
                                                     select new ProductosDTO
                                                     {
                                                         IDProducto = productos.IDProducto,
                                                         Nombre = productos.Nombre,
                                                         Descripcion = productos.Descripcion,
                                                         Precio = productos.Precio,
                                                         Categoria = productos.Categoria
                                                     };
            return productosDTOs;
        }



        //-------Controlador para Actualizar producto de la base de datos-----------//

        [ActionName("ActualizarProducto")]
        [HttpPut]

        public bool ActualizarProducto(Productoes productoes)
        {
            try
            {
                bd.Entry(productoes).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar producto de la base de datos-----------//


        [ActionName("BorrarProducto")]
        [HttpDelete]

        public bool BorrarProducto(string id)
        {
            try
            {
                Productoes productoes = bd.Productoes.Find(id);
                bd.Entry(productoes).State = System.Data.Entity.EntityState.Deleted;
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
