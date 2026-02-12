using System;
using System.Collections.Generic;
using System.Text;

namespace FrmManipulacionDatos
{
    public  class Venta
    {
        public int ClienteId { get; set; }

        public string NombreCliente { get; set; }

        public int Edad { get; set; }

        public String saborGalleta { get; set; }

        public int cantidad { get; set; }

        public DateTime FechaCompra { get; set; }

        public int OrdenID { get; set; }

    }
}
