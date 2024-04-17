using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1stchallenge.Data;

public partial class DasherContext : DbContext
{
    public DasherContext()
    {
    }

    public DasherContext(DbContextOptions<DasherContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agreement> Agreements { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employer> Employers { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:dasher.database.windows.net,1433;Initial Catalog=Dasher;Persist Security Info=False;User ID=Radexx;Password=9nSN8n59;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agreement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Status)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Availability)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobTitle).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employer>(entity =>
        {
            entity.ToTable("Employer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
