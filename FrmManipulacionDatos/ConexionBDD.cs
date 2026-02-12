using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FrmManipulacionDatos
{

    public class ConexionBDD : DbContext
    {
        public DbSet<Venta> ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LILY\\SQLEXPRESS;Initial Catalog=InventarioVentasGalletas;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
