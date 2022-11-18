using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace assessmentV2.Models;

public partial class PuntonetdbContext : DbContext
{
    public PuntonetdbContext()
    {
    }

    public PuntonetdbContext(DbContextOptions<PuntonetdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Claim> Claims { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QS6HK1O;Database=puntonetdb;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Claim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__claims__3213E83F45AA200A");

            entity.ToTable("claims");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Status)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__owners__3213E83FA68138DC");

            entity.ToTable("owners");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DriverLicense)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("driverLicense");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("lastName");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vehicles__3213E83FCE593A9C");

            entity.ToTable("vehicles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("brand");
            entity.Property(e => e.Color)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ownerId");
            entity.Property(e => e.Vin)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("vin");
            entity.Property(e => e.Year)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
