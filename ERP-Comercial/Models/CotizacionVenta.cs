﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGCComercial.Models
{
    [Table("CotizacionVenta")]

    public class CotizacionVenta
    {
        [Key]
        public String Folio { get; set; }

        public String RFC_Cli { get; set; }
        public virtual Cliente Clientes { get; set; }
        public String IDProducto { get; set; }
        public virtual Producto Productos { get; set; }
        public String IDUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int Cantidad { get; set; }
        public String Descripcion { get; set; }
        public float Precio { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Remision Remision { get; set; }
    }
}