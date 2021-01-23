using Microsoft.EntityFrameworkCore;
using ProyectoRegistro.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRegistro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionPersonas.Db");
        }
    }
}
