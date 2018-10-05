namespace ApiClinica.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<veterinario> veterinario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<veterinario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<veterinario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<veterinario>()
                .Property(e => e.dui)
                .IsUnicode(false);

            modelBuilder.Entity<veterinario>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<veterinario>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<veterinario>()
                .Property(e => e.direccion)
                .IsUnicode(false);
        }
    }
}
