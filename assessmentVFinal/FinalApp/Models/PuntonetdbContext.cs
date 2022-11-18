using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FinalApp.Models;

namespace FinalApp.Models;

public partial class PuntonetdbContext : DbContext
{
    public PuntonetdbContext()
    {
    }

    public PuntonetdbContext(DbContextOptions<PuntonetdbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QS6HK1O;Database=puntonetdb;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Owner> Owner { get; set; }

    public DbSet<Vehicle> Vehicle { get; set; }

    public DbSet<Claim> Claim { get; set; }
}
