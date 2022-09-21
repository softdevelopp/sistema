using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema.Models;
using Microsoft.EntityFrameworkCore;


namespace sistema.Datos
{
    public class contextoDB:DbContext
    {
        public contextoDB(DbContextOptions<contextoDB>options):base(options)
        {

        }
        public DbSet<cita>citas { get; set; }

    }
}
