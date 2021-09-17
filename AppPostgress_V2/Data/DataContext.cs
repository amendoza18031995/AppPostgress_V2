using AppPostgress_V2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPostgress_V2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Arl> arl { get; set; }
        public DbSet<contralaborales> contratoslaborales { get; set; }
        public DbSet<Cargos> cargos { get; set; }
        public DbSet<Nomina> novedadesnomina { get; set; }
        //public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=amendoza123");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cargos>()
                .HasIndex(t => t.idcargo)
                .IsUnique();

        }

    }
}
