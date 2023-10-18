using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class BaseDeDato : DbContext
    {
        public BaseDeDato(DbContextOptions<BaseDeDato> opcion) : base(opcion)
        {

        }
        private DbSet<Tabla> Tabla { get; set; }
    }
}