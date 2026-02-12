using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FrmPrincipal
{
    public  class Venta
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        public string NombreCliente { get; set; }

        public int Edad { get; set; }

        public String saborGalleta { get; set; }

        public int cantidad { get; set; }

        public DateTime FechaCompra { get; set; }

        public int OrdenID { get; set; }

    }
}
