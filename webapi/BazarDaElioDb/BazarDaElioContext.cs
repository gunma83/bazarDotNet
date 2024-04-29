using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapi.BazarDaElioDb;

public partial class BazarDaElioContext : DbContext
{
    public BazarDaElioContext()
    {
    }

    public BazarDaElioContext(DbContextOptions<BazarDaElioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categories> Categories { get; set; }

    public virtual DbSet<Maschere> Maschere { get; set; }

    public virtual DbSet<Ombrelloni> Ombrelloni { get; set; }

    public virtual DbSet<ScarpetteScogli> ScarpetteScogli { get; set; }
    public virtual DbSet<Gonfiabili> Gonfiabili { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BazarDaElio;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Maschere>(entity =>
        {
            entity.ToTable("Maschere");
        });

        modelBuilder.Entity<Ombrelloni>(entity =>
        {
            entity.ToTable("Ombrelloni");
        });

        modelBuilder.Entity<ScarpetteScogli>(entity =>
        {
            entity.ToTable("ScarpetteScogli");
        });

        modelBuilder.Entity<Elettronica>(entity =>
        {
            entity.ToTable("Elettronica");
        });

        modelBuilder.Entity<Gonfiabili>(entity =>
        {
            entity.ToTable("Gonfiabili");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
