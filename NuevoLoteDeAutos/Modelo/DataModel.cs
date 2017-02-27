namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<autos> autos { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<permisos> permisos { get; set; }
        public virtual DbSet<permisosnegadosrol> permisosnegadosrol { get; set; }
        public virtual DbSet<propietarios> propietarios { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<ventas> ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<autos>()
                .Property(e => e.sMarca)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .Property(e => e.sPlaca)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .Property(e => e.sColor)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .Property(e => e.sNacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .Property(e => e.foto1)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .Property(e => e.foto2)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .Property(e => e.foto3)
                .IsUnicode(false);

            modelBuilder.Entity<autos>()
                .HasMany(e => e.ventas)
                .WithOptional(e => e.autos)
                .HasForeignKey(e => e.auto_pkAuto);

            modelBuilder.Entity<clientes>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.sDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .HasMany(e => e.propietarios)
                .WithOptional(e => e.clientes)
                .HasForeignKey(e => e.Cliente_pkCliente);

            modelBuilder.Entity<clientes>()
                .HasMany(e => e.ventas)
                .WithOptional(e => e.clientes)
                .HasForeignKey(e => e.cliente_pkCliente);

            modelBuilder.Entity<permisos>()
                .Property(e => e.sModulo)
                .IsUnicode(false);

            modelBuilder.Entity<permisos>()
                .Property(e => e.sDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<permisos>()
                .HasMany(e => e.permisosnegadosrol)
                .WithOptional(e => e.permisos)
                .HasForeignKey(e => e.permiso_pkPermiso);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sCorreo)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.iIfe)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .Property(e => e.sFoto)
                .IsUnicode(false);

            modelBuilder.Entity<propietarios>()
                .HasMany(e => e.autos)
                .WithOptional(e => e.propietarios)
                .HasForeignKey(e => e.Propietario_pkPropietario);

            modelBuilder.Entity<roles>()
                .Property(e => e.sNombre)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .Property(e => e.sDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.permisosnegadosrol)
                .WithOptional(e => e.roles)
                .HasForeignKey(e => e.rol_pkRol);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.usuarios)
                .WithOptional(e => e.roles)
                .HasForeignKey(e => e.rol_pkRol);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.sEmail)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.sPassword)
                .IsUnicode(false);

            modelBuilder.Entity<ventas>()
                .Property(e => e.sConcepto)
                .IsUnicode(false);
        }
    }
}
