namespace proyectoFinal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo1")
        {
        }

        public virtual DbSet<cita> cita { get; set; }
        public virtual DbSet<consulta> consulta { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<mascota> mascota { get; set; }
        public virtual DbSet<Medicamento> Medicamento { get; set; }
        public virtual DbSet<Propietario_Mascota> Propietario_Mascota { get; set; }
        public virtual DbSet<recetaDetalle> recetaDetalle { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<tipo_mascota> tipo_mascota { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<veterinario> veterinario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cita>()
                .Property(e => e.fecha)
                .IsUnicode(false);

            modelBuilder.Entity<cita>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<consulta>()
                .Property(e => e.diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<consulta>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<consulta>()
                .HasMany(e => e.recetaDetalle)
                .WithOptional(e => e.consulta)
                .HasForeignKey(e => e.idConsulta)
                .WillCascadeOnDelete();

            modelBuilder.Entity<estado>()
                .Property(e => e.estado1)
                .IsUnicode(false);

            modelBuilder.Entity<mascota>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<mascota>()
                .Property(e => e.peso)
                .IsUnicode(false);

            modelBuilder.Entity<mascota>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamento>()
                .Property(e => e.Medicamento1)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario_Mascota>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario_Mascota>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario_Mascota>()
                .Property(e => e.dui)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario_Mascota>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario_Mascota>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Propietario_Mascota>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<recetaDetalle>()
                .Property(e => e.dosis)
                .IsUnicode(false);

            modelBuilder.Entity<rol>()
                .Property(e => e.rol1)
                .IsUnicode(false);

            modelBuilder.Entity<rol>()
                .HasMany(e => e.usuario)
                .WithOptional(e => e.rol)
                .HasForeignKey(e => e.id_rol);

            modelBuilder.Entity<tipo_mascota>()
                .Property(e => e.especie)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.cita)
                .WithOptional(e => e.usuario)
                .HasForeignKey(e => e.codusuario);

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
