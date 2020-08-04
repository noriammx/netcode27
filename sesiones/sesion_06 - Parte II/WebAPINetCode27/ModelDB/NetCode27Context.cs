using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPINetCode27.ModelDB
{
    public partial class NetCode27Context : DbContext
    {
        public NetCode27Context()
        {
        }

        public NetCode27Context(DbContextOptions<NetCode27Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Personas> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=NetCode27;User Id=sa;Password=Corepro1;"); 

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>(entity =>
            {
                entity.Property(e => e.ApMaterno).IsRequired();

                entity.Property(e => e.ApPaterno).IsRequired();

                entity.Property(e => e.Nombre).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
