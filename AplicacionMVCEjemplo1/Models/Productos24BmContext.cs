using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AplicacionMVCEjemplo1.Models;

public partial class Productos24BmContext : DbContext
{
    public Productos24BmContext()
    {
    }

    public Productos24BmContext(DbContextOptions<Productos24BmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fabricante> Fabricantes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer( );

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fabricante>(entity =>
        {
            entity.HasKey(e => e.Pkfabricante).HasName("PK__fabrican__378A77C0F3D154D4");

            entity.ToTable("fabricante");

            entity.Property(e => e.Pkfabricante).HasColumnName("PKFabricante");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Pkproducto).HasName("PK__producto__DA8DC682467C117B");

            entity.ToTable("producto");

            entity.Property(e => e.Pkproducto).HasColumnName("PKProducto");
            entity.Property(e => e.Fkfabricante).HasColumnName("FKFabricante");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");

            entity.HasOne(d => d.FkfabricanteNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.Fkfabricante)
                .HasConstraintName("FK__producto__FKFabr__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
