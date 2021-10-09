using EjecicioSeccionB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjecicioSeccionB.Connection
{
    public class Conn : DbContext
    {
        public Conn(DbContextOptions<Conn> options) : base(options) { }

        public DbSet<PersonaModel> tbl_personas { get; set; }
    }
}
