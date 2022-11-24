using ControladoresAGC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ControladoresAGC.Controllers
{
    public class UsuariosController : ApiController
    {
        Model2 bd = new Model2();

        //-------Controlador para agregar usuario a la base de datos-----------//

        [ActionName("AgregarUsuario")]
        [HttpPost]

        public bool AgregarUsuario(Usuarios usuarios)
        {
            try
            {
                bd.Usuarios.Add(usuarios);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para mostrar un Usuario de la base de datos-----------//

        [ActionName("MostrarUsuario")]
        [HttpGet]

        public IQueryable<UsuariosDTO> Get(String id)
        {
            IQueryable<UsuariosDTO> usuariosDTOs = from Usuario in bd.Usuarios
                                                       where Usuario.IDUsuario == id
                                                       select new UsuariosDTO
                                                       {
                                                            IDUsuario = Usuario.IDUsuario,
                                                            Nombre = Usuario.Nombre,
                                                            NomUsuario = Usuario.NomUsuario,
                                                            Contraseña = Usuario.Contraseña,
                                                            Correo = Usuario.Correo,
                                                            Perfil = Usuario.Perfil
                                                       };
            return usuariosDTOs;
        }

        //-------Controlador para mostrar Usuarios de la base de datos-----------//

        [ActionName("MostrarUsuarios")]
        [HttpGet]

        public IQueryable<UsuariosDTO> Get()
        {
            IQueryable<UsuariosDTO> usuariosDTOs = from Usuario in bd.Usuarios
                                                   select new UsuariosDTO
                                                   {
                                                       IDUsuario = Usuario.IDUsuario,
                                                       Nombre = Usuario.Nombre,
                                                       NomUsuario = Usuario.NomUsuario,
                                                       Contraseña = Usuario.Contraseña,
                                                       Correo = Usuario.Correo,
                                                       Perfil = Usuario.Perfil
                                                   };
            return usuariosDTOs;
        }




        //-------Controlador para Actualizar Usuario de la base de datos-----------//

        [ActionName("ActualizarUsuario")]
        [HttpPut]

        public bool ActualizarUsuario(Usuarios usuarios)
        {
            try
            {
                bd.Entry(usuarios).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //-------Controlador para eliminar usuario de la base de datos-----------//


        [ActionName("BorrarUsuario")]
        [HttpDelete]

        public bool BorrarUsuario(string id)
        {
            try
            {
                Usuarios usuarios = bd.Usuarios.Find(id);
                bd.Entry(usuarios).State = System.Data.Entity.EntityState.Deleted;
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
