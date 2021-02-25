using Backend.Inhumaciones.Entities.Models.Administracion;
using Microsoft.EntityFrameworkCore;


namespace Backend.Inhumaciones.Repositories.Context
{
    public partial class AdministracionContext : DbContext
    {
        public AdministracionContext(DbContextOptions<AdministracionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PRIMARY");

                entity.ToTable("menu");

                entity.HasIndex(e => e.Titulo)
                    .HasName("UQ_Menu_Titulo")
                    .IsUnique();

                entity.Property(e => e.IdMenu).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("bit(1)");

                entity.Property(e => e.Icono)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdMenuPadre).HasColumnType("int(11)");

                entity.Property(e => e.IdModulo).HasColumnType("int(11)");

                entity.Property(e => e.IdPermiso).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuaioModifica).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuarioCrea).HasColumnType("int(11)");

                entity.Property(e => e.Orden).HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PRIMARY");

                entity.ToTable("modulo");

                entity.Property(e => e.IdModulo).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnType("bit(1)");

                entity.Property(e => e.Icono)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuModi).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuarioCrea).HasColumnType("int(11)");

                entity.Property(e => e.ModuloPadre).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenMenu).HasColumnType("int(11)");

                entity.Property(e => e.Permiso).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
